using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GIS_Toolbox.UI
{
	public partial class SplitFeimaCameraForm : Form
	{
		public SplitFeimaCameraForm()
		{
			InitializeComponent();
		}

		private void buttonSplit_Click(object sender, EventArgs e)
		{
			string imageDir = textBoxImageDir.Text;

			//获取所有JPG照片
			List<string> images = new List<string>();
			foreach (string file in Directory.GetFiles(imageDir))
			{
				string extension = Path.GetExtension(file);
				if (extension == ".JPG")
				{
					images.Add(file);
				}
			}

			//升序
			images.Sort();

			//计算所有照片的平均大小
			long totalSize = images.Sum(file => new FileInfo(file).Length);
			long averageSize = totalSize / images.Count;

			//获取试拍照片
			List<string> smallImages = new List<string>();

			foreach(string image in images)
			{
				FileInfo fileInfo = new FileInfo(image);
				//小于平均值的0.7
				if (fileInfo.Length < averageSize * 0.7)
				{
                    smallImages.Add(image);
				}
			}

			//分组结果
			List<List<string>> groups = new List<List<string>>();
			List<string> currentGroup = new List<string>();

			//分组
			foreach(string image in images)
			{
				if (smallImages.Contains(image))
				{
					if (currentGroup.Count > 0)
					{
						groups.Add(new List<string>(currentGroup));
						currentGroup.Clear();
					}
				}
				else
				{
					currentGroup.Add(image);
				}
			}

			if (currentGroup.Count > 0)
			{
				groups.Add(currentGroup);
			}

			//建立文件夹，移入对应照片
			for (int i = 0; i < groups.Count; i++)
			{
                Console.WriteLine($"Group {i + 1} : {string.Join(",", groups[i])}");

				string groupDir = Path.Combine(imageDir, $"Camera{i + 1}");

				if (!Directory.Exists(groupDir))
				{
					Directory.CreateDirectory(groupDir);
				}

				foreach(string image in groups[i])
				{
					Tools.MoveFile(image, groupDir);
				}
			}

			//删除试拍照片
			if(checkBoxDelete.Checked)
			{
				foreach(string image in smallImages)
				{
					if (File.Exists(image))
					{
						File.Delete(image);
					}
				}
			}

			MessageBox.Show("完成", "提示");
		}

		private void buttonOpen_Click(object sender, EventArgs e)
		{
			FolderSelectDialogSingle.FolderSelectDialogSingle dialog = new FolderSelectDialogSingle.FolderSelectDialogSingle
			{
				Title = "选择文件夹"
			};

			if (dialog.ShowDialog(this.Handle))
			{
				textBoxImageDir.Text = dialog.FileName;
			}
		}
	}
}
