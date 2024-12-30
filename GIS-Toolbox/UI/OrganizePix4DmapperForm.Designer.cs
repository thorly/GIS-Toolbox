namespace GIS_Toolbox.UI
{
	partial class OrganizePix4DmapperForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganizePix4DmapperForm));
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxDirectory = new System.Windows.Forms.TextBox();
			this.buttonAddDirectory = new System.Windows.Forms.Button();
			this.checkBoxDelete = new System.Windows.Forms.CheckBox();
			this.buttonClearDirectory = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.buttonOrganize = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "工程文件夹：";
			// 
			// textBoxDirectory
			// 
			this.textBoxDirectory.Location = new System.Drawing.Point(129, 50);
			this.textBoxDirectory.Multiline = true;
			this.textBoxDirectory.Name = "textBoxDirectory";
			this.textBoxDirectory.Size = new System.Drawing.Size(716, 217);
			this.textBoxDirectory.TabIndex = 1;
			// 
			// buttonAddDirectory
			// 
			this.buttonAddDirectory.Location = new System.Drawing.Point(865, 50);
			this.buttonAddDirectory.Name = "buttonAddDirectory";
			this.buttonAddDirectory.Size = new System.Drawing.Size(75, 34);
			this.buttonAddDirectory.TabIndex = 1;
			this.buttonAddDirectory.Text = "添加";
			this.buttonAddDirectory.UseVisualStyleBackColor = true;
			this.buttonAddDirectory.Click += new System.EventHandler(this.buttonAddDirectory_Click);
			// 
			// checkBoxDelete
			// 
			this.checkBoxDelete.AutoSize = true;
			this.checkBoxDelete.Location = new System.Drawing.Point(39, 44);
			this.checkBoxDelete.Name = "checkBoxDelete";
			this.checkBoxDelete.Size = new System.Drawing.Size(286, 22);
			this.checkBoxDelete.TabIndex = 3;
			this.checkBoxDelete.Text = "删除其余文件，只保留DOM和DSM";
			this.checkBoxDelete.UseVisualStyleBackColor = true;
			// 
			// buttonClearDirectory
			// 
			this.buttonClearDirectory.Location = new System.Drawing.Point(865, 113);
			this.buttonClearDirectory.Name = "buttonClearDirectory";
			this.buttonClearDirectory.Size = new System.Drawing.Size(75, 34);
			this.buttonClearDirectory.TabIndex = 2;
			this.buttonClearDirectory.Text = "清除";
			this.buttonClearDirectory.UseVisualStyleBackColor = true;
			this.buttonClearDirectory.Click += new System.EventHandler(this.buttonClearDirectory_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxDirectory);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.buttonClearDirectory);
			this.groupBox1.Controls.Add(this.buttonAddDirectory);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(981, 298);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "输入";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.buttonOrganize);
			this.groupBox2.Controls.Add(this.checkBoxDelete);
			this.groupBox2.Location = new System.Drawing.Point(12, 338);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(981, 89);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "设置";
			// 
			// buttonOrganize
			// 
			this.buttonOrganize.Location = new System.Drawing.Point(865, 32);
			this.buttonOrganize.Name = "buttonOrganize";
			this.buttonOrganize.Size = new System.Drawing.Size(75, 34);
			this.buttonOrganize.TabIndex = 4;
			this.buttonOrganize.Text = "整理";
			this.buttonOrganize.UseVisualStyleBackColor = true;
			this.buttonOrganize.Click += new System.EventHandler(this.buttonOrganize_Click);
			// 
			// OrganizePix4DmapperForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1005, 440);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OrganizePix4DmapperForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "整理Pix4Dmapper工程文件夹";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxDirectory;
		private System.Windows.Forms.Button buttonAddDirectory;
		private System.Windows.Forms.CheckBox checkBoxDelete;
		private System.Windows.Forms.Button buttonClearDirectory;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button buttonOrganize;
	}
}