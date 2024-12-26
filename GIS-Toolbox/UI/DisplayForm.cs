using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIS_Toolbox
{
	public partial class DisplayForm : Form
	{
		public DisplayForm(string imagePath)
		{
			InitializeComponent();
			this.Text = imagePath;
			Image image = Image.FromFile(imagePath);
			pictureBox.Image = image;

			pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

		}
	}
}
