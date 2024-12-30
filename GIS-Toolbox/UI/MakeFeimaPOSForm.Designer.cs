namespace GIS_Toolbox
{
	partial class MakeFeimaPOSForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeFeimaPOSForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxImage = new System.Windows.Forms.TextBox();
			this.textBoxPOS = new System.Windows.Forms.TextBox();
			this.buttonImage = new System.Windows.Forms.Button();
			this.buttonPOS = new System.Windows.Forms.Button();
			this.buttonMake = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonPreview = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.buttonOutPOS = new System.Windows.Forms.Button();
			this.textBoxOutPOS = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(82, 589);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "照片路径：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 641);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(161, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "原始POS文件路径：";
			// 
			// textBoxImage
			// 
			this.textBoxImage.Location = new System.Drawing.Point(187, 578);
			this.textBoxImage.Name = "textBoxImage";
			this.textBoxImage.Size = new System.Drawing.Size(734, 28);
			this.textBoxImage.TabIndex = 2;
			// 
			// textBoxPOS
			// 
			this.textBoxPOS.Location = new System.Drawing.Point(187, 631);
			this.textBoxPOS.Name = "textBoxPOS";
			this.textBoxPOS.Size = new System.Drawing.Size(734, 28);
			this.textBoxPOS.TabIndex = 2;
			// 
			// buttonImage
			// 
			this.buttonImage.Location = new System.Drawing.Point(947, 576);
			this.buttonImage.Name = "buttonImage";
			this.buttonImage.Size = new System.Drawing.Size(61, 33);
			this.buttonImage.TabIndex = 1;
			this.buttonImage.Text = "...";
			this.buttonImage.UseVisualStyleBackColor = true;
			this.buttonImage.Click += new System.EventHandler(this.buttonImage_Click);
			// 
			// buttonPOS
			// 
			this.buttonPOS.Location = new System.Drawing.Point(947, 629);
			this.buttonPOS.Name = "buttonPOS";
			this.buttonPOS.Size = new System.Drawing.Size(61, 33);
			this.buttonPOS.TabIndex = 2;
			this.buttonPOS.Text = "...";
			this.buttonPOS.UseVisualStyleBackColor = true;
			this.buttonPOS.Click += new System.EventHandler(this.buttonPOS_Click);
			// 
			// buttonMake
			// 
			this.buttonMake.Location = new System.Drawing.Point(1062, 57);
			this.buttonMake.Name = "buttonMake";
			this.buttonMake.Size = new System.Drawing.Size(92, 34);
			this.buttonMake.TabIndex = 3;
			this.buttonMake.Text = "导出POS";
			this.buttonMake.UseVisualStyleBackColor = true;
			this.buttonMake.Click += new System.EventHandler(this.buttonMake_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(6, 27);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 62;
			this.dataGridView.RowTemplate.Height = 30;
			this.dataGridView.Size = new System.Drawing.Size(1188, 528);
			this.dataGridView.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonPreview);
			this.groupBox1.Controls.Add(this.dataGridView);
			this.groupBox1.Controls.Add(this.textBoxImage);
			this.groupBox1.Controls.Add(this.buttonPOS);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.buttonImage);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBoxPOS);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1200, 699);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "导入";
			// 
			// buttonPreview
			// 
			this.buttonPreview.Location = new System.Drawing.Point(1072, 606);
			this.buttonPreview.Name = "buttonPreview";
			this.buttonPreview.Size = new System.Drawing.Size(75, 34);
			this.buttonPreview.TabIndex = 4;
			this.buttonPreview.Text = "预览";
			this.buttonPreview.UseVisualStyleBackColor = true;
			this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.buttonOutPOS);
			this.groupBox2.Controls.Add(this.buttonMake);
			this.groupBox2.Controls.Add(this.textBoxOutPOS);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(12, 735);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1200, 138);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "导出";
			// 
			// buttonOutPOS
			// 
			this.buttonOutPOS.Location = new System.Drawing.Point(947, 58);
			this.buttonOutPOS.Name = "buttonOutPOS";
			this.buttonOutPOS.Size = new System.Drawing.Size(61, 33);
			this.buttonOutPOS.TabIndex = 4;
			this.buttonOutPOS.Text = "...";
			this.buttonOutPOS.UseVisualStyleBackColor = true;
			this.buttonOutPOS.Click += new System.EventHandler(this.buttonOutPOS_Click);
			// 
			// textBoxOutPOS
			// 
			this.textBoxOutPOS.Location = new System.Drawing.Point(152, 59);
			this.textBoxOutPOS.Name = "textBoxOutPOS";
			this.textBoxOutPOS.Size = new System.Drawing.Size(769, 28);
			this.textBoxOutPOS.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 18);
			this.label3.TabIndex = 1;
			this.label3.Text = "POS文件路径：";
			// 
			// MakeFeimaPOSForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1224, 885);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MakeFeimaPOSForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "制作飞马无人机POS文件";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxImage;
		private System.Windows.Forms.TextBox textBoxPOS;
		private System.Windows.Forms.Button buttonImage;
		private System.Windows.Forms.Button buttonPOS;
		private System.Windows.Forms.Button buttonMake;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBoxOutPOS;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonPreview;
		private System.Windows.Forms.Button buttonOutPOS;
	}
}