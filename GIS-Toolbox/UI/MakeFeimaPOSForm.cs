using MetadataExtractor;
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
	public partial class MakeFeimaPOSForm : Form
	{
		public MakeFeimaPOSForm()
		{
			InitializeComponent();
		}

		private void buttonImage_Click(object sender, EventArgs e)
		{
			FolderSelectDialogSingle.FolderSelectDialogSingle dialog = new FolderSelectDialogSingle.FolderSelectDialogSingle
			{
				Title = "选择文件夹"
			};

			if (dialog.ShowDialog(this.Handle))
			{
				textBoxImage.Text = dialog.FileName;
				textBoxOutPOS.Text = Path.Combine(dialog.FileName, "MetaShape.txt");
			}
		}

		private void buttonPOS_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.RestoreDirectory = true;

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				textBoxPOS.Text = ofd.FileName;
			}
		}

		private static List<string> MakeFeimaPOS(string cameraDir, string posFile)
		{
			//获取所有JPG照片
			List<string> images = new List<string>();
			foreach (string file in System.IO.Directory.GetFiles(cameraDir, "*", SearchOption.AllDirectories))
			{
				string extension = Path.GetExtension(file);
				if (extension == ".JPG")
				{
					images.Add(file);
				}
			}
			//升序
			images.Sort();
			//反转
			images.Reverse();

			//读取POS文件
			string[] posLines = File.ReadAllLines(posFile, Encoding.UTF8);
			//反转
			Array.Reverse(posLines);

			//按照片升序输出的POS
			List<string> outPOSs = new List<string>();

			//判断大小，取小值用于遍历
			int count = posLines.Length > images.Count ? images.Count : posLines.Length;

			//依次匹配照片名称和POS
			for (int i = 0; i < count; i++)
			{
				//获取image
				string image = images[i];
				//获取一行POS
				string line = posLines[i];
				//分割
				string[] temp = line.Trim().Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
				//照片名称、X、Y、Z、Omega、Phi、Kappa
				string outLine = Path.GetFileName(image) + '\t' + temp[1] + '\t' + temp[2] + '\t' + temp[3]
					+ '\t' + temp[4] + '\t' + temp[5] + '\t' + temp[6];

				outPOSs.Add(outLine);
			}

			//反转（降序）
			outPOSs.Reverse();

			return outPOSs;
		}

		private void buttonMake_Click(object sender, EventArgs e)
		{
			string cameraDir = textBoxImage.Text;
			string posFile = textBoxPOS.Text;
			string outputPOSFile = textBoxOutPOS.Text;

			if (cameraDir == string.Empty)
			{
				MessageBox.Show("请设置照片路径", "提示");
			}
			else if (posFile == string.Empty)
			{
				MessageBox.Show("请设置原始POS文件路径", "提示");
			}
			else if (posFile == string.Empty)
			{
				MessageBox.Show("请设置POS文件路径", "提示");
			}
			else
			{
				List<string> outPOSs = MakeFeimaPOS(cameraDir, posFile);

				//创建一个输出的POS文件
				FileInfo outputFile = new FileInfo(outputPOSFile);
				StreamWriter sw = outputFile.CreateText();

				//写入POS
				foreach (string pos in outPOSs)
				{
					sw.WriteLine(pos);
				}

				sw.Close();

				MessageBox.Show($"POS文件已保存至{outputPOSFile},请查看是否有误", "提示");
			}
		}

		private void buttonOutPOS_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				Filter = "txt (*.txt)|*.txt",
				RestoreDirectory = true
			};

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				textBoxOutPOS.Text = saveFileDialog.FileName;
			}
		}

		private void buttonPreview_Click(object sender, EventArgs e)
		{
			string cameraDir = textBoxImage.Text;
			string posFile = textBoxPOS.Text;

			if (cameraDir == string.Empty)
			{
				MessageBox.Show("请设置照片路径", "提示");
			}
			else if (posFile == string.Empty)
			{
				MessageBox.Show("请设置原始POS文件路径", "提示");
			}
			else
			{
				List<string> outPOSs = MakeFeimaPOS(cameraDir, posFile);

				DataTable dt = new DataTable();

				dt.Columns.Add("ImageName");
				dt.Columns.Add("X");
				dt.Columns.Add("Y");
				dt.Columns.Add("Z");
				dt.Columns.Add("Omega");
				dt.Columns.Add("Phi");
				dt.Columns.Add("Kappa");

				foreach (string pos in outPOSs)
				{
					string[] temp = pos.Trim().Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);

					dt.Rows.Add(temp);
				}

				dataGridView.DataSource = dt;
			}		
		}
	}
}
