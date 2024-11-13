using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Placemark = SharpKml.Dom.Placemark;
using Point = SharpKml.Dom.Point;

namespace GIS_Toolbox
{
	public partial class LL2kmlForm : Form
	{
		private string fileName = "";

		public LL2kmlForm()
		{
			InitializeComponent();

			this.radioButtonComma.CheckedChanged += new EventHandler(this.radioBtnCheckedChanged);
			this.radioButtonSpace.CheckedChanged += new EventHandler(this.radioBtnCheckedChanged);
			this.radioButtonSemicolon.CheckedChanged += new EventHandler(this.radioBtnCheckedChanged);
			this.radioButtonTab.CheckedChanged += new EventHandler(this.radioBtnCheckedChanged);
			this.radioButtonOther.CheckedChanged += new EventHandler(this.radioBtnCheckedChanged);

			//自适应宽度
			this.dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
		}

		private void buttonImportFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.RestoreDirectory = true;

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				fileName = ofd.FileName;

				DataTable dt = new DataTable();

				string[] lines = File.ReadAllLines(ofd.FileName, Encoding.UTF8);

				dt.Columns.Add("列1");

				foreach (string line in lines)
				{
					dt.Rows.Add(line);
				}
				dataGridView.DataSource = dt;
			}
		}


		public void radioBtnCheckedChanged(object sender, EventArgs e)
		{
			if (!((RadioButton)sender).Checked)
			{
				return;
			}
			else
			{
				if (fileName == "")
				{
					return;
				}
				else
				{
					string[] lines = File.ReadAllLines(fileName, Encoding.UTF8);

					DataTable dt = new DataTable();

					//清除combox内容
					this.comboBoxLng.Items.Clear();
					this.comboBoxLat.Items.Clear();
					this.comboBoxName.Items.Clear();

					//分隔符
					char separator = ' ';

					//判断被选中的radiobutton
					switch (((RadioButton)sender).Name.ToString())
					{
						case "radioButtonComma":
							separator = ',';
							break;

						case "radioButtonSpace":
							separator = ' ';
							break;

						case "radioButtonSemicolon":
							separator = ';';
							break;

						case "radioButtonTab":
							separator = '\t';
							break;
						case "radioButtonOther":
							if (textBoxOther.Text != string.Empty)
							{
								separator = Char.Parse(textBoxOther.Text);
							}
							break;
					}

					//获取列数
					int columnCount = lines[0].Trim().Split(new char[] { separator }, StringSplitOptions.RemoveEmptyEntries).Length;

					//表头
					for (int i = 0; i < columnCount; i++)
					{
						dt.Columns.Add($"列{i + 1}");
					}

					for (int i = 0; i < columnCount; i++)
					{
						this.comboBoxLng.Items.Add($"列{i + 1}");
						this.comboBoxLat.Items.Add($"列{i + 1}");
						this.comboBoxName.Items.Add($"列{i + 1}");
					}

					foreach (string line in lines)
					{
						string[] temp = line.Trim().Split(new char[] { separator }, StringSplitOptions.RemoveEmptyEntries);

						dt.Rows.Add(temp);
					}


					dataGridView.DataSource = dt;
				}
			}
		}

		private void buttonExportKml_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "KML (*.kml)|*.kml";
			saveFileDialog.RestoreDirectory = true;

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				int nameIndex = comboBoxName.SelectedIndex;
				int lngIndex = comboBoxLng.SelectedIndex;
				int latIndex = comboBoxLat.SelectedIndex;

				//创建kml文件
				Kml root = new Kml();
				Document document = new Document();

				int firstLine;
				if (checkBoxSkipFirstLine.Checked) 
				{
					firstLine = 1;
				}
				else
				{
					firstLine = 0;
				}

				for (int i = firstLine; i < dataGridView.Rows.Count - 1; i++)
				{
					string name = dataGridView.Rows[i].Cells[nameIndex].Value.ToString();
					string latString = dataGridView.Rows[i].Cells[latIndex].Value.ToString();
					string lngString = dataGridView.Rows[i].Cells[lngIndex].Value.ToString();

					int degreeIndex = latString.IndexOf("°");

					double lng, lat;
					//未找到°，说明为十进制，不需要转换
					if (degreeIndex == -1)
					{
						lat = Convert.ToDouble(latString);
						lng = Convert.ToDouble(lngString);
					}
					else
					{
						lat = Tools.ConvertDMSToDecimalDegree(latString);
						lng = Tools.ConvertDMSToDecimalDegree(lngString);
					}

					Placemark feature = new Placemark();
					Point point = new Point
					{
						Coordinate = new Vector(lat, lng)
					};
					feature.Geometry = point;
					feature.Name = name;
					document.AddFeature(feature);

				}

				root.Feature = document;

				if (document.Features.Count() > 0)
				{
					KmlFile.Create(root, false).Save(saveFileDialog.FileName);
					MessageBox.Show("导出成功", "提示");
				}
			}
		}
	}
}
