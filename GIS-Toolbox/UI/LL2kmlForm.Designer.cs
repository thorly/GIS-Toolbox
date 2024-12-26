namespace GIS_Toolbox
{
	partial class LL2kmlForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LL2kmlForm));
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.buttonImportFile = new System.Windows.Forms.Button();
			this.groupBoxSeparator = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxOther = new System.Windows.Forms.TextBox();
			this.radioButtonOther = new System.Windows.Forms.RadioButton();
			this.radioButtonTab = new System.Windows.Forms.RadioButton();
			this.radioButtonSemicolon = new System.Windows.Forms.RadioButton();
			this.radioButtonSpace = new System.Windows.Forms.RadioButton();
			this.radioButtonComma = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonExportKml = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBoxSkipFirstLine = new System.Windows.Forms.CheckBox();
			this.comboBoxLat = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxName = new System.Windows.Forms.ComboBox();
			this.comboBoxLng = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.groupBoxSeparator.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(12, 12);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 62;
			this.dataGridView.RowTemplate.Height = 30;
			this.dataGridView.Size = new System.Drawing.Size(859, 646);
			this.dataGridView.TabIndex = 0;
			// 
			// buttonImportFile
			// 
			this.buttonImportFile.Location = new System.Drawing.Point(28, 33);
			this.buttonImportFile.Name = "buttonImportFile";
			this.buttonImportFile.Size = new System.Drawing.Size(141, 34);
			this.buttonImportFile.TabIndex = 1;
			this.buttonImportFile.Text = "导入文本文件";
			this.buttonImportFile.UseVisualStyleBackColor = true;
			this.buttonImportFile.Click += new System.EventHandler(this.buttonImportFile_Click);
			// 
			// groupBoxSeparator
			// 
			this.groupBoxSeparator.Controls.Add(this.label4);
			this.groupBoxSeparator.Controls.Add(this.textBoxOther);
			this.groupBoxSeparator.Controls.Add(this.radioButtonOther);
			this.groupBoxSeparator.Controls.Add(this.radioButtonTab);
			this.groupBoxSeparator.Controls.Add(this.radioButtonSemicolon);
			this.groupBoxSeparator.Controls.Add(this.buttonImportFile);
			this.groupBoxSeparator.Controls.Add(this.radioButtonSpace);
			this.groupBoxSeparator.Controls.Add(this.radioButtonComma);
			this.groupBoxSeparator.Location = new System.Drawing.Point(12, 675);
			this.groupBoxSeparator.Name = "groupBoxSeparator";
			this.groupBoxSeparator.Size = new System.Drawing.Size(859, 87);
			this.groupBoxSeparator.TabIndex = 2;
			this.groupBoxSeparator.TabStop = false;
			this.groupBoxSeparator.Text = "导入设置";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(192, 43);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 18);
			this.label4.TabIndex = 4;
			this.label4.Text = "分隔符：";
			// 
			// textBoxOther
			// 
			this.textBoxOther.Location = new System.Drawing.Point(728, 37);
			this.textBoxOther.MaxLength = 1;
			this.textBoxOther.Name = "textBoxOther";
			this.textBoxOther.Size = new System.Drawing.Size(100, 28);
			this.textBoxOther.TabIndex = 3;
			// 
			// radioButtonOther
			// 
			this.radioButtonOther.AutoSize = true;
			this.radioButtonOther.Location = new System.Drawing.Point(644, 41);
			this.radioButtonOther.Name = "radioButtonOther";
			this.radioButtonOther.Size = new System.Drawing.Size(69, 22);
			this.radioButtonOther.TabIndex = 2;
			this.radioButtonOther.TabStop = true;
			this.radioButtonOther.Text = "其他";
			this.radioButtonOther.UseVisualStyleBackColor = true;
			// 
			// radioButtonTab
			// 
			this.radioButtonTab.AutoSize = true;
			this.radioButtonTab.Location = new System.Drawing.Point(540, 41);
			this.radioButtonTab.Name = "radioButtonTab";
			this.radioButtonTab.Size = new System.Drawing.Size(78, 22);
			this.radioButtonTab.TabIndex = 1;
			this.radioButtonTab.TabStop = true;
			this.radioButtonTab.Text = "Tab键";
			this.radioButtonTab.UseVisualStyleBackColor = true;
			// 
			// radioButtonSemicolon
			// 
			this.radioButtonSemicolon.AutoSize = true;
			this.radioButtonSemicolon.Location = new System.Drawing.Point(451, 41);
			this.radioButtonSemicolon.Name = "radioButtonSemicolon";
			this.radioButtonSemicolon.Size = new System.Drawing.Size(69, 22);
			this.radioButtonSemicolon.TabIndex = 0;
			this.radioButtonSemicolon.TabStop = true;
			this.radioButtonSemicolon.Text = "分号";
			this.radioButtonSemicolon.UseVisualStyleBackColor = true;
			// 
			// radioButtonSpace
			// 
			this.radioButtonSpace.AutoSize = true;
			this.radioButtonSpace.Location = new System.Drawing.Point(366, 41);
			this.radioButtonSpace.Name = "radioButtonSpace";
			this.radioButtonSpace.Size = new System.Drawing.Size(69, 22);
			this.radioButtonSpace.TabIndex = 0;
			this.radioButtonSpace.TabStop = true;
			this.radioButtonSpace.Text = "空格";
			this.radioButtonSpace.UseVisualStyleBackColor = true;
			// 
			// radioButtonComma
			// 
			this.radioButtonComma.AutoSize = true;
			this.radioButtonComma.Location = new System.Drawing.Point(278, 41);
			this.radioButtonComma.Name = "radioButtonComma";
			this.radioButtonComma.Size = new System.Drawing.Size(69, 22);
			this.radioButtonComma.TabIndex = 0;
			this.radioButtonComma.TabStop = true;
			this.radioButtonComma.Text = "逗号";
			this.radioButtonComma.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonExportKml);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.checkBoxSkipFirstLine);
			this.groupBox1.Controls.Add(this.comboBoxLat);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.comboBoxName);
			this.groupBox1.Controls.Add(this.comboBoxLng);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 780);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(859, 87);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "导出设置";
			// 
			// buttonExportKml
			// 
			this.buttonExportKml.Location = new System.Drawing.Point(687, 33);
			this.buttonExportKml.Name = "buttonExportKml";
			this.buttonExportKml.Size = new System.Drawing.Size(141, 34);
			this.buttonExportKml.TabIndex = 4;
			this.buttonExportKml.Text = "导出kml文件";
			this.buttonExportKml.UseVisualStyleBackColor = true;
			this.buttonExportKml.Click += new System.EventHandler(this.buttonExportKml_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 18);
			this.label3.TabIndex = 5;
			this.label3.Text = "名称：";
			// 
			// checkBoxSkipFirstLine
			// 
			this.checkBoxSkipFirstLine.AutoSize = true;
			this.checkBoxSkipFirstLine.Location = new System.Drawing.Point(498, 42);
			this.checkBoxSkipFirstLine.Name = "checkBoxSkipFirstLine";
			this.checkBoxSkipFirstLine.Size = new System.Drawing.Size(106, 22);
			this.checkBoxSkipFirstLine.TabIndex = 4;
			this.checkBoxSkipFirstLine.Text = "跳过首行";
			this.checkBoxSkipFirstLine.UseVisualStyleBackColor = true;
			// 
			// comboBoxLat
			// 
			this.comboBoxLat.FormattingEnabled = true;
			this.comboBoxLat.Location = new System.Drawing.Point(392, 38);
			this.comboBoxLat.Name = "comboBoxLat";
			this.comboBoxLat.Size = new System.Drawing.Size(74, 26);
			this.comboBoxLat.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(338, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "纬度：";
			// 
			// comboBoxName
			// 
			this.comboBoxName.FormattingEnabled = true;
			this.comboBoxName.Location = new System.Drawing.Point(100, 38);
			this.comboBoxName.Name = "comboBoxName";
			this.comboBoxName.Size = new System.Drawing.Size(74, 26);
			this.comboBoxName.TabIndex = 1;
			// 
			// comboBoxLng
			// 
			this.comboBoxLng.FormattingEnabled = true;
			this.comboBoxLng.Location = new System.Drawing.Point(244, 38);
			this.comboBoxLng.Name = "comboBoxLng";
			this.comboBoxLng.Size = new System.Drawing.Size(74, 26);
			this.comboBoxLng.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(188, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "经度：";
			// 
			// LL2kmlForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(883, 884);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBoxSeparator);
			this.Controls.Add(this.dataGridView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LL2kmlForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "经纬度转kml";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.groupBoxSeparator.ResumeLayout(false);
			this.groupBoxSeparator.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button buttonImportFile;
		private System.Windows.Forms.GroupBox groupBoxSeparator;
		private System.Windows.Forms.RadioButton radioButtonSpace;
		private System.Windows.Forms.RadioButton radioButtonComma;
		private System.Windows.Forms.RadioButton radioButtonTab;
		private System.Windows.Forms.RadioButton radioButtonSemicolon;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox comboBoxLat;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxLng;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBoxSkipFirstLine;
		private System.Windows.Forms.Button buttonExportKml;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxName;
		private System.Windows.Forms.TextBox textBoxOther;
		private System.Windows.Forms.RadioButton radioButtonOther;
		private System.Windows.Forms.Label label4;
	}
}