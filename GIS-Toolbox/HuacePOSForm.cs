using System;
using System.Windows.Forms;

namespace GIS_Toolbox
{
	public partial class HuacePOSForm : Form
	{
		public HuacePOSForm()
		{
			InitializeComponent();

			for (int i = 75; i <= 135; )
			{
				comboBoxCenterLng.Items.Add(i);
				i = i + 3;
			}
			
			comboBoxCenterLng.SelectedIndex = 13;
		}

		private void buttonOpen_Click(object sender, EventArgs e)
		{
			FolderSelectDialogMulti.FolderSelectDialogMulti dialog = new FolderSelectDialogMulti.FolderSelectDialogMulti();
			dialog.Title = "选择文件夹（支持多选）"; 

			if (dialog.ShowDialog(this.Handle))
			{
				int length1 = textBoxImageDir.Lines.Length;

				if (length1 != 0)
				{
					int length2 = dialog.FileNames.Length;

					string[] tempArray = new string[length1 + length2];

					Array.Copy(textBoxImageDir.Lines, tempArray, length1);
					Array.Copy(dialog.FileNames, 0, tempArray, length1, length2);

					textBoxImageDir.Lines = tempArray;
				}
				else
				{
					textBoxImageDir.Lines = dialog.FileNames;
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
			return textBoxImageDir.Lines;
		}
		
		public string getCenterLng()
		{
			return comboBoxCenterLng.Text;
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			this.textBoxImageDir.Clear();
		}
	}
}
