using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GIS_Toolbox
{
	public partial class OrganizeForm : Form
	{
		public OrganizeForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 通过名称获取文件夹路径
		/// </summary>
		/// <param name="path"></param>
		/// <param name="name"></param>
		/// <returns></returns>
		private static List<string> GetDirectoryByName(string path, string name)
		{
			List<string> directorys = new List<string>();

			foreach (string directory in Directory.GetDirectories(path, "*", SearchOption.AllDirectories))
			{
				if (Path.GetFileName(directory) == name)
				{
					directorys.Add(directory);
				}
			}

			return directorys;
		}

		private void buttonInput_Click(object sender, EventArgs e)
		{
			FolderSelectDialogSingle.FolderSelectDialogSingle dialog = new FolderSelectDialogSingle.FolderSelectDialogSingle
			{
				Title = "选择文件夹"
			};

			if (dialog.ShowDialog(this.Handle))
			{
				textBoxInput.Text = dialog.FileName;
			}
		}

		private void buttonOutput_Click(object sender, EventArgs e)
		{
			FolderSelectDialogSingle.FolderSelectDialogSingle dialog = new FolderSelectDialogSingle.FolderSelectDialogSingle
			{
				Title = "选择文件夹"
			};

			if (dialog.ShowDialog(this.Handle))
			{
				textBoxOutput.Text = dialog.FileName;
			}
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{

			if (textBoxInput.Text == "" || textBoxOutput.Text == "")
			{
				MessageBox.Show("请设置文件夹路径", "警告");
			}
			else
			{
				//移动激光数据
				List<string> scanners = GetDirectoryByName(textBoxInput.Text, "Scanner1");

				string outputScanner = textBoxOutput.Text + $"\\Scanner";
				if (!Directory.Exists(outputScanner))
				{
					Directory.CreateDirectory(outputScanner);
				}

				foreach (string scanner in scanners)
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(scanner);
					int index = scanners.IndexOf(scanner);
					directoryInfo.MoveTo(outputScanner + $"\\Scanner-{index + 1}");
				}

				// 移动照片数据
				List<string> cameras = GetDirectoryByName(textBoxInput.Text, "Camera1");
				List<string> posFiles = new List<string>();

				string outputCamera = textBoxOutput.Text + $"\\Camera";
				if (!Directory.Exists(outputCamera))
				{
					Directory.CreateDirectory(outputCamera);
				}

				foreach (string camera in cameras)
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(camera);
					int index = cameras.IndexOf(camera);
					directoryInfo.MoveTo(outputCamera + $"\\Camera-{index + 1}");

					posFiles.Add(outputCamera + $"\\Camera-{index + 1}\\Metashape.txt");
				}

				// 合并POS文件
				string mergedPOS = outputCamera + "\\Metashape-merged.txt";
				Tools.MergePOS(posFiles, mergedPOS, true);

				MessageBox.Show("完成", "提示");
			}
		}
	}
}
