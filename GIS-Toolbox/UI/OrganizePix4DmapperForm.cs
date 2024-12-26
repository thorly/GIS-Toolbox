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
	public partial class OrganizePix4DmapperForm : Form
	{
		public OrganizePix4DmapperForm()
		{
			InitializeComponent();
			this.checkBoxDelete.Checked = true;
		}

		private void buttonAddDirectory_Click(object sender, EventArgs e)
		{
			FolderSelectDialogMulti.FolderSelectDialogMulti dialog = new FolderSelectDialogMulti.FolderSelectDialogMulti();
			dialog.Title = "选择Pix4Dmapper工程文件夹（支持多选）";

			if (dialog.ShowDialog(this.Handle))
			{
				int length1 = this.textBoxDirectory.Lines.Length;

				if (length1 != 0)
				{
					int length2 = dialog.FileNames.Length;

					string[] tempArray = new string[length1 + length2];

					Array.Copy(this.textBoxDirectory.Lines, tempArray, length1);
					Array.Copy(dialog.FileNames, 0, tempArray, length1, length2);

					this.textBoxDirectory.Lines = tempArray;
				}
				else
				{
					this.textBoxDirectory.Lines = dialog.FileNames;
				}
			}
		}

		private void buttonClearDirectory_Click(object sender, EventArgs e)
		{
			this.textBoxDirectory.Clear();
		}

		private void buttonOrganize_Click(object sender, EventArgs e)
		{
			foreach(string directory in this.textBoxDirectory.Lines)
			{
				//工程文件名称
				string directoryName = Path.GetFileName(directory);
				//.p4d文件
				string p4dFile = Path.Combine(Path.GetDirectoryName(directory), directoryName + ".p4d");
				//1_initial文件夹
				string initialDirectory = Path.Combine(directory, "1_initial");
				//2_densification文件夹
				string densificationDirectory = Path.Combine(directory, "2_densification");
				//3_dsm_ortho文件夹
				string dsmOrthoDirectory = Path.Combine(directory, "3_dsm_ortho");
				//dsm文件夹
				string dsmDirectory = Path.Combine(dsmOrthoDirectory, "1_dsm");

				string dsmPrjFile = Path.Combine(dsmDirectory, directoryName + "_dsm.prj");
				string dsmTfwFile = Path.Combine(dsmDirectory, directoryName + "_dsm.tfw");
				string dsmTifFile = Path.Combine(dsmDirectory, directoryName + "_dsm.tif");
				//dom文件夹
				string domDirectory = Path.Combine(dsmOrthoDirectory, "2_mosaic");

				string domPrjFile = Path.Combine(domDirectory, directoryName + "_transparent_mosaic_group1.prj");
				string domTfwFile = Path.Combine(domDirectory, directoryName + "_transparent_mosaic_group1.tfw");
				string domTifFile = Path.Combine(domDirectory, directoryName + "_transparent_mosaic_group1.tif");
				//temp文件夹
				string tempDirectory = Path.Combine(directory, "temp");
				//.log文件
				string logFile = Path.Combine(directory, directoryName + ".log");

				//移动文件（prj、tfw、tif）
				Tools.MoveFile(dsmPrjFile, directory);
				Tools.MoveFile(dsmTfwFile, directory);
				Tools.MoveFile(dsmTifFile, directory);

				Tools.MoveFile(domPrjFile, directory);
				Tools.MoveFile(domTfwFile, directory);
				Tools.MoveFile(domTifFile, directory);

				//删除文件夹和文件
				if (this.checkBoxDelete.Checked)
				{
					Tools.DeleteDirectory(initialDirectory);
					Tools.DeleteDirectory(densificationDirectory);
					Tools.DeleteDirectory(tempDirectory);
					Tools.DeleteDirectory(dsmOrthoDirectory);

					Tools.DeleteFile(p4dFile);
					Tools.DeleteFile(logFile);
				}
			}
			MessageBox.Show("完成", "提示");
		}
	}
}
