using System;
using System.Windows.Forms;

namespace GIS_Toolbox
{
	public partial class HuacePOSForm : Form
	{
		public HuacePOSForm()
		{
			InitializeComponent();

			//添加3度带中央子午线
			for (int i = 75; i <= 135; )
			{
				this.comboBoxCenterLng.Items.Add(i);
				i = i + 3;
			}

			//默认选择114
			this.comboBoxCenterLng.SelectedIndex = 13;
		}

		private void buttonOpen_Click(object sender, EventArgs e)
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

		private void buttonImport_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		public string[] getImageDir()
		{
			return this.textBoxImageDir.Lines;
		}
		
		public string getCenterLng()
		{
			return this.comboBoxCenterLng.Text;
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			this.textBoxImageDir.Clear();
		}
	}
}
