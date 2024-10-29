namespace GIS_Toolbox
{
	partial class POSForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSForm));
			this.label1 = new System.Windows.Forms.Label();
			this.buttonOpen = new System.Windows.Forms.Button();
			this.textBoxImageDir = new System.Windows.Forms.TextBox();
			this.buttonImport = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxCenterLng = new System.Windows.Forms.ComboBox();
			this.buttonClear = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "图片文件夹路径：";
			// 
			// buttonOpen
			// 
			this.buttonOpen.Location = new System.Drawing.Point(850, 45);
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new System.Drawing.Size(75, 35);
			this.buttonOpen.TabIndex = 1;
			this.buttonOpen.Text = "添加";
			this.buttonOpen.UseVisualStyleBackColor = true;
			this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
			// 
			// textBoxImageDir
			// 
			this.textBoxImageDir.Location = new System.Drawing.Point(164, 42);
			this.textBoxImageDir.Multiline = true;
			this.textBoxImageDir.Name = "textBoxImageDir";
			this.textBoxImageDir.Size = new System.Drawing.Size(650, 153);
			this.textBoxImageDir.TabIndex = 2;
			// 
			// buttonImport
			// 
			this.buttonImport.Location = new System.Drawing.Point(849, 28);
			this.buttonImport.Name = "buttonImport";
			this.buttonImport.Size = new System.Drawing.Size(75, 50);
			this.buttonImport.TabIndex = 1;
			this.buttonImport.Text = "导入";
			this.buttonImport.UseVisualStyleBackColor = true;
			this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "中央子午线：";
			// 
			// comboBoxCenterLng
			// 
			this.comboBoxCenterLng.FormattingEnabled = true;
			this.comboBoxCenterLng.Location = new System.Drawing.Point(163, 44);
			this.comboBoxCenterLng.Name = "comboBoxCenterLng";
			this.comboBoxCenterLng.Size = new System.Drawing.Size(121, 26);
			this.comboBoxCenterLng.TabIndex = 3;
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(850, 93);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(75, 35);
			this.buttonClear.TabIndex = 4;
			this.buttonClear.Text = "清除";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxImageDir);
			this.groupBox1.Controls.Add(this.buttonClear);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.buttonOpen);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(959, 244);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "选择文件夹";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.comboBoxCenterLng);
			this.groupBox2.Controls.Add(this.buttonImport);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(13, 284);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(958, 100);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "设置";
			// 
			// POSForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 400);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "POSForm";
			this.Text = "导入华测设备图片";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonOpen;
		private System.Windows.Forms.TextBox textBoxImageDir;
		private System.Windows.Forms.Button buttonImport;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxCenterLng;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}