using System;
using System.Windows.Forms;

namespace GIS_Toolbox
{
	public partial class POSForm : Form
	{
		public POSForm()
		{
			InitializeComponent();

			comboBoxCenterLng.Items.Add("111");
			comboBoxCenterLng.Items.Add("114");
			comboBoxCenterLng.Items.Add("117");
			comboBoxCenterLng.Items.Add("120");
			
			comboBoxCenterLng.SelectedIndex = 1;
		}

		private void buttonOpen_Click(object sender, EventArgs e)
		{
			FolderSelectDialog dialog = new FolderSelectDialog();
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
