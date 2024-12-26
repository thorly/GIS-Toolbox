namespace GIS_Toolbox.UI
{
	partial class SplitFeimaCameraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplitFeimaCameraForm));
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxImageDir = new System.Windows.Forms.TextBox();
			this.buttonOpen = new System.Windows.Forms.Button();
			this.checkBoxDelete = new System.Windows.Forms.CheckBox();
			this.buttonSplit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "原始照片路径：";
			// 
			// textBoxImageDir
			// 
			this.textBoxImageDir.Location = new System.Drawing.Point(157, 38);
			this.textBoxImageDir.Name = "textBoxImageDir";
			this.textBoxImageDir.Size = new System.Drawing.Size(632, 28);
			this.textBoxImageDir.TabIndex = 1;
			// 
			// buttonOpen
			// 
			this.buttonOpen.Location = new System.Drawing.Point(813, 37);
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new System.Drawing.Size(61, 33);
			this.buttonOpen.TabIndex = 2;
			this.buttonOpen.Text = "...";
			this.buttonOpen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.buttonOpen.UseVisualStyleBackColor = true;
			this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
			// 
			// checkBoxDelete
			// 
			this.checkBoxDelete.AutoSize = true;
			this.checkBoxDelete.Location = new System.Drawing.Point(660, 110);
			this.checkBoxDelete.Name = "checkBoxDelete";
			this.checkBoxDelete.Size = new System.Drawing.Size(214, 22);
			this.checkBoxDelete.TabIndex = 3;
			this.checkBoxDelete.Text = "删除所有架次试拍照片";
			this.checkBoxDelete.UseVisualStyleBackColor = true;
			// 
			// buttonSplit
			// 
			this.buttonSplit.Location = new System.Drawing.Point(908, 37);
			this.buttonSplit.Name = "buttonSplit";
			this.buttonSplit.Size = new System.Drawing.Size(95, 95);
			this.buttonSplit.TabIndex = 4;
			this.buttonSplit.Text = "开始";
			this.buttonSplit.UseVisualStyleBackColor = true;
			this.buttonSplit.Click += new System.EventHandler(this.buttonSplit_Click);
			// 
			// SplitFeimaCameraForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1058, 169);
			this.Controls.Add(this.buttonSplit);
			this.Controls.Add(this.checkBoxDelete);
			this.Controls.Add(this.buttonOpen);
			this.Controls.Add(this.textBoxImageDir);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SplitFeimaCameraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "飞马无人机照片分架次处理";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxImageDir;
		private System.Windows.Forms.Button buttonOpen;
		private System.Windows.Forms.CheckBox checkBoxDelete;
		private System.Windows.Forms.Button buttonSplit;
	}
}