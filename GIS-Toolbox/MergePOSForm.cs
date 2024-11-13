using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GIS_Toolbox
{
	public partial class MergePOSForm : Form
	{
		public MergePOSForm()
		{
			InitializeComponent();

			this.checkBoxFirstLine.Checked = true;
			this.textBoxInputFiles.Enabled = false;
			this.textBoxOutputFile.Enabled = false;

			this.buttonAddFile.TabIndex = 0;
			this.buttonSetOutput.TabIndex = 1;
			this.buttonMerge.TabIndex = 2;
		}

		private void buttonAddFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.RestoreDirectory = true;
			ofd.Multiselect = true;
			ofd.Filter = "txt (*.txt)|*.txt";

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				int length1 = textBoxInputFiles.Lines.Length;

				if (length1 != 0)
				{
					int length2 = ofd.FileNames.Length;

					string[] tempArray = new string[length1 + length2];

					Array.Copy(textBoxInputFiles.Lines, tempArray, length1);
					Array.Copy(ofd.FileNames, 0, tempArray, length1, length2);

					textBoxInputFiles.Lines = tempArray;
				}
				else
				{
					textBoxInputFiles.Lines = ofd.FileNames;
				}
				
			}
		}

		private void buttonSetOutput_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "txt (*.txt)|*.txt|All files (*.*)|*.*";
			saveFileDialog.RestoreDirectory = true;

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				textBoxOutputFile.Text = saveFileDialog.FileName;
			}
		}

		private void buttonMerge_Click(object sender, EventArgs e)
		{
			if (textBoxInputFiles.Lines.Length == 0)
			{
				MessageBox.Show("请添加需要合并的POS文件", "提示");
				return;
			}

			if (textBoxOutputFile.Text == "")
			{
				MessageBox.Show("请设置合并后的POS文件路径", "提示");
			}

			List<string> posFiles = textBoxInputFiles.Lines.ToList();
			OrganizeForm.MergePOS(posFiles, textBoxOutputFile.Text, checkBoxFirstLine.Checked);

			MessageBox.Show("合并成功！", "提示");
		}

		private void buttonDeleteAll_Click(object sender, EventArgs e)
		{
			textBoxInputFiles.Clear();
		}
	}
}
