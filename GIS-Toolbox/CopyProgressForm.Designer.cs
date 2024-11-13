namespace GIS_Toolbox
{
	partial class CopyProgressForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyProgressForm));
			this.labelPercentage = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// labelPercentage
			// 
			this.labelPercentage.AutoSize = true;
			this.labelPercentage.Location = new System.Drawing.Point(745, 32);
			this.labelPercentage.Name = "labelPercentage";
			this.labelPercentage.Size = new System.Drawing.Size(44, 18);
			this.labelPercentage.TabIndex = 5;
			this.labelPercentage.Text = "0.0%";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 18);
			this.label1.TabIndex = 4;
			this.label1.Text = "进度：";
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(93, 21);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(637, 29);
			this.progressBar.TabIndex = 3;
			// 
			// CopyProgressForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(831, 76);
			this.Controls.Add(this.labelPercentage);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.progressBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CopyProgressForm";
			this.Text = "导出图片进度";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelPercentage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ProgressBar progressBar;
	}
}