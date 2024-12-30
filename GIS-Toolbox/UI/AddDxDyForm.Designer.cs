namespace GIS_Toolbox
{
	partial class AddDxDyForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDxDyForm));
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxPOS = new System.Windows.Forms.TextBox();
			this.buttonOpenPOS = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxDx = new System.Windows.Forms.ComboBox();
			this.comboBoxDy = new System.Windows.Forms.ComboBox();
			this.checkBoxSkipFirstLine = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "POS文件：";
			// 
			// textBoxPOS
			// 
			this.textBoxPOS.Location = new System.Drawing.Point(129, 35);
			this.textBoxPOS.Name = "textBoxPOS";
			this.textBoxPOS.Size = new System.Drawing.Size(713, 28);
			this.textBoxPOS.TabIndex = 1;
			// 
			// buttonOpenPOS
			// 
			this.buttonOpenPOS.Location = new System.Drawing.Point(872, 33);
			this.buttonOpenPOS.Name = "buttonOpenPOS";
			this.buttonOpenPOS.Size = new System.Drawing.Size(61, 33);
			this.buttonOpenPOS.TabIndex = 2;
			this.buttonOpenPOS.Text = "...";
			this.buttonOpenPOS.UseVisualStyleBackColor = true;
			this.buttonOpenPOS.Click += new System.EventHandler(this.buttonOpenPOS_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(965, 35);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(91, 91);
			this.buttonAdd.TabIndex = 3;
			this.buttonAdd.Text = "添加";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "水平精度：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(316, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 18);
			this.label3.TabIndex = 4;
			this.label3.Text = "垂直精度：";
			// 
			// comboBoxDx
			// 
			this.comboBoxDx.FormattingEnabled = true;
			this.comboBoxDx.Location = new System.Drawing.Point(129, 103);
			this.comboBoxDx.Name = "comboBoxDx";
			this.comboBoxDx.Size = new System.Drawing.Size(121, 26);
			this.comboBoxDx.TabIndex = 5;
			// 
			// comboBoxDy
			// 
			this.comboBoxDy.FormattingEnabled = true;
			this.comboBoxDy.Location = new System.Drawing.Point(420, 103);
			this.comboBoxDy.Name = "comboBoxDy";
			this.comboBoxDy.Size = new System.Drawing.Size(121, 26);
			this.comboBoxDy.TabIndex = 5;
			// 
			// checkBoxSkipFirstLine
			// 
			this.checkBoxSkipFirstLine.AutoSize = true;
			this.checkBoxSkipFirstLine.Location = new System.Drawing.Point(644, 108);
			this.checkBoxSkipFirstLine.Name = "checkBoxSkipFirstLine";
			this.checkBoxSkipFirstLine.Size = new System.Drawing.Size(106, 22);
			this.checkBoxSkipFirstLine.TabIndex = 7;
			this.checkBoxSkipFirstLine.Text = "跳过首行";
			this.checkBoxSkipFirstLine.UseVisualStyleBackColor = true;
			// 
			// AddDxDyForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1093, 162);
			this.Controls.Add(this.checkBoxSkipFirstLine);
			this.Controls.Add(this.comboBoxDy);
			this.Controls.Add(this.comboBoxDx);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonOpenPOS);
			this.Controls.Add(this.textBoxPOS);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddDxDyForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "POS文件添加水平和垂直精度";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxPOS;
		private System.Windows.Forms.Button buttonOpenPOS;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxDx;
		private System.Windows.Forms.ComboBox comboBoxDy;
		private System.Windows.Forms.CheckBox checkBoxSkipFirstLine;
	}
}