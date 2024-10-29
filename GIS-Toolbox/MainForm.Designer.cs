namespace GIS_Toolbox
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.基于POS显示图片ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.HuaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DJIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importKmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.小工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.整理Lidar数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MergePOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DeleteFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ll2kmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExtractColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.清除图层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ClearPOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ClearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.切换地图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TianDiTuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TianDiTuImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BingImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.切换地图ToolStripMenuItem,
            this.基于POS显示图片ToolStripMenuItem1,
            this.importKmlToolStripMenuItem,
            this.小工具ToolStripMenuItem,
            this.清除图层ToolStripMenuItem,
            this.AboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1539, 32);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 基于POS显示图片ToolStripMenuItem1
			// 
			this.基于POS显示图片ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HuaceToolStripMenuItem,
            this.DJIToolStripMenuItem});
			this.基于POS显示图片ToolStripMenuItem1.Name = "基于POS显示图片ToolStripMenuItem1";
			this.基于POS显示图片ToolStripMenuItem1.Size = new System.Drawing.Size(170, 28);
			this.基于POS显示图片ToolStripMenuItem1.Text = "基于POS显示图片";
			// 
			// HuaceToolStripMenuItem
			// 
			this.HuaceToolStripMenuItem.Name = "HuaceToolStripMenuItem";
			this.HuaceToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
			this.HuaceToolStripMenuItem.Text = "华测激光雷达";
			this.HuaceToolStripMenuItem.Click += new System.EventHandler(this.HuaceToolStripMenuItem_Click);
			// 
			// DJIToolStripMenuItem
			// 
			this.DJIToolStripMenuItem.Name = "DJIToolStripMenuItem";
			this.DJIToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
			this.DJIToolStripMenuItem.Text = "大疆无人机";
			this.DJIToolStripMenuItem.Click += new System.EventHandler(this.DJIToolStripMenuItem_Click);
			// 
			// importKmlToolStripMenuItem
			// 
			this.importKmlToolStripMenuItem.Name = "importKmlToolStripMenuItem";
			this.importKmlToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
			this.importKmlToolStripMenuItem.Text = "导入kml";
			this.importKmlToolStripMenuItem.Click += new System.EventHandler(this.ImportKmlToolStripMenuItem_Click);
			// 
			// 小工具ToolStripMenuItem
			// 
			this.小工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.整理Lidar数据ToolStripMenuItem,
            this.MergePOSToolStripMenuItem,
            this.DeleteFilesToolStripMenuItem,
            this.ll2kmlToolStripMenuItem,
            this.ExtractColumnToolStripMenuItem});
			this.小工具ToolStripMenuItem.Name = "小工具ToolStripMenuItem";
			this.小工具ToolStripMenuItem.Size = new System.Drawing.Size(80, 28);
			this.小工具ToolStripMenuItem.Text = "小工具";
			// 
			// 整理Lidar数据ToolStripMenuItem
			// 
			this.整理Lidar数据ToolStripMenuItem.Name = "整理Lidar数据ToolStripMenuItem";
			this.整理Lidar数据ToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
			this.整理Lidar数据ToolStripMenuItem.Text = "整理Lidar数据-华测";
			this.整理Lidar数据ToolStripMenuItem.Click += new System.EventHandler(this.整理Lidar数据ToolStripMenuItem_Click);
			// 
			// MergePOSToolStripMenuItem
			// 
			this.MergePOSToolStripMenuItem.Name = "MergePOSToolStripMenuItem";
			this.MergePOSToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
			this.MergePOSToolStripMenuItem.Text = "合并POS文件";
			this.MergePOSToolStripMenuItem.Click += new System.EventHandler(this.MergePOSToolStripMenuItem_Click);
			// 
			// DeleteFilesToolStripMenuItem
			// 
			this.DeleteFilesToolStripMenuItem.Name = "DeleteFilesToolStripMenuItem";
			this.DeleteFilesToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
			this.DeleteFilesToolStripMenuItem.Text = "删除指定扩展名文件";
			this.DeleteFilesToolStripMenuItem.Click += new System.EventHandler(this.DeleteFilesToolStripMenuItem_Click);
			// 
			// ll2kmlToolStripMenuItem
			// 
			this.ll2kmlToolStripMenuItem.Name = "ll2kmlToolStripMenuItem";
			this.ll2kmlToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
			this.ll2kmlToolStripMenuItem.Text = "经纬度转kml";
			this.ll2kmlToolStripMenuItem.Click += new System.EventHandler(this.Ll2kmlToolStripMenuItem_Click);
			// 
			// ExtractColumnToolStripMenuItem
			// 
			this.ExtractColumnToolStripMenuItem.Name = "ExtractColumnToolStripMenuItem";
			this.ExtractColumnToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
			this.ExtractColumnToolStripMenuItem.Text = "提取某几列数据";
			this.ExtractColumnToolStripMenuItem.Click += new System.EventHandler(this.ExtractColumnToolStripMenuItem_Click);
			// 
			// 清除图层ToolStripMenuItem
			// 
			this.清除图层ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearPOSToolStripMenuItem,
            this.ClearAllToolStripMenuItem});
			this.清除图层ToolStripMenuItem.Name = "清除图层ToolStripMenuItem";
			this.清除图层ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
			this.清除图层ToolStripMenuItem.Text = "清除图层";
			// 
			// ClearPOSToolStripMenuItem
			// 
			this.ClearPOSToolStripMenuItem.Name = "ClearPOSToolStripMenuItem";
			this.ClearPOSToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
			this.ClearPOSToolStripMenuItem.Text = "清除POS图层";
			this.ClearPOSToolStripMenuItem.Click += new System.EventHandler(this.ClearPOSToolStripMenuItem_Click);
			// 
			// ClearAllToolStripMenuItem
			// 
			this.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem";
			this.ClearAllToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
			this.ClearAllToolStripMenuItem.Text = "清除所有图层";
			this.ClearAllToolStripMenuItem.Click += new System.EventHandler(this.ClearAllToolStripMenuItem_Click);
			// 
			// AboutToolStripMenuItem
			// 
			this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
			this.AboutToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
			this.AboutToolStripMenuItem.Text = "关于";
			this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
			// 
			// 切换地图ToolStripMenuItem
			// 
			this.切换地图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TianDiTuToolStripMenuItem,
            this.TianDiTuImageToolStripMenuItem,
            this.BingImageToolStripMenuItem});
			this.切换地图ToolStripMenuItem.Name = "切换地图ToolStripMenuItem";
			this.切换地图ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
			this.切换地图ToolStripMenuItem.Text = "切换地图";
			// 
			// TianDiTuToolStripMenuItem
			// 
			this.TianDiTuToolStripMenuItem.Name = "TianDiTuToolStripMenuItem";
			this.TianDiTuToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
			this.TianDiTuToolStripMenuItem.Text = "天地图";
			this.TianDiTuToolStripMenuItem.Click += new System.EventHandler(this.TianDiTuToolStripMenuItem_Click);
			// 
			// TianDiTuImageToolStripMenuItem
			// 
			this.TianDiTuImageToolStripMenuItem.Name = "TianDiTuImageToolStripMenuItem";
			this.TianDiTuImageToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
			this.TianDiTuImageToolStripMenuItem.Text = "天地图卫星影像";
			this.TianDiTuImageToolStripMenuItem.Click += new System.EventHandler(this.TianDiTuImageToolStripMenuItem_Click);
			// 
			// BingImageToolStripMenuItem
			// 
			this.BingImageToolStripMenuItem.Name = "BingImageToolStripMenuItem";
			this.BingImageToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
			this.BingImageToolStripMenuItem.Text = "Bing卫星影像";
			this.BingImageToolStripMenuItem.Click += new System.EventHandler(this.BingImageToolStripMenuItem_Click);
			// 
			// gMapControl
			// 
			this.gMapControl.Bearing = 0F;
			this.gMapControl.CanDragMap = true;
			this.gMapControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
			this.gMapControl.GrayScaleMode = false;
			this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
			this.gMapControl.LevelsKeepInMemmory = 5;
			this.gMapControl.Location = new System.Drawing.Point(0, 32);
			this.gMapControl.MarkersEnabled = true;
			this.gMapControl.MaxZoom = 2;
			this.gMapControl.MinZoom = 2;
			this.gMapControl.MouseWheelZoomEnabled = true;
			this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
			this.gMapControl.Name = "gMapControl";
			this.gMapControl.NegativeMode = false;
			this.gMapControl.PolygonsEnabled = true;
			this.gMapControl.RetryLoadTile = 0;
			this.gMapControl.RoutesEnabled = true;
			this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
			this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
			this.gMapControl.ShowTileGridLines = false;
			this.gMapControl.Size = new System.Drawing.Size(1539, 753);
			this.gMapControl.TabIndex = 0;
			this.gMapControl.Zoom = 0D;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1539, 785);
			this.Controls.Add(this.gMapControl);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "GIS Toolbox";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private GMap.NET.WindowsForms.GMapControl gMapControl;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 小工具ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 整理Lidar数据ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MergePOSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importKmlToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DeleteFilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ll2kmlToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ExtractColumnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 清除图层ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ClearPOSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ClearAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 基于POS显示图片ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem HuaceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DJIToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 切换地图ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem TianDiTuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem TianDiTuImageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem BingImageToolStripMenuItem;
	}
}

