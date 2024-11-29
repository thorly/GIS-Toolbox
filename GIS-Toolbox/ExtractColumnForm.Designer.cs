namespace GIS_Toolbox
{
	partial class ExtractColumnForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtractColumnForm));
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.buttonImportFile = new System.Windows.Forms.Button();
			this.groupBox = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxOther = new System.Windows.Forms.TextBox();
			this.checkBoxOther = new System.Windows.Forms.CheckBox();
			this.checkBoxTab = new System.Windows.Forms.CheckBox();
			this.checkBoxSpace = new System.Windows.Forms.CheckBox();
			this.checkBoxComma = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxColumnNum = new System.Windows.Forms.TextBox();
			this.buttonExport = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxSeparator = new System.Windows.Forms.ComboBox();
			this.checkBoxSkip = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.groupBox.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.GridColor = System.Drawing.SystemColors.Control;
			this.dataGridView.Location = new System.Drawing.Point(12, 12);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 62;
			this.dataGridView.RowTemplate.Height = 30;
			this.dataGridView.Size = new System.Drawing.Size(1519, 603);
			this.dataGridView.TabIndex = 0;
			// 
			// buttonImportFile
			// 
			this.buttonImportFile.Location = new System.Drawing.Point(21, 37);
			this.buttonImportFile.Name = "buttonImportFile";
			this.buttonImportFile.Size = new System.Drawing.Size(137, 29);
			this.buttonImportFile.TabIndex = 1;
			this.buttonImportFile.Text = "导入文本文件";
			this.buttonImportFile.UseVisualStyleBackColor = true;
			this.buttonImportFile.Click += new System.EventHandler(this.buttonImportFile_Click);
			// 
			// groupBox
			// 
			this.groupBox.Controls.Add(this.label2);
			this.groupBox.Controls.Add(this.textBoxOther);
			this.groupBox.Controls.Add(this.checkBoxOther);
			this.groupBox.Controls.Add(this.checkBoxTab);
			this.groupBox.Controls.Add(this.checkBoxSpace);
			this.groupBox.Controls.Add(this.buttonImportFile);
			this.groupBox.Controls.Add(this.checkBoxComma);
			this.groupBox.Location = new System.Drawing.Point(12, 642);
			this.groupBox.Name = "groupBox";
			this.groupBox.Size = new System.Drawing.Size(779, 86);
			this.groupBox.TabIndex = 2;
			this.groupBox.TabStop = false;
			this.groupBox.Text = "导入设置";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(170, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "分隔符：";
			// 
			// textBoxOther
			// 
			this.textBoxOther.Location = new System.Drawing.Point(706, 37);
			this.textBoxOther.MaxLength = 1;
			this.textBoxOther.Name = "textBoxOther";
			this.textBoxOther.Size = new System.Drawing.Size(47, 28);
			this.textBoxOther.TabIndex = 1;
			// 
			// checkBoxOther
			// 
			this.checkBoxOther.AutoSize = true;
			this.checkBoxOther.Location = new System.Drawing.Point(614, 43);
			this.checkBoxOther.Name = "checkBoxOther";
			this.checkBoxOther.Size = new System.Drawing.Size(70, 22);
			this.checkBoxOther.TabIndex = 0;
			this.checkBoxOther.Text = "其他";
			this.checkBoxOther.UseVisualStyleBackColor = true;
			// 
			// checkBoxTab
			// 
			this.checkBoxTab.AutoSize = true;
			this.checkBoxTab.Location = new System.Drawing.Point(494, 42);
			this.checkBoxTab.Name = "checkBoxTab";
			this.checkBoxTab.Size = new System.Drawing.Size(79, 22);
			this.checkBoxTab.TabIndex = 0;
			this.checkBoxTab.Text = "Tab键";
			this.checkBoxTab.UseVisualStyleBackColor = true;
			// 
			// checkBoxSpace
			// 
			this.checkBoxSpace.AutoSize = true;
			this.checkBoxSpace.Location = new System.Drawing.Point(373, 42);
			this.checkBoxSpace.Name = "checkBoxSpace";
			this.checkBoxSpace.Size = new System.Drawing.Size(70, 22);
			this.checkBoxSpace.TabIndex = 0;
			this.checkBoxSpace.Text = "空格";
			this.checkBoxSpace.UseVisualStyleBackColor = true;
			// 
			// checkBoxComma
			// 
			this.checkBoxComma.AutoSize = true;
			this.checkBoxComma.Location = new System.Drawing.Point(252, 42);
			this.checkBoxComma.Name = "checkBoxComma";
			this.checkBoxComma.Size = new System.Drawing.Size(70, 22);
			this.checkBoxComma.TabIndex = 0;
			this.checkBoxComma.Text = "逗号";
			this.checkBoxComma.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "提取列号：";
			// 
			// textBoxColumnNum
			// 
			this.textBoxColumnNum.Location = new System.Drawing.Point(120, 36);
			this.textBoxColumnNum.MaxLength = 100000;
			this.textBoxColumnNum.Name = "textBoxColumnNum";
			this.textBoxColumnNum.Size = new System.Drawing.Size(138, 28);
			this.textBoxColumnNum.TabIndex = 4;
			// 
			// buttonExport
			// 
			this.buttonExport.Location = new System.Drawing.Point(626, 37);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(75, 31);
			this.buttonExport.TabIndex = 5;
			this.buttonExport.Text = "导出";
			this.buttonExport.UseVisualStyleBackColor = true;
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.comboBoxSeparator);
			this.groupBox1.Controls.Add(this.checkBoxSkip);
			this.groupBox1.Controls.Add(this.buttonExport);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBoxColumnNum);
			this.groupBox1.Location = new System.Drawing.Point(811, 642);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(720, 86);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "导出设置";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(386, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "分隔符：";
			// 
			// comboBoxSeparator
			// 
			this.comboBoxSeparator.FormattingEnabled = true;
			this.comboBoxSeparator.Location = new System.Drawing.Point(472, 39);
			this.comboBoxSeparator.Name = "comboBoxSeparator";
			this.comboBoxSeparator.Size = new System.Drawing.Size(121, 26);
			this.comboBoxSeparator.TabIndex = 7;
			// 
			// checkBoxSkip
			// 
			this.checkBoxSkip.AutoSize = true;
			this.checkBoxSkip.Location = new System.Drawing.Point(274, 42);
			this.checkBoxSkip.Name = "checkBoxSkip";
			this.checkBoxSkip.Size = new System.Drawing.Size(106, 22);
			this.checkBoxSkip.TabIndex = 6;
			this.checkBoxSkip.Text = "跳过首行";
			this.checkBoxSkip.UseVisualStyleBackColor = true;
			// 
			// ExtractColumnForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1543, 752);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox);
			this.Controls.Add(this.dataGridView);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ExtractColumnForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "从文件中提取某几列数据";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.groupBox.ResumeLayout(false);
			this.groupBox.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button buttonImportFile;
		private System.Windows.Forms.GroupBox groupBox;
		private System.Windows.Forms.TextBox textBoxOther;
		private System.Windows.Forms.CheckBox checkBoxOther;
		private System.Windows.Forms.CheckBox checkBoxTab;
		private System.Windows.Forms.CheckBox checkBoxSpace;
		private System.Windows.Forms.CheckBox checkBoxComma;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxColumnNum;
		private System.Windows.Forms.Button buttonExport;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBoxSkip;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxSeparator;
	}
}