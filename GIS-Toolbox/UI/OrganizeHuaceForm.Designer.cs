namespace GIS_Toolbox
{
	partial class OrganizeHuaceForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganizeHuaceForm));
			this.buttonStart = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxInput = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxOutput = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonInput = new System.Windows.Forms.Button();
			this.buttonOutput = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(920, 51);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(104, 104);
			this.buttonStart.TabIndex = 0;
			this.buttonStart.Text = "开始";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 18);
			this.label1.TabIndex = 1;
			// 
			// textBoxInput
			// 
			this.textBoxInput.Location = new System.Drawing.Point(173, 54);
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.Size = new System.Drawing.Size(608, 28);
			this.textBoxInput.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "原始数据路径：";
			// 
			// textBoxOutput
			// 
			this.textBoxOutput.Location = new System.Drawing.Point(173, 124);
			this.textBoxOutput.Name = "textBoxOutput";
			this.textBoxOutput.Size = new System.Drawing.Size(608, 28);
			this.textBoxOutput.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(69, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 18);
			this.label3.TabIndex = 1;
			this.label3.Text = "输出路径：";
			// 
			// buttonInput
			// 
			this.buttonInput.Location = new System.Drawing.Point(813, 51);
			this.buttonInput.Name = "buttonInput";
			this.buttonInput.Size = new System.Drawing.Size(61, 33);
			this.buttonInput.TabIndex = 3;
			this.buttonInput.Text = "...";
			this.buttonInput.UseVisualStyleBackColor = true;
			this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
			// 
			// buttonOutput
			// 
			this.buttonOutput.Location = new System.Drawing.Point(813, 122);
			this.buttonOutput.Name = "buttonOutput";
			this.buttonOutput.Size = new System.Drawing.Size(61, 33);
			this.buttonOutput.TabIndex = 3;
			this.buttonOutput.Text = "...";
			this.buttonOutput.UseVisualStyleBackColor = true;
			this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
			// 
			// OrganizeHuaceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 208);
			this.Controls.Add(this.buttonOutput);
			this.Controls.Add(this.buttonInput);
			this.Controls.Add(this.textBoxOutput);
			this.Controls.Add(this.textBoxInput);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonStart);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OrganizeHuaceForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "整理华测激光雷达数据并合并POS文件";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxInput;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxOutput;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonInput;
		private System.Windows.Forms.Button buttonOutput;
	}
}