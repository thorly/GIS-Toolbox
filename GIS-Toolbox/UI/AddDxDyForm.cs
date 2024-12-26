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
	public partial class AddDxDyForm : Form
	{
		public AddDxDyForm()
		{
			InitializeComponent();

			//添加水平和垂直精度
			comboBoxDx.Items.Add("0.01");
			comboBoxDx.Items.Add("0.02");
			comboBoxDx.Items.Add("0.03");
			comboBoxDx.SelectedIndex = 2;

			comboBoxDy.Items.Add("0.01");
			comboBoxDy.Items.Add("0.02");
			comboBoxDy.Items.Add("0.03");
			comboBoxDy.SelectedIndex = 2;

		}

		private void buttonOpenPOS_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.RestoreDirectory = true;

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				textBoxPOS.Text = ofd.FileName;
			}
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			string inputPOSFile = textBoxPOS.Text;
			string dx = comboBoxDx.Text;
			string dy = comboBoxDy.Text;
			
			string dirName = Path.GetDirectoryName(inputPOSFile);
			string fileNameWithExtension = Path.GetFileNameWithoutExtension(inputPOSFile);
			string fileExtension = Path.GetExtension(inputPOSFile);

			//创建一个输出的POS文件
			string outputPOSFile = Path.Combine(dirName, fileNameWithExtension + "_DxDy" + fileExtension);
			FileInfo outputFile = new FileInfo(outputPOSFile);
			StreamWriter sw = outputFile.CreateText();

			//读取POS文件
			string[] lines = File.ReadAllLines(inputPOSFile, Encoding.UTF8);

			//添加水平和垂直精度
			for (int i = 0; i < lines.Length; i++)
			{
				//首行添加Dx，Dy
				if (checkBoxSkipFirstLine.Checked && i == 0)
				{
					sw.WriteLine(lines[i] + "\tDx\tDy");
				}
				//其他行添加精度
				else
				{
					sw.WriteLine(lines[i] + $"\t{dx}\t{dy}");
				}
			}

			sw.Close();
			MessageBox.Show($"POS文件已保存至{outputPOSFile},\n请查看是否有误", "提示");
		}
	}
}
