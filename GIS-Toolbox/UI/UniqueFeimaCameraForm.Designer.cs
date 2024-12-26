namespace GIS_Toolbox.UI
{
	partial class UniqueFeimaCameraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UniqueFeimaCameraForm));
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxImageDir = new System.Windows.Forms.TextBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonStart = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxStartNum = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "照片文件夹：";
			// 
			// textBoxImageDir
			// 
			this.textBoxImageDir.Location = new System.Drawing.Point(144, 49);
			this.textBoxImageDir.Multiline = true;
			this.textBoxImageDir.Name = "textBoxImageDir";
			this.textBoxImageDir.Size = new System.Drawing.Size(651, 242);
			this.textBoxImageDir.TabIndex = 1;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(837, 49);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 34);
			this.buttonAdd.TabIndex = 2;
			this.buttonAdd.Text = "添加";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(837, 110);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(75, 34);
			this.buttonClear.TabIndex = 3;
			this.buttonClear.Text = "清除";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(834, 37);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(75, 34);
			this.buttonStart.TabIndex = 4;
			this.buttonStart.Text = "开始";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 18);
			this.label2.TabIndex = 5;
			this.label2.Text = "前缀起始数字：";
			// 
			// textBoxStartNum
			// 
			this.textBoxStartNum.Location = new System.Drawing.Point(161, 42);
			this.textBoxStartNum.Name = "textBoxStartNum";
			this.textBoxStartNum.Size = new System.Drawing.Size(100, 28);
			this.textBoxStartNum.TabIndex = 6;
			this.textBoxStartNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartNum_KeyPress);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonStart);
			this.groupBox1.Controls.Add(this.textBoxStartNum);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(13, 353);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(938, 100);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "输出设置";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBoxImageDir);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.buttonClear);
			this.groupBox2.Controls.Add(this.buttonAdd);
			this.groupBox2.Location = new System.Drawing.Point(13, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(937, 313);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "输入设置";
			// 
			// UniqueFeimaCameraForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(962, 474);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UniqueFeimaCameraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "飞马无人机照片唯一化处理";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxImageDir;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxStartNum;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}