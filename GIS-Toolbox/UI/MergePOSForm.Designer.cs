namespace GIS_Toolbox
{
	partial class MergePOSForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MergePOSForm));
			this.label1 = new System.Windows.Forms.Label();
			this.buttonAddFile = new System.Windows.Forms.Button();
			this.textBoxInputFiles = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxOutputFile = new System.Windows.Forms.TextBox();
			this.buttonSetOutput = new System.Windows.Forms.Button();
			this.checkBoxFirstLine = new System.Windows.Forms.CheckBox();
			this.buttonMerge = new System.Windows.Forms.Button();
			this.buttonDeleteAll = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(67, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "POS文件：";
			// 
			// buttonAddFile
			// 
			this.buttonAddFile.Location = new System.Drawing.Point(999, 27);
			this.buttonAddFile.Name = "buttonAddFile";
			this.buttonAddFile.Size = new System.Drawing.Size(75, 34);
			this.buttonAddFile.TabIndex = 1;
			this.buttonAddFile.Text = "添加";
			this.buttonAddFile.UseVisualStyleBackColor = true;
			this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
			// 
			// textBoxInputFiles
			// 
			this.textBoxInputFiles.Location = new System.Drawing.Point(154, 27);
			this.textBoxInputFiles.Multiline = true;
			this.textBoxInputFiles.Name = "textBoxInputFiles";
			this.textBoxInputFiles.Size = new System.Drawing.Size(816, 269);
			this.textBoxInputFiles.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "合并后POS文件：";
			// 
			// textBoxOutputFile
			// 
			this.textBoxOutputFile.Location = new System.Drawing.Point(153, 49);
			this.textBoxOutputFile.Name = "textBoxOutputFile";
			this.textBoxOutputFile.Size = new System.Drawing.Size(545, 28);
			this.textBoxOutputFile.TabIndex = 3;
			// 
			// buttonSetOutput
			// 
			this.buttonSetOutput.Location = new System.Drawing.Point(718, 47);
			this.buttonSetOutput.Name = "buttonSetOutput";
			this.buttonSetOutput.Size = new System.Drawing.Size(61, 33);
			this.buttonSetOutput.TabIndex = 1;
			this.buttonSetOutput.Text = "...";
			this.buttonSetOutput.UseVisualStyleBackColor = true;
			this.buttonSetOutput.Click += new System.EventHandler(this.buttonSetOutput_Click);
			// 
			// checkBoxFirstLine
			// 
			this.checkBoxFirstLine.AutoSize = true;
			this.checkBoxFirstLine.Location = new System.Drawing.Point(827, 55);
			this.checkBoxFirstLine.Name = "checkBoxFirstLine";
			this.checkBoxFirstLine.Size = new System.Drawing.Size(106, 22);
			this.checkBoxFirstLine.TabIndex = 4;
			this.checkBoxFirstLine.Text = "跳过首行";
			this.checkBoxFirstLine.UseVisualStyleBackColor = true;
			// 
			// buttonMerge
			// 
			this.buttonMerge.Location = new System.Drawing.Point(998, 47);
			this.buttonMerge.Name = "buttonMerge";
			this.buttonMerge.Size = new System.Drawing.Size(75, 34);
			this.buttonMerge.TabIndex = 5;
			this.buttonMerge.Text = "合并";
			this.buttonMerge.UseVisualStyleBackColor = true;
			this.buttonMerge.Click += new System.EventHandler(this.buttonMerge_Click);
			// 
			// buttonDeleteAll
			// 
			this.buttonDeleteAll.Location = new System.Drawing.Point(999, 91);
			this.buttonDeleteAll.Name = "buttonDeleteAll";
			this.buttonDeleteAll.Size = new System.Drawing.Size(75, 34);
			this.buttonDeleteAll.TabIndex = 6;
			this.buttonDeleteAll.Text = "清除";
			this.buttonDeleteAll.UseVisualStyleBackColor = true;
			this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.buttonDeleteAll);
			this.groupBox1.Controls.Add(this.buttonAddFile);
			this.groupBox1.Controls.Add(this.textBoxInputFiles);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1117, 321);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "输入";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.buttonSetOutput);
			this.groupBox2.Controls.Add(this.textBoxOutputFile);
			this.groupBox2.Controls.Add(this.buttonMerge);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.checkBoxFirstLine);
			this.groupBox2.Location = new System.Drawing.Point(13, 350);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1114, 118);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "输出";
			// 
			// MergePOSForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1141, 480);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MergePOSForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "合并POS文件";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonAddFile;
		private System.Windows.Forms.TextBox textBoxInputFiles;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxOutputFile;
		private System.Windows.Forms.Button buttonSetOutput;
		private System.Windows.Forms.CheckBox checkBoxFirstLine;
		private System.Windows.Forms.Button buttonMerge;
		private System.Windows.Forms.Button buttonDeleteAll;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}