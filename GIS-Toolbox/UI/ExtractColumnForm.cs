using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIS_Toolbox
{
	public partial class ExtractColumnForm : Form
	{
		private string fileName = "";
		private string[] separators = new string[] { " ", ",", "\t" };

		public ExtractColumnForm()
		{
			InitializeComponent();

			//自适应宽度
			this.dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

			//添加事件
			this.checkBoxComma.CheckedChanged += new EventHandler(this.CheckBoxCheckedChanged);
			this.checkBoxSpace.CheckedChanged += new EventHandler(this.CheckBoxCheckedChanged);
			this.checkBoxTab.CheckedChanged += new EventHandler(this.CheckBoxCheckedChanged);
			this.checkBoxOther.CheckedChanged += new EventHandler(this.CheckBoxCheckedChanged);

			//添加分隔符
			this.comboBoxSeparator.Items.Add("空格");
			this.comboBoxSeparator.Items.Add("逗号");
			this.comboBoxSeparator.Items.Add("Tab键");
			this.comboBoxSeparator.SelectedIndex = 0;
		}

		private void buttonImportFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog
			{
				RestoreDirectory = true
			};

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


		public void CheckBoxCheckedChanged(object sender, EventArgs e)
		{
			List<char> separator = new List<char>();

			if (checkBoxComma.Checked)
			{
				separator.Add(',');
			}
			if (checkBoxSpace.Checked)
			{
				separator.Add(' ');
			}
			if (checkBoxTab.Checked)
			{
				separator.Add('\t');
			}
			if (checkBoxOther.Checked)
			{
				if (textBoxOther.Text != "")
				{
					separator.Add(Char.Parse(textBoxOther.Text));
				}
			}

			string[] lines = File.ReadAllLines(fileName, Encoding.UTF8);

			DataTable dt = new DataTable();

			//获取列数
			int columnCount = lines[0].Trim().Split(separator.ToArray(), StringSplitOptions.RemoveEmptyEntries).Length;

			//表头
			for (int i = 0; i < columnCount; i++)
			{
				dt.Columns.Add($"列{i + 1}");
			}

			foreach (string line in lines)
			{
				string[] temp = line.Trim().Split(separator.ToArray(), StringSplitOptions.RemoveEmptyEntries);

				dt.Rows.Add(temp);
			}


			dataGridView.DataSource = dt;
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "txt (*.txt)|*.txt|cass文件 (*.dat)|*.dat";
			saveFileDialog.RestoreDirectory = true;

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				if(textBoxColumnNum.Text != "")
				{
					string[] temp = textBoxColumnNum.Text.Trim().Split(new char[] {' ', ',', '，', '-'}, StringSplitOptions.RemoveEmptyEntries);

					int firstLine;
					if (checkBoxSkip.Checked)
					{
						firstLine = 1;
					}
					else
					{
						firstLine = 0;
					}

					//新建文件
					string outputFileName = saveFileDialog.FileName;
					string fileExtension = Path.GetExtension(outputFileName);

					FileInfo outputFile = new FileInfo(outputFileName);
					StreamWriter sw = outputFile.CreateText();

					for (int i = firstLine; i < dataGridView.Rows.Count - 1; i++)
					{
						List<string> colData = new List<string>();
						foreach (string j in temp)
						{
							int index = Convert.ToInt32(j) - 1;

							string col = dataGridView.Rows[i].Cells[index].Value.ToString();

							//dat文件
							if (fileExtension == ".dat" && j == temp[0])
							{
								col += ',';
							}
							colData.Add(col);
						}
						if (fileExtension == ".dat")
						{
							sw.WriteLine(string.Join(",", colData));
						}
						else
						{
							sw.WriteLine(string.Join(separators[comboBoxSeparator.SelectedIndex], colData));
						}
					}

					sw.Close();
					MessageBox.Show("导出成功", "提示");
				}
			}
		}
	}
}
