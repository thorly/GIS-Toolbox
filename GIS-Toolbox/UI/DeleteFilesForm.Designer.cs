namespace GIS_Toolbox
{
	partial class DeleteFilesForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteFilesForm));
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxDirectory = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonDeleteAll = new System.Windows.Forms.Button();
			this.buttonOpenDir = new System.Windows.Forms.Button();
			this.comboBoxFileExtension = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "文件夹路径：";
			// 
			// textBoxDirectory
			// 
			this.textBoxDirectory.Location = new System.Drawing.Point(166, 39);
			this.textBoxDirectory.Name = "textBoxDirectory";
			this.textBoxDirectory.Size = new System.Drawing.Size(506, 28);
			this.textBoxDirectory.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 117);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "文件扩展名：";
			// 
			// buttonDeleteAll
			// 
			this.buttonDeleteAll.Location = new System.Drawing.Point(794, 39);
			this.buttonDeleteAll.Name = "buttonDeleteAll";
			this.buttonDeleteAll.Size = new System.Drawing.Size(99, 96);
			this.buttonDeleteAll.TabIndex = 4;
			this.buttonDeleteAll.Text = "删除";
			this.buttonDeleteAll.UseVisualStyleBackColor = true;
			this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
			// 
			// buttonOpenDir
			// 
			this.buttonOpenDir.Location = new System.Drawing.Point(691, 37);
			this.buttonOpenDir.Name = "buttonOpenDir";
			this.buttonOpenDir.Size = new System.Drawing.Size(61, 33);
			this.buttonOpenDir.TabIndex = 5;
			this.buttonOpenDir.Text = "...";
			this.buttonOpenDir.UseVisualStyleBackColor = true;
			this.buttonOpenDir.Click += new System.EventHandler(this.buttonOpenDir_Click);
			// 
			// comboBoxFileExtension
			// 
			this.comboBoxFileExtension.FormattingEnabled = true;
			this.comboBoxFileExtension.Location = new System.Drawing.Point(170, 108);
			this.comboBoxFileExtension.Name = "comboBoxFileExtension";
			this.comboBoxFileExtension.Size = new System.Drawing.Size(121, 26);
			this.comboBoxFileExtension.TabIndex = 6;
			// 
			// DeleteFilesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(937, 180);
			this.Controls.Add(this.comboBoxFileExtension);
			this.Controls.Add(this.buttonOpenDir);
			this.Controls.Add(this.buttonDeleteAll);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxDirectory);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DeleteFilesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "删除指定扩展名文件";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxDirectory;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonDeleteAll;
		private System.Windows.Forms.Button buttonOpenDir;
		private System.Windows.Forms.ComboBox comboBoxFileExtension;
	}
}