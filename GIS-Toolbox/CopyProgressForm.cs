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
	public partial class CopyProgressForm : Form
	{
		public CopyProgressForm()
		{
			InitializeComponent();
		}
		public void SetProgressBarMax(int max)
		{
			this.progressBar.Maximum = max;
		}

		public void SetProgressBarValue(int value)
		{
			this.progressBar.Value = value;
		}

		public void SetPercentage(double percentage)
		{

			this.labelPercentage.Text = percentage + "%";
		}
	}
}
