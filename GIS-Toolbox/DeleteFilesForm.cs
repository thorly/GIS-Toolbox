using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GIS_Toolbox
{
	public partial class DeleteFilesForm : Form
	{
		public DeleteFilesForm()
		{
			InitializeComponent();
			this.textBoxDirectory.Enabled = false;
			
			this.comboBoxFileExtension.Items.AddRange(new string[] { ".codata", ".las", ".txt"});
			this.comboBoxFileExtension.SelectedIndex = 0;
		}

		private void buttonDeleteAll_Click(object sender, EventArgs e)
		{
			List<string> files = new List<string>();

			string directory = textBoxDirectory.Text;
			string fileExtension = comboBoxFileExtension.Text;

			if(directory == "")
			{
				MessageBox.Show("请设置文件夹路径", "提示");
				return;
			}

			if (fileExtension == "")
			{
				MessageBox.Show("请设置文件扩展名", "提示");
				return;
			}

			//获取指定扩展名文件
			foreach(string file in System.IO.Directory.GetFiles(directory, "*", SearchOption.AllDirectories))
			{
                string extension = Path.GetExtension(file);
				if (extension == fileExtension)
				{
					files.Add(file);
				}
			}

            if (files.Count() != 0)
			{
				foreach(string file in files)
				{
                    File.Delete(file);
				}
				MessageBox.Show($"删除成功，总共删除{files.Count()}个文件", "提示");
			}
			else
			{
				MessageBox.Show($"没有找到扩展名为{fileExtension}的文件", "提示");
			}
		}

		private void buttonOpenDir_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			dialog.Description = "请选择文件夹";
			dialog.RootFolder = Environment.SpecialFolder.MyComputer;
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				textBoxDirectory.Text = dialog.SelectedPath;
			}
		}
	}
}
