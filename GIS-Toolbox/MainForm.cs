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
using DotSpatial.Projections;
using System.Drawing.Drawing2D;
using GMapUtil;
using GMapCommonType;
using GMapMarkerLib;


namespace GIS_Toolbox
{
	public partial class MainForm : Form
	{
		// polygons overlay
		private GMapOverlay polygonsOverlay = new GMapOverlay("polygonsOverlay");
		// POS markers overlay
		private GMapOverlay posMarkers = new GMapOverlay("posMarkers");

		public MainForm()
		{
			InitializeComponent();
			InitMap();
		}

		private void InitMap()
		{
			//不显示中心十字丝
			gMapControl.ShowCenter = false;
			//鼠标左键拖拽地图
			gMapControl.DragButton = MouseButtons.Left;
			//设置图源
			gMapControl.MapProvider = TianDiTuImageProvider.Instance;

			//设置工作模式
			GMaps.Instance.Mode = AccessMode.ServerAndCache;
			//设置地图中心
			gMapControl.Position = new PointLatLng(28.6985, 115.9705);

			//最大、最小显示级别
			gMapControl.MinZoom = 1;
			gMapControl.MaxZoom = 30;
			//当前显示级别
			gMapControl.Zoom = 8;

			//添加到gmapcontrol
			gMapControl.Overlays.Add(polygonsOverlay);
			gMapControl.Overlays.Add(posMarkers);

			//marker点击事件
			gMapControl.OnMarkerClick += new MarkerClick(GMapControl_OnMarkerClick);

			//polygon双击事件
			gMapControl.OnPolygonDoubleClick += new PolygonDoubleClick(GMapControl_OnPolygonDoubleClick);
		}

		private void GMapControl_OnPolygonDoubleClick(GMapPolygon item, MouseEventArgs e)
		{
			//TODO
		}

		private void GMapControl_OnMarkerClick(GMapMarker item, MouseEventArgs e)
		{
			//DisplayForm displayForm = new DisplayForm(item.ToolTipText);
			//displayForm.Show(this);

			if (File.Exists(item.ToolTipText))
			{
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
				return;
			}
			
		}

		private static double[] ConvertCGCS2000ToWGS84(double x, double y, int centerLng)
		{
			// 定义CGCS2000投影
			ProjectionInfo cgcs2000 = new ProjectionInfo();
			switch (centerLng)
			{
				case 111:
					cgcs2000 = KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM111E;
					break;
				case 114:
					cgcs2000 = KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM114E;
					break;
				case 117:
					cgcs2000 = KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM117E;
					break;
				case 120:
					cgcs2000 = KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM120E;
					break;
			}
				
			// 定义WGS84地理坐标系
			ProjectionInfo wgs84 = KnownCoordinateSystems.Geographic.World.WGS1984;

			// 输入的CGCS2000坐标
			double[] xy = new double[] { x, y };
			double[] z = new double[] { 0 };

			// 执行坐标转换
			Reproject.ReprojectPoints(xy, z, cgcs2000, wgs84, 0, 1);

			// 返回转换后的经纬度
			return new double[] { xy[1], xy[0] }; // 纬度在前，经度在后
		}

		/// <summary>
		/// 度分秒转十进制度
		/// </summary>
		/// <param name="value">度分秒</param>
		/// <returns>十进制度</returns>
		public static double ConvertDMSToDecimalDegree(string value)
		{
			string valueNoSpace = value.Replace(" ", "").Replace('″', '"').Replace("′", "'");

			double decimalDegree = 0.0;
			// 度
			int d = valueNoSpace.IndexOf('°');
			if (d < 0)
			{
				return decimalDegree;
			}
			string degree = valueNoSpace.Substring(0, d);
			decimalDegree += Convert.ToDouble(degree);

			// 分
			int m = valueNoSpace.IndexOf("'");
			if (m < 0)
			{
				return decimalDegree;
			}
			string minute = valueNoSpace.Substring(d + 1, m - d - 1);
			decimalDegree += ((Convert.ToDouble(minute)) / 60);

			// 秒
			int s = valueNoSpace.IndexOf('"');
			if (s < 0)
			{
				return decimalDegree;
			}
			string second = valueNoSpace.Substring(m + 1, s - m - 1);
			decimalDegree += (Convert.ToDouble(second) / 3600);

			return decimalDegree;
		}

		private void 整理Lidar数据ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OrganizeForm organizeForm = new OrganizeForm();
			organizeForm.ShowDialog(this);
		}

		private void DrawPlaceMark(KmlPlaceMark placeMark, bool centerToMark = true,
			bool showToolTip = true, GMarkerGoogleType markerType = GMarkerGoogleType.blue_pushpin, bool isTempMark = false)
		{
			if (((placeMark != null) && (placeMark.Geometry != null)) && (placeMark.Geometry.Points.Count != 0))
			{
				switch (placeMark.Geometry.GeoType)
				{
					case GeometryType.Point:
						{
							GMarkerGoogle item = new GMarkerGoogle(placeMark.Geometry.ToPointLatLngs()[0], markerType);
							this.polygonsOverlay.Markers.Add(item);
							if (showToolTip)
							{
								if (!isTempMark)
								{
									item.ToolTipText = placeMark.Name;
									//item.ToolTipMode = MarkerTooltipMode.OnMouseOver;
									item.ToolTipMode = MarkerTooltipMode.Always;
								}
								else
								{
									item.ToolTipText = placeMark.Description;
								}
							}
							if (centerToMark)
							{
								gMapControl.ZoomAndCenterMarkers(this.polygonsOverlay.Id);
							}
							return;
						}
					case GeometryType.Polyline:
						{
							GMapRoute route = new GMapRoute(placeMark.Geometry.ToPointLatLngs(), "_kmlPolyline")
							{
								IsHitTestVisible = true
							};
							if (showToolTip)
							{
								int num2 = placeMark.Geometry.Points.Count / 2;
								Point2D pointd2 = placeMark.Geometry.Points[num2];
								GMapMarkerEllipse ellipse2 = new GMapMarkerEllipse(pointd2.ToPointLatLngs()[0])
								{
									ToolTipText = string.Format("名称:{0}\r\n类型:{1}\r\n描述:{2}", placeMark.Name, "多边形", placeMark.Description),
									ToolTipMode = MarkerTooltipMode.OnMouseOver
								};
								//route.ToolTipMarker = ellipse2;
								//route.ToolTipPosition = MapRouteToolTipPosition.Custom;
							}
							this.polygonsOverlay.Routes.Add(route);
							if (centerToMark)
							{
								gMapControl.ZoomAndCenterRoute(route);
							}
							return;
						}
					case GeometryType.Polygon:
						{
							GMapPolygon polygon = new GMapPolygon(placeMark.Geometry.ToPointLatLngs(), "_kmlPolygon")
							{
								Stroke = new Pen(Color.FromArgb(0xff, Color.Blue))
							};
							polygon.Stroke.Width = 2f;
							polygon.Stroke.DashStyle = DashStyle.Dash;
							polygon.Fill = new SolidBrush(Color.FromArgb(20, Color.Blue));
							polygon.IsHitTestVisible = true;
							//polygon.EnableRightClick = true;
							if (showToolTip)
							{
								GMapMarkerEllipse ellipse = new GMapMarkerEllipse(placeMark.Geometry.Center.ToPointLatLngs()[0])
								{
									ToolTipText = string.Format("名称:{0}\r\n类型:{1}\r\n描述:{2}", placeMark.Name, "多边形", placeMark.Description),
									ToolTipMode = MarkerTooltipMode.OnMouseOver
								};
								//polygon.ToolTipMarker = ellipse;
								//polygon.ToolTipPosition = MapRouteToolTipPosition.Custom;
							}
							this.polygonsOverlay.Polygons.Add(polygon);
							if (centerToMark)
							{
								gMapControl.ZoomAndCenterRoute(polygon);
								return;
							}
							return;
						}
				}
			}
		}

		private void InitKMLPlaceMarks(List<KmlPlaceMark> placeMarks)
		{
			Polygon polygon = new Polygon();
			
			foreach (KmlPlaceMark mark in placeMarks)
			{
				DrawPlaceMark(mark, false, true, GMarkerGoogleType.blue_pushpin, false);
				polygon.Points.AddRange(mark.Geometry.Points);
			}
			BoundingBox envelope = polygon.Envelope;
			this.gMapControl.SetZoomToFitRect(RectLatLng.FromLTRB(envelope.Left, envelope.Top, envelope.Right, envelope.Bottom));
			this.gMapControl.Position = new PointLatLng(envelope.Center.Y, envelope.Center.X);
		}

		private void ImportKmlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				using (FileDialog dialog = new OpenFileDialog())
				{
					dialog.CheckPathExists = true;
					dialog.CheckFileExists = false;
					dialog.AddExtension = true;
					dialog.ValidateNames = true;
					dialog.Title = "选择KML文件";
					dialog.FilterIndex = 1;
					dialog.RestoreDirectory = true;
					dialog.Filter = "KML文件 (*.kml)|*.kml|所有文件 (*.*)|*.*";
					if (dialog.ShowDialog() == DialogResult.OK)
					{
						//this.polygonsOverlay.Clear();
						InitKMLPlaceMarks(KmlUtil.GetPlaceMarksFromKmlFile(dialog.FileName));
					}
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show("读取KML文件时出现异常");
                Console.WriteLine(exception);
			}
		}

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

		private void Ll2kmlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ll2kmlForm ll2KmlForm = new ll2kmlForm();
			ll2KmlForm.ShowDialog(this);
		}

		private void ExtractColumnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ExtractColumnForm extractColumnForm = new ExtractColumnForm();
			extractColumnForm.ShowDialog(this);
		}

		private void ClearPOSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			posMarkers.Clear();
			MessageBox.Show("清除成功", "提示");
		}

		private void ClearAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			posMarkers.Clear();
			polygonsOverlay.Clear();
			MessageBox.Show("清除成功", "提示");
		}

		private void HuaceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			POSForm posForm = new POSForm();
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

						GMapOverlay pointMarkers = new GMapOverlay(imageDir);

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
									double[] latlon = ConvertCGCS2000ToWGS84(x, y, centerLng);

									PointLatLng point = new PointLatLng(latlon[0], latlon[1]);

									GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_small);
									marker.ToolTipText = imageFile;

									posMarkers.Markers.Add(marker);
								}
							}
						}

						gMapControl.Overlays.Add(pointMarkers);
					}
					else
					{
						MessageBox.Show("POS文件不存在", "错误");
					}
				}
				gMapControl.ZoomAndCenterMarkers(null);
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
										latitude = ConvertDMSToDecimalDegree(tag.Description);
									}
									if (tag.Name == "GPS Longitude")
									{
										longitude = ConvertDMSToDecimalDegree(tag.Description);
									}
								}
							}
						}

						PointLatLng point = new PointLatLng(latitude, longitude);

						GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_small);
						marker.ToolTipText = fileName;

						posMarkers.Markers.Add(marker);
					}
				}
				gMapControl.ZoomAndCenterMarkers(null);
			}
		}

		private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutBox aboutBox = new AboutBox();
			aboutBox.ShowDialog(this);
		}

		private void TianDiTuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			gMapControl.MapProvider = TianDiTuVectorProvider.Instance;
		}

		private void TianDiTuImageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			gMapControl.MapProvider = TianDiTuImageProvider.Instance;
		}

		private void BingImageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//this.gMapControl.MapProvider = GMapProviders.BingSatelliteMap;
			this.gMapControl.MapProvider = GMapProviders.BingHybridMap;
		}
	}
}
