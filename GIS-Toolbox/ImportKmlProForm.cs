using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GIS_Toolbox
{
	public partial class ImportKmlProForm : Form
	{
		public static readonly Dictionary<int, GMarkerGoogleType> MarkerTypeDict = new Dictionary<int, GMarkerGoogleType>()
		{
			{0, GMarkerGoogleType.blue_small },
			{1, GMarkerGoogleType.blue_pushpin },
			{2, GMarkerGoogleType.blue_dot },
			{3, GMarkerGoogleType.red_small },
			{4, GMarkerGoogleType.red_pushpin },
			{5, GMarkerGoogleType.red_dot },
			{6, GMarkerGoogleType.orange_small },
			{7, GMarkerGoogleType.orange_dot },
		};

		public static readonly Dictionary<int, Color> LineColorDict = new Dictionary<int, Color>()
		{
			{0, Color.Red },
			{1, Color.Blue },
			{2, Color.White },
			{3, Color.Green },
			{4, Color.Orange }
		};

		public ImportKmlProForm()
		{
			InitializeComponent();

			this.checkBoxDisplay.Checked = true;
			this.textBoxKml.Enabled = false;
			
			//marker样式
			this.comboBoxMarkerStyle.Items.Add("blue_small");
			this.comboBoxMarkerStyle.Items.Add("blue_pushpin");
			this.comboBoxMarkerStyle.Items.Add("blue_dot");
			this.comboBoxMarkerStyle.Items.Add("red_small");
			this.comboBoxMarkerStyle.Items.Add("red_pushpin");
			this.comboBoxMarkerStyle.Items.Add("red_dot");
			this.comboBoxMarkerStyle.Items.Add("orange_small");
			this.comboBoxMarkerStyle.Items.Add("orange_dot");

			this.comboBoxMarkerStyle.SelectedIndex = 0;

			//线条颜色
			this.comboBoxLineColor.Items.Add("red");
			this.comboBoxLineColor.Items.Add("blue");
			this.comboBoxLineColor.Items.Add("white");
			this.comboBoxLineColor.Items.Add("green");
			this.comboBoxLineColor.Items.Add("orange");

			this.comboBoxLineColor.SelectedIndex = 0;
		}

		private void buttonImport_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void buttonAddKml_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog
			{
				CheckPathExists = true,
				CheckFileExists = false,
				AddExtension = true,
				ValidateNames = true,
				Title = "选择KML文件（支持多选）",
				FilterIndex = 1,
				RestoreDirectory = true,
				Filter = "KML文件 (*.kml)|*.kml|所有文件 (*.*)|*.*",
				Multiselect = true
			};

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				int length1 = textBoxKml.Lines.Length;

				if (length1 != 0)
				{
					int length2 = dialog.FileNames.Length;

					string[] tempArray = new string[length1 + length2];

					Array.Copy(textBoxKml.Lines, tempArray, length1);
					Array.Copy(dialog.FileNames, 0, tempArray, length1, length2);

					textBoxKml.Lines = tempArray;
				}
				else
				{
					textBoxKml.Lines = dialog.FileNames;
				}
			}
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			textBoxKml.Clear();
		}

		public string[] GetKmlFiles()
		{
			return textBoxKml.Lines;
		}

		public GMarkerGoogleType GetMarkerType()
		{
			return MarkerTypeDict[comboBoxMarkerStyle.SelectedIndex];
		}

		public Color GetLineColor()
		{
			return LineColorDict[comboBoxLineColor.SelectedIndex];
		}

		public bool GetShowToolTip()
		{
			return checkBoxDisplay.Checked;
		}
	}
}
