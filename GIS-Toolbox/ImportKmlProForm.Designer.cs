namespace GIS_Toolbox
{
	partial class ImportKmlProForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportKmlProForm));
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxKml = new System.Windows.Forms.TextBox();
			this.buttonAddKml = new System.Windows.Forms.Button();
			this.checkBoxDisplay = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxMarkerStyle = new System.Windows.Forms.ComboBox();
			this.buttonImport = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonClear = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.comboBoxLineColor = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "kml文件：";
			// 
			// textBoxKml
			// 
			this.textBoxKml.Location = new System.Drawing.Point(113, 38);
			this.textBoxKml.Multiline = true;
			this.textBoxKml.Name = "textBoxKml";
			this.textBoxKml.Size = new System.Drawing.Size(624, 145);
			this.textBoxKml.TabIndex = 1;
			// 
			// buttonAddKml
			// 
			this.buttonAddKml.Location = new System.Drawing.Point(779, 41);
			this.buttonAddKml.Name = "buttonAddKml";
			this.buttonAddKml.Size = new System.Drawing.Size(75, 28);
			this.buttonAddKml.TabIndex = 2;
			this.buttonAddKml.Text = "添加";
			this.buttonAddKml.UseVisualStyleBackColor = true;
			this.buttonAddKml.Click += new System.EventHandler(this.buttonAddKml_Click);
			// 
			// checkBoxDisplay
			// 
			this.checkBoxDisplay.AutoSize = true;
			this.checkBoxDisplay.Location = new System.Drawing.Point(22, 58);
			this.checkBoxDisplay.Name = "checkBoxDisplay";
			this.checkBoxDisplay.Size = new System.Drawing.Size(196, 22);
			this.checkBoxDisplay.TabIndex = 3;
			this.checkBoxDisplay.Text = "一直显示marker标注";
			this.checkBoxDisplay.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(240, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "marker样式：";
			// 
			// comboBoxMarkerStyle
			// 
			this.comboBoxMarkerStyle.FormattingEnabled = true;
			this.comboBoxMarkerStyle.Location = new System.Drawing.Point(362, 56);
			this.comboBoxMarkerStyle.Name = "comboBoxMarkerStyle";
			this.comboBoxMarkerStyle.Size = new System.Drawing.Size(121, 26);
			this.comboBoxMarkerStyle.TabIndex = 5;
			// 
			// buttonImport
			// 
			this.buttonImport.Location = new System.Drawing.Point(779, 54);
			this.buttonImport.Name = "buttonImport";
			this.buttonImport.Size = new System.Drawing.Size(75, 28);
			this.buttonImport.TabIndex = 6;
			this.buttonImport.Text = "导入";
			this.buttonImport.UseVisualStyleBackColor = true;
			this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonClear);
			this.groupBox1.Controls.Add(this.textBoxKml);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.buttonAddKml);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(883, 217);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "添加kml文件";
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(779, 94);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(75, 28);
			this.buttonClear.TabIndex = 3;
			this.buttonClear.Text = "清除";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.comboBoxLineColor);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.comboBoxMarkerStyle);
			this.groupBox2.Controls.Add(this.checkBoxDisplay);
			this.groupBox2.Controls.Add(this.buttonImport);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(12, 254);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(883, 128);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "设置";
			// 
			// comboBoxLineColor
			// 
			this.comboBoxLineColor.FormattingEnabled = true;
			this.comboBoxLineColor.Location = new System.Drawing.Point(617, 56);
			this.comboBoxLineColor.Name = "comboBoxLineColor";
			this.comboBoxLineColor.Size = new System.Drawing.Size(121, 26);
			this.comboBoxLineColor.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(513, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 18);
			this.label3.TabIndex = 7;
			this.label3.Text = "线条颜色：";
			// 
			// ImportKmlProForm
			// 
			this.ClientSize = new System.Drawing.Size(907, 394);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(929, 450);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(929, 450);
			this.Name = "ImportKmlProForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "导入kml";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxKml;
		private System.Windows.Forms.Button buttonAddKml;
		private System.Windows.Forms.CheckBox checkBoxDisplay;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxMarkerStyle;
		private System.Windows.Forms.Button buttonImport;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox comboBoxLineColor;
		private System.Windows.Forms.Label label3;
	}
}
