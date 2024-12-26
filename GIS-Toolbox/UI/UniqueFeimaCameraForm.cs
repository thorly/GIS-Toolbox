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

namespace GIS_Toolbox.UI
{
	public partial class UniqueFeimaCameraForm : Form
	{
		public UniqueFeimaCameraForm()
		{
			InitializeComponent();
			this.textBoxStartNum.Text = "1";
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			FolderSelectDialogMulti.FolderSelectDialogMulti dialog = new FolderSelectDialogMulti.FolderSelectDialogMulti();
			dialog.Title = "选择文件夹（支持多选）";

			if (dialog.ShowDialog(this.Handle))
			{
				int length1 = this.textBoxImageDir.Lines.Length;

				if (length1 != 0)
				{
					int length2 = dialog.FileNames.Length;

					string[] tempArray = new string[length1 + length2];

					Array.Copy(this.textBoxImageDir.Lines, tempArray, length1);
					Array.Copy(dialog.FileNames, 0, tempArray, length1, length2);

					this.textBoxImageDir.Lines = tempArray;
				}
				else
				{
					this.textBoxImageDir.Lines = dialog.FileNames;
				}
			}
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			this.textBoxImageDir.Clear();
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			int count = this.textBoxImageDir.Lines.Length;

			//前缀起始数字
			int startNum = Convert.ToInt16(this.textBoxStartNum.Text);


			//遍历更名
			for (int i = 0; i < count; i ++)
			{
				string imageDir = this.textBoxImageDir.Lines[i];

				//获取所有JPG照片
				List<string> images = new List<string>();
				foreach (string file in System.IO.Directory.GetFiles(imageDir, "*", SearchOption.AllDirectories))
				{
					string extension = Path.GetExtension(file);
					if (extension == ".JPG")
					{
						images.Add(file);
					}
				}

				foreach(string image in images)
				{
					string name = Path.GetFileName(image);

					string newName = $"{startNum + i}-{name}";
					string newImage = Path.Combine(imageDir, newName);

					//重命名
					if (File.Exists(image))
					{
						File.Move(image, newImage);
					}
				}

				string posFile = Path.Combine(imageDir, "MetaShape.txt");

				if (File.Exists (posFile))
				{
					//读取POS文件
					string[] posLines = File.ReadAllLines(posFile, Encoding.UTF8);

					//创建一个输出的POS文件
					FileInfo outputFile = new FileInfo(posFile);
					StreamWriter sw = outputFile.CreateText();

					//写入POS
					foreach (string pos in posLines)
					{
						sw.WriteLine($"{startNum + i}-{pos}");
					}

					sw.Close();
				}
			}

			MessageBox.Show("完成", "提示");
		}

		private void textBoxStartNum_KeyPress(object sender, KeyPressEventArgs e)
		{
			//允许输入数字和退格键
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}
	}
}
