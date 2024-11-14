using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MetadataExtractor;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Drawing.Drawing2D;
using GMapUtil;
using GMapCommonType;
using System.Linq;
using GMapTools;
using GMapDrawTools;
using System.ComponentModel;
using IxMilia.Dxf;
using IxMilia.Dxf.Entities;


namespace GIS_Toolbox
{
	public partial class MainForm : Form
	{
		private GMapMarker currentMarker;
		public MainForm()
		{
			InitializeComponent();
			InitMap();

			//添加treeView根节点
			TreeNode rootNode = new TreeNode("图层管理")
			{
				Tag = "图层管理",//树节点数据
				Text = "图层管理"//节点标签显示内容
			};

			this.treeView.Nodes.Add(rootNode);

			//treeView设置
			this.treeView.CheckBoxes = true;
			this.treeView.Nodes[0].Checked = true;

			//treeView checkbox
			this.treeView.AfterCheck += TreeView_AfterCheck;
			this.treeView.NodeMouseDoubleClick += TreeView_NodeMouseDoubleClick;

			//backgroundworker设置
			this.backgroundWorker.WorkerReportsProgress = true;
			this.backgroundWorker.WorkerSupportsCancellation = true;

			this.backgroundWorker.DoWork += BackgroundWorker_DoWork;
			this.backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
			this.backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
		}

		private void InitMap()
		{
			//不显示中心十字丝
			this.gMapControl.ShowCenter = false;
			//鼠标左键拖拽地图
			this.gMapControl.DragButton = MouseButtons.Left;
			//设置图源
			//gMapControl.MapProvider = TianDiTuImageProvider.Instance;
			this.gMapControl.MapProvider = GMapProviders.BingHybridMap;

			//设置工作模式
			GMaps.Instance.Mode = AccessMode.ServerAndCache;
			//设置地图中心
			this.gMapControl.Position = new PointLatLng(28.6989, 115.9710);

			//最大、最小显示级别
			this.gMapControl.MinZoom = 1;
			this.gMapControl.MaxZoom = 30;
			//当前显示级别
			this.gMapControl.Zoom = 10;

			//marker点击事件
			this.gMapControl.OnMarkerClick += new MarkerClick(GMapControl_OnMarkerClick);

			//polygon双击事件
			this.gMapControl.OnPolygonDoubleClick += new PolygonDoubleClick(GMapControl_OnPolygonDoubleClick);

			//测距
			drawDistance = new DrawDistance(this.gMapControl);
			drawDistance.DrawComplete += new EventHandler<DrawDistanceEventArgs>(drawDistance_DrawComplete);

			//绘图
			draw = new Draw(this.gMapControl);
			draw.DrawComplete += new EventHandler<DrawEventArgs>(draw_DrawComplete);
		}

		private void GMapControl_OnPolygonDoubleClick(GMapPolygon item, MouseEventArgs e)
		{
			//TODO
		}

		/// <summary>
		/// treeView节点双击事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// <exception cref="NotImplementedException"></exception>
		private void TreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			string name = e.Node.Name;

			List<GMapOverlay> mapOverlays = this.gMapControl.Overlays.ToList();

			foreach (GMapOverlay overlay in mapOverlays)
			{
				if (overlay.Id == name)
				{
					if (overlay.Markers.Count > 0)
					{
						this.gMapControl.ZoomAndCenterMarkers(name);
					}
					if (overlay.Routes.Count > 0)
					{
						this.gMapControl.ZoomAndCenterRoutes(name);
					}
					if (overlay.Polygons.Count > 0)
					{
						this.gMapControl.ZoomAndCenterRoute(overlay.Polygons[0]);
					}

					this.gMapControl.Refresh();
				}
			}
		}

		/// <summary>
		/// marker单击事件
		/// </summary>
		/// <param name="item"></param>
		/// <param name="e"></param>
		private void GMapControl_OnMarkerClick(GMapMarker item, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				//检查图片是否存在，存在则显示
				if (File.Exists(item.ToolTipText))
				{
					//DisplayForm displayForm = new DisplayForm(item.ToolTipText);
					//displayForm.Show(this);

					//调用系统默认图片浏览器查看图片
					//建立新的系统进程
					System.Diagnostics.Process process = System.Diagnostics.Process.GetCurrentProcess();
					//设置图片路径
					process.StartInfo.FileName = item.ToolTipText;
					//设置进程运行参数，这里以最大化窗口方法显示图片 
					process.StartInfo.Arguments = "rundl132.exe C://WINDOWS//system32//shimgvw.dll,ImageView_Fullscreen";
					//此项为是否使用Shell执行程序，因系统默认为true，此项也可不设，但若设置必须为true    
					process.StartInfo.UseShellExecute = true;

					//此处可以更改进程所打开窗体的显示样式，可以不设
					process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
					process.Start();
					process.Close();
				}
				else
				{
					//删除测距marker
					if (item is DrawDeleteMarker)
					{
						currentMarker = item as DrawDeleteMarker;

						GMapOverlay overlay = currentMarker.Overlay;
						if (overlay.Markers.Contains(currentMarker))
						{
							overlay.Markers.Remove(currentMarker);
						}

						if (this.gMapControl.Overlays.Contains(overlay))
						{
							this.gMapControl.Overlays.Remove(overlay);
						}
					}
				}
			}
		}

		private void 整理Lidar数据ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OrganizeForm organizeForm = new OrganizeForm();
			organizeForm.ShowDialog(this);
		}

		#region 导入kml
		private void DrawPlaceMark(GMapOverlay kmlOverlay, List<KmlPlaceMark> placeMarks, bool showToolTip, GMarkerGoogleType markerType, Color lineColor)
		{
			foreach (KmlPlaceMark placeMark in placeMarks)
			{
				if (((placeMark != null) && (placeMark.Geometry != null)) && (placeMark.Geometry.Points.Count != 0))
				{
					switch (placeMark.Geometry.GeoType)
					{
						case GeometryType.Point:
							{
								GMarkerGoogle item = new GMarkerGoogle(placeMark.Geometry.ToPointLatLngs()[0], markerType);
								item.ToolTipText = placeMark.Name;

								if (showToolTip)
								{
									item.ToolTipMode = MarkerTooltipMode.Always;
								}
								else
								{
									item.ToolTipMode = MarkerTooltipMode.OnMouseOver;
								}

								kmlOverlay.Markers.Add(item);
								break;
							}
						case GeometryType.Polyline:
							{
								GMapRoute route = new GMapRoute(placeMark.Geometry.ToPointLatLngs(), placeMark.Name)
								{
									IsHitTestVisible = true,
									Stroke = new Pen(lineColor, 2)
								};

								kmlOverlay.Routes.Add(route);
								break;
							}
						case GeometryType.Polygon:
							{
								GMapPolygon polygon = new GMapPolygon(placeMark.Geometry.ToPointLatLngs(), placeMark.Name)
								{
									Stroke = new Pen(Color.FromArgb(0xff, lineColor))
								};
								polygon.Stroke.Width = 2f;
								polygon.Stroke.DashStyle = DashStyle.Dash;
								polygon.Fill = new SolidBrush(Color.FromArgb(20, lineColor));
								polygon.IsHitTestVisible = true;

								kmlOverlay.Polygons.Add(polygon);
								break;
							}
					}
				}
			}
		}


		private void ImportKmlToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog
			{
				CheckPathExists = true,
				CheckFileExists = false,
				AddExtension = true,
				ValidateNames = true,
				Title = "选择KML文件",
				FilterIndex = 1,
				RestoreDirectory = true,
				Filter = "KML文件 (*.kml)|*.kml|所有文件 (*.*)|*.*",
				Multiselect = true
			};

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				foreach (string fileName in dialog.FileNames)
				{
					string overlayId = fileName + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");

					GMapOverlay kmlOverlay = new GMapOverlay(overlayId);
					this.gMapControl.Overlays.Add(kmlOverlay);

					List<KmlPlaceMark> placeMarks = KmlUtil.GetPlaceMarksFromKmlFile(fileName);
					DrawPlaceMark(kmlOverlay, placeMarks, false, GMarkerGoogleType.blue_small, Color.Blue);

					//添加node节点
					Tools.addChildNode(this.treeView.Nodes[0], overlayId, fileName);

					//缩放显示
					if (kmlOverlay.Markers.Count > 0)
					{
						this.gMapControl.ZoomAndCenterMarkers(kmlOverlay.Id);
					}
					if (kmlOverlay.Routes.Count > 0)
					{
						this.gMapControl.ZoomAndCenterRoutes(kmlOverlay.Id);
					}
					if (kmlOverlay.Polygons.Count > 0)
					{
						this.gMapControl.ZoomAndCenterRoute(kmlOverlay.Polygons[0]);
					}
				}

			}
		}

		private void ImportKmlProToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ImportKmlProForm form = new ImportKmlProForm();
			DialogResult dialogResult = form.ShowDialog(this);

			if (dialogResult == DialogResult.OK)
			{
				string[] kmlFiles = form.GetKmlFiles();
				GMarkerGoogleType markerType = form.GetMarkerType();
				Color lineColor = form.GetLineColor();
				bool showToolTip = form.GetShowToolTip();


				foreach (string fileName in kmlFiles)
				{
					string overlayId = fileName + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");

					GMapOverlay kmlOverlay = new GMapOverlay(overlayId);

					List<KmlPlaceMark> placeMarks = KmlUtil.GetPlaceMarksFromKmlFile(fileName);
					DrawPlaceMark(kmlOverlay, placeMarks, showToolTip, markerType, lineColor);

					//添加node节点
					Tools.addChildNode(this.treeView.Nodes[0], overlayId, fileName);

					this.gMapControl.Overlays.Add(kmlOverlay);

					//缩放显示
					if (kmlOverlay.Markers.Count > 0)
					{
						this.gMapControl.ZoomAndCenterMarkers(kmlOverlay.Id);
					}
					if (kmlOverlay.Routes.Count > 0)
					{
						this.gMapControl.ZoomAndCenterRoutes(kmlOverlay.Id);
					}
					if (kmlOverlay.Polygons.Count > 0)
					{
						this.gMapControl.ZoomAndCenterRoute(kmlOverlay.Polygons[0]);
					}
				}
			}
		}

		#endregion

		private void MergePOSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MergePOSForm mergePOSForm = new MergePOSForm();
			mergePOSForm.ShowDialog(this);
		}

		private void DeleteFilesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DeleteFilesForm deleteFilesForm = new DeleteFilesForm();
			deleteFilesForm.ShowDialog(this);
		}

		private void LL2KmlToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			LL2kmlForm ll2KmlForm = new LL2kmlForm();
			ll2KmlForm.ShowDialog(this);
		}

		private void ExtractColumnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ExtractColumnForm extractColumnForm = new ExtractColumnForm();
			extractColumnForm.ShowDialog(this);
		}

		private void ClearPOSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			List<GMapOverlay> mapOverlays = this.gMapControl.Overlays.ToList();

			foreach (GMapOverlay mapOverlay in mapOverlays)
			{
				if (!mapOverlay.Id.EndsWith(".kml"))
				{
					this.gMapControl.Overlays.Remove(mapOverlay);
					this.treeView.Nodes[0].Nodes.RemoveByKey(mapOverlay.Id);
				}
			}
			this.gMapControl.Refresh();

			MessageBox.Show("清除成功", "提示");
		}

		private void ClearAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.gMapControl.Overlays.Clear();
			this.treeView.Nodes[0].Nodes.Clear();

			this.gMapControl.Refresh();

			MessageBox.Show("清除成功", "提示");
		}

		private void HuaceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			HuacePOSForm posForm = new HuacePOSForm();
			posForm.StartPosition = FormStartPosition.CenterParent;

			DialogResult dialogResult = posForm.ShowDialog(this);

			if (dialogResult == DialogResult.OK)
			{
				// 照片文件路径
				string[] imageDirs = posForm.getImageDir();
				// 中央子午线经度
				int centerLng = int.Parse(posForm.getCenterLng());

				foreach (string imageDir in imageDirs)
				{
					// pos文件
					string posFile = imageDir + "\\Metashape.txt";

					if (File.Exists(posFile))
					{
						string overlayId = imageDir + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");

						GMapOverlay pointMarkers = new GMapOverlay(overlayId);

						string[] lines = File.ReadAllLines(posFile, Encoding.ASCII);
						foreach (string line in lines)
						{
							if (Array.IndexOf(lines, line) != 0)
							{
								string[] temp = line.Split();

								double x = double.Parse(temp[1]);
								double y = double.Parse(temp[2]);

								// 图片路径
								string imageFile = imageDir + "\\" + temp[0];

								// 检测图片是否存在，不存在则不添加marker
								if (File.Exists(imageFile))
								{
									double[] latlon = Tools.ConvertCGCS2000ToWGS84(x, y, centerLng);

									PointLatLng point = new PointLatLng(latlon[0], latlon[1]);

									GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_small);
									marker.ToolTipText = imageFile;

									pointMarkers.Markers.Add(marker);
								}
							}
						}

						//添加node节点
						Tools.addChildNode(this.treeView.Nodes[0], overlayId, imageDir);

						//添加图层
						this.gMapControl.Overlays.Add(pointMarkers);

						//只缩放显示最后一次加载的图层
						if (Array.IndexOf(imageDirs, imageDir) == imageDirs.Length - 1)
						{
							this.gMapControl.ZoomAndCenterMarkers(pointMarkers.Id);
						}
					}
					else
					{
						MessageBox.Show("POS文件不存在", "错误");
					}
				}
			}
		}

		private void DJIToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "图片|*.jpg";
			openFileDialog.RestoreDirectory = true;
			openFileDialog.Multiselect = true;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string[] fileNames = openFileDialog.FileNames;

				string imageDir = Path.GetDirectoryName(fileNames[0]);

				string overlayId = imageDir + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");

				//添加node节点
				Tools.addChildNode(this.treeView.Nodes[0], overlayId, imageDir);

				GMapOverlay pointMarkers = new GMapOverlay(overlayId);

				this.gMapControl.Overlays.Add(pointMarkers);

				foreach (string fileName in fileNames)
				{
					if (File.Exists(fileName))
					{
						double longitude = 0.0;
						double latitude = 0.0;
						var directories = ImageMetadataReader.ReadMetadata(fileName);
						foreach (var directory in directories)
						{
							if (directory.Name == "GPS")
							{
								foreach (var tag in directory.Tags)
								{
									if (tag.Name == "GPS Latitude")
									{
										latitude = Tools.ConvertDMSToDecimalDegree(tag.Description);
									}
									if (tag.Name == "GPS Longitude")
									{
										longitude = Tools.ConvertDMSToDecimalDegree(tag.Description);
									}
								}
							}
						}

						PointLatLng point = new PointLatLng(latitude, longitude);

						GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_small);
						marker.ToolTipText = fileName;

						pointMarkers.Markers.Add(marker);
					}
				}

				this.gMapControl.ZoomAndCenterMarkers(pointMarkers.Id);
			}
		}

		#region treeView
		private void TreeView_AfterCheck(object sender, TreeViewEventArgs e)
		{
			if (e.Action == TreeViewAction.ByMouse)
			{
				if (e.Node.Checked)
				{
					setParentNodeChecked(e.Node);
					setChildNodeChecked(e.Node);
				}
				else
				{
					setChildNodeCancel(e.Node);
					setParentNodeCancel(e.Node);
				}
			}
		}

		private void setChildNodeCancel(TreeNode node)//取消所有子节点的选择
		{
			foreach (TreeNode a in node.Nodes)
			{
				if (a != null)
				{
					a.Checked = false;
					setChildNodeCancel(a);
				}
			}
		}

		private void setParentNodeCancel(TreeNode node)//取消祖先结点选择
		{
			if (node.Parent != null && judegChildChecked(node.Parent))
			{
				TreeNode parent;
				node.Parent.Checked = false;
				parent = node.Parent;
				setParentNodeCancel(parent);
			}
		}

		private void setParentNodeChecked(TreeNode t)//选择所有祖先结点
		{
			TreeNode parent = t.Parent;
			while (parent != null && parent.Checked == false)
			{
				parent.Checked = true;
				parent = parent.Parent;
			}
		}
		private void setChildNodeChecked(TreeNode t)//勾选所有子节点
		{

			foreach (TreeNode a in t.Nodes)
			{
				if (a != null)
				{
					a.Checked = true;
					setChildNodeChecked(a);
				}
			}

		}
		private bool judegChildChecked(TreeNode t)//判断其子节点是否有勾选状态
		{
			foreach (TreeNode a in t.Nodes)
			{
				if (a != null && a.Checked == true)
				{
					return false;
				}
			}
			return true;
		}

		#endregion

		private void TianDiTuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.gMapControl.MapProvider = TianDiTuVectorProvider.Instance;
		}

		private void TianDiTuImageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.gMapControl.MapProvider = TianDiTuImageProvider.Instance;
		}

		private void BingImageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//this.gMapControl.MapProvider = GMapProviders.BingSatelliteMap;
			this.gMapControl.MapProvider = GMapProviders.BingHybridMap;
		}

		#region 另存为kml

		private void SaveKmlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				Filter = "kml文件 (*.kml)|*.kml",
				RestoreDirectory = true
			};

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				//被选中的节点
				TreeNode selectedNode = this.treeView.SelectedNode;

				foreach (GMapOverlay overlay in this.gMapControl.Overlays)
				{
					if (overlay.Id == selectedNode.Name)
					{
						string filename = saveFileDialog.FileName;
						Tools.SaveKmlFile(overlay, filename);
					}
				}

				MessageBox.Show("保存成功", "提示");
			}
		}

		private void SaveKmlCheckedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				Filter = "kml文件 (*.kml)|*.kml",
				RestoreDirectory = true
			};

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				GMapOverlay outOverlay = new GMapOverlay();
				string filename = saveFileDialog.FileName;

				foreach (TreeNode node in this.treeView.Nodes[0].Nodes)
				{
					if (node.Checked)
					{
						foreach (GMapOverlay overlay in this.gMapControl.Overlays)
						{
							if (overlay.Id == node.Name)
							{
								if (overlay.Markers.Count > 0)
								{
									foreach (GMapMarker marker in overlay.Markers)
									{
										outOverlay.Markers.Add(marker);
									}

								}
								if (overlay.Routes.Count > 0)
								{
									foreach (GMapRoute route in overlay.Routes)
									{
										outOverlay.Routes.Add(route);
									}
								}
								if (overlay.Polygons.Count > 0)
								{
									foreach (GMapPolygon polygon in overlay.Polygons)
									{
										outOverlay.Polygons.Add(polygon);
									}
								}
							}
						}
					}
				}

				Tools.SaveKmlFile(outOverlay, filename);
				MessageBox.Show("保存成功", "提示");
			}
		}

		#endregion

		#region 导出范围内图片

		CopyProgressForm copyProgressForm = new CopyProgressForm();

		private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			int pictureCount = (int)e.UserState;

			copyProgressForm.SetProgressBarMax(pictureCount);
			copyProgressForm.SetProgressBarValue(e.ProgressPercentage);

			double percentage = Math.Round((double)e.ProgressPercentage / pictureCount * 100, 1);

			copyProgressForm.SetPercentage(percentage);
		}

		private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			copyProgressForm.Close();
			MessageBox.Show("完成", "提示");
		}

		private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorker backgroundWorker = sender as BackgroundWorker;

			var pictureDict = (Dictionary<string, List<string>>)e.Argument;

			//获取图片数量
			int pictureCount = 0;
			foreach (List<string> pictures in pictureDict.Values)
			{
				pictureCount = pictureCount + pictures.Count;
			}

			int i = 0;
			//复制图片和POS
			foreach (string folder in pictureDict.Keys)
			{
				//新建POS文件
				FileInfo outputPos = new FileInfo(folder + "/Metashape.txt");
				StreamWriter sw = outputPos.CreateText();

				foreach (string picture in pictureDict[folder])
				{
					//复制图片
					string picName = Path.GetFileName(picture);
					File.Copy(picture, Path.Combine(folder, picName));

					//复制POS
					string inputPos = Path.Combine(Path.GetDirectoryName(picture), "Metashape.txt");
					if (File.Exists(inputPos))
					{
						string pos = Tools.GetPosUsingName(inputPos, picName);
						if (pos != null)
						{
							sw.WriteLine(pos);
						}
					}

					//使用backgroundWorker传输进度
					backgroundWorker.ReportProgress(++i, pictureCount);
				}

				sw.Close();
			}
		}


		private void ExportImageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FolderSelectDialogMulti.FolderSelectDialogMulti dialog = new FolderSelectDialogMulti.FolderSelectDialogMulti
			{
				Title = "选择文件夹（支持多选）"
			};

			if (dialog.ShowDialog(this.Handle))
			{
				string rootFolder = dialog.FileName;

				//被选中节点
				TreeNode selectedNode = this.treeView.SelectedNode;

				//新建一个字典，存放查找出来的图片路径和被存放路径
				Dictionary<string, List<string>> pictureDict = new Dictionary<string, List<string>>();

				//遍历查找
				int i = 0;
				int pictureCount = 0;  //图片数量

				foreach (GMapOverlay overlay in this.gMapControl.Overlays)
				{
					if (overlay.Id == selectedNode.Name)
					{
						if (overlay.Polygons.Count > 0)
						{
							List<string> images = new List<string>();

							foreach (GMapPolygon polygon in overlay.Polygons)
							{
								i++;
								List<string> picture = new List<string>();

								//新建文件夹
								string folder = rootFolder + "/" + polygon.Name + i.ToString();

								if (!System.IO.Directory.Exists(folder))
								{
									System.IO.Directory.CreateDirectory(folder);
								}

								//查找图片
								foreach (GMapOverlay overlay2 in this.gMapControl.Overlays)
								{
									if (overlay2 != overlay && overlay2.Markers.Count > 0)
									{
										foreach (GMapMarker marker in overlay2.Markers)
										{
											if (polygon.IsInside(marker.Position))
											{
												//图片路径
												string picPath = marker.ToolTipText;
												//图片存在则添加
												if (File.Exists(picPath))
												{
													picture.Add(picPath);
													pictureCount++;
												}
											}
										}
									}
								}

								pictureDict.Add(folder, picture);
							}

							//开始执行后台操作，并传递参数
							this.backgroundWorker.RunWorkerAsync(pictureDict);

							//显示进度条
							copyProgressForm.ShowDialog(this);
						}
						else
						{
							MessageBox.Show("不包含闭合多段线，请重新选择!", "提示");
						}
					}
				}
			}
		}

		#endregion

		private void DeleteLayerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			List<GMapOverlay> mapOverlays = this.gMapControl.Overlays.ToList();

			TreeNode selectedNode = this.treeView.SelectedNode;

			foreach (GMapOverlay overlay in mapOverlays)
			{
				if (overlay.Id == selectedNode.Name)
				{
					this.gMapControl.Overlays.Remove(overlay);
					this.treeView.Nodes[0].Nodes.RemoveByKey(overlay.Id);
				}
			}

			this.gMapControl.Refresh();
		}

		private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutBox aboutBox = new AboutBox();
			aboutBox.ShowDialog(this);
		}

		private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(Application.StartupPath.ToString() + "\\HelpDoc\\help.pdf");
		}


		//测距
		private DrawDistance drawDistance;
		private void MeasureDistanceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			drawDistance.IsEnable = true;
		}

		private void drawDistance_DrawComplete(object sender, DrawDistanceEventArgs e)
		{
			if (e != null)
			{
				GMapOverlay distanceOverlay = new GMapOverlay();
				this.gMapControl.Overlays.Add(distanceOverlay);
				foreach (LineMarker line in e.LineMarkers)
				{
					distanceOverlay.Markers.Add(line);
				}
				foreach (DrawDistanceMarker marker in e.DistanceMarkers)
				{
					distanceOverlay.Markers.Add(marker);
				}
				distanceOverlay.Markers.Add(e.DistanceDeleteMarker);
			}
			drawDistance.IsEnable = false;
		}

		//绘图
		private Draw draw;

		private void DrawPolylineToolStripMenuItem_Click(object sender, EventArgs e)
		{
			draw.DrawingMode = DrawingMode.Route;
			draw.IsEnable = true;
		}

		private void DrawPolygonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			draw.DrawingMode = DrawingMode.Polygon;
			draw.IsEnable = true;
		}

		private void draw_DrawComplete(object sender, DrawEventArgs e)
		{
			if (e != null && (e.Polygon != null || e.Route != null))
			{
				switch (e.DrawingMode)
				{
					case DrawingMode.Polygon:
						//添加node节点
						string polygonName = "polygon_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");

						Tools.addChildNode(this.treeView.Nodes[0], polygonName, polygonName);

						GMapOverlay polygonOverlay = new GMapOverlay(polygonName);
						//要先添加到图层，然后再添加多段线
						this.gMapControl.Overlays.Add(polygonOverlay);
						polygonOverlay.Polygons.Add(e.Polygon);

						break;

					case DrawingMode.Route:
						//添加node节点
						string routeName = "polyline_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");

						Tools.addChildNode(this.treeView.Nodes[0], routeName, routeName);

						GMapOverlay routeOverlay = new GMapOverlay(routeName);
						this.gMapControl.Overlays.Add(routeOverlay);
						routeOverlay.Routes.Add(e.Route);

						break;

					default:
						draw.IsEnable = false;
						break;
				}
			}
			draw.IsEnable = false;
		}

		private void ToDxfToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				Filter = "dxf文件 (*.dxf)|*.dxf",
				RestoreDirectory = true
			};

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				//被选中的节点
				TreeNode selectedNode = this.treeView.SelectedNode;

				foreach (GMapOverlay overlay in this.gMapControl.Overlays)
				{
					if (overlay.Id == selectedNode.Name)
					{
						string filename = saveFileDialog.FileName;

						//新建dxf文件
						DxfFile dxfFile = new DxfFile();

						if (overlay.Markers.Count > 0)
						{
							foreach (GMapMarker marker in overlay.Markers)
							{
								double lat = marker.Position.Lat;
								double lng = marker.Position.Lng;

								//坐标转换
								double[] xy = Tools.ConvertWGS84ToCGCS2000(lat, lng);

								DxfPoint dxfPoint = new DxfPoint(xy[0], xy[1], 0);

								DxfText dxfText = new DxfText(dxfPoint, 50, marker.ToolTipText);

								dxfFile.Entities.Add(dxfText);
							}
						}

						if (overlay.Routes.Count > 0)
						{
							foreach (GMapRoute route in overlay.Routes)
							{
								List<DxfVertex> vertices = new List<DxfVertex>();

								foreach (PointLatLng pointLatLng in route.Points)
								{
									double lat = pointLatLng.Lat;
									double lng = pointLatLng.Lng;

									//坐标转换
									double[] xy = Tools.ConvertWGS84ToCGCS2000(lat, lng);

									vertices.Add(new DxfVertex(new DxfPoint(xy[0], xy[1], 0)));
								}

								DxfPolyline dxfPolyline = new DxfPolyline(vertices);

								dxfFile.Entities.Add(dxfPolyline);
							}
						}

						if (overlay.Polygons.Count > 0)
						{
							foreach(GMapPolygon polygon in overlay.Polygons)
							{
								List<DxfVertex> vertices = new List<DxfVertex>();

								foreach (PointLatLng pointLatLng in polygon.Points)
								{
									double lat = pointLatLng.Lat;
									double lng = pointLatLng.Lng;

									//坐标转换
									double[] xy = Tools.ConvertWGS84ToCGCS2000(lat, lng);

									vertices.Add(new DxfVertex(new DxfPoint(xy[0], xy[1], 0)));
								}

								DxfPolyline dxfPolyline = new DxfPolyline(vertices);
								dxfPolyline.IsClosed = true;

								dxfFile.Entities.Add(dxfPolyline);
							}
						}

						dxfFile.Save(filename);
					}
				}

				MessageBox.Show("保存成功", "提示");
			}
		}
	}
}
