﻿namespace GIS_Toolbox
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.切换地图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TianDiTuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TianDiTuImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BingImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.基于POS显示图片ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.HuaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DJIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.画图工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MeasureDistanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DrawPolylineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DrawPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ImportKmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ImportKmlProToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LL2KmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MakeFeimaPOSPOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MergePOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddDxDyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.小工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.整理Lidar数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DeleteFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExtractColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OrganizePix4DmapperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SplitFeimaCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.UniqueFeimaCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.treeView = new System.Windows.Forms.TreeView();
			this.kmlContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.SaveKmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveKmlCheckedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExportImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DeleteLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToDxfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ZoomToLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.kmlContextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.切换地图ToolStripMenuItem,
            this.基于POS显示图片ToolStripMenuItem1,
            this.画图工具ToolStripMenuItem,
            this.kMLToolStripMenuItem,
            this.pOSToolStripMenuItem,
            this.小工具ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1539, 32);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
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
			this.TianDiTuToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.地图;
			this.TianDiTuToolStripMenuItem.Name = "TianDiTuToolStripMenuItem";
			this.TianDiTuToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
			this.TianDiTuToolStripMenuItem.Text = "天地图";
			this.TianDiTuToolStripMenuItem.Click += new System.EventHandler(this.TianDiTuToolStripMenuItem_Click);
			// 
			// TianDiTuImageToolStripMenuItem
			// 
			this.TianDiTuImageToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.星球;
			this.TianDiTuImageToolStripMenuItem.Name = "TianDiTuImageToolStripMenuItem";
			this.TianDiTuImageToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
			this.TianDiTuImageToolStripMenuItem.Text = "天地图卫星影像";
			this.TianDiTuImageToolStripMenuItem.Click += new System.EventHandler(this.TianDiTuImageToolStripMenuItem_Click);
			// 
			// BingImageToolStripMenuItem
			// 
			this.BingImageToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.必应;
			this.BingImageToolStripMenuItem.Name = "BingImageToolStripMenuItem";
			this.BingImageToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
			this.BingImageToolStripMenuItem.Text = "Bing卫星影像";
			this.BingImageToolStripMenuItem.Click += new System.EventHandler(this.BingImageToolStripMenuItem_Click);
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
			this.HuaceToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.雷达;
			this.HuaceToolStripMenuItem.Name = "HuaceToolStripMenuItem";
			this.HuaceToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
			this.HuaceToolStripMenuItem.Text = "飞马/华测激光雷达";
			this.HuaceToolStripMenuItem.Click += new System.EventHandler(this.HuaceToolStripMenuItem_Click);
			// 
			// DJIToolStripMenuItem
			// 
			this.DJIToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.摄像机;
			this.DJIToolStripMenuItem.Name = "DJIToolStripMenuItem";
			this.DJIToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
			this.DJIToolStripMenuItem.Text = "大疆无人机(自带POS)";
			this.DJIToolStripMenuItem.Click += new System.EventHandler(this.DJIToolStripMenuItem_Click);
			// 
			// 画图工具ToolStripMenuItem
			// 
			this.画图工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MeasureDistanceToolStripMenuItem,
            this.DrawPolylineToolStripMenuItem,
            this.DrawPolygonToolStripMenuItem});
			this.画图工具ToolStripMenuItem.Name = "画图工具ToolStripMenuItem";
			this.画图工具ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
			this.画图工具ToolStripMenuItem.Text = "画图工具";
			// 
			// MeasureDistanceToolStripMenuItem
			// 
			this.MeasureDistanceToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.距离;
			this.MeasureDistanceToolStripMenuItem.Name = "MeasureDistanceToolStripMenuItem";
			this.MeasureDistanceToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
			this.MeasureDistanceToolStripMenuItem.Text = "测距";
			this.MeasureDistanceToolStripMenuItem.Click += new System.EventHandler(this.MeasureDistanceToolStripMenuItem_Click);
			// 
			// DrawPolylineToolStripMenuItem
			// 
			this.DrawPolylineToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.线段;
			this.DrawPolylineToolStripMenuItem.Name = "DrawPolylineToolStripMenuItem";
			this.DrawPolylineToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
			this.DrawPolylineToolStripMenuItem.Text = "多段线";
			this.DrawPolylineToolStripMenuItem.Click += new System.EventHandler(this.DrawPolylineToolStripMenuItem_Click);
			// 
			// DrawPolygonToolStripMenuItem
			// 
			this.DrawPolygonToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.多边形;
			this.DrawPolygonToolStripMenuItem.Name = "DrawPolygonToolStripMenuItem";
			this.DrawPolygonToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
			this.DrawPolygonToolStripMenuItem.Text = "多边形";
			this.DrawPolygonToolStripMenuItem.Click += new System.EventHandler(this.DrawPolygonToolStripMenuItem_Click);
			// 
			// kMLToolStripMenuItem
			// 
			this.kMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportKmlToolStripMenuItem,
            this.ImportKmlProToolStripMenuItem,
            this.LL2KmlToolStripMenuItem});
			this.kMLToolStripMenuItem.Name = "kMLToolStripMenuItem";
			this.kMLToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
			this.kMLToolStripMenuItem.Text = "kml";
			// 
			// ImportKmlToolStripMenuItem
			// 
			this.ImportKmlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ImportKmlToolStripMenuItem.Image")));
			this.ImportKmlToolStripMenuItem.Name = "ImportKmlToolStripMenuItem";
			this.ImportKmlToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
			this.ImportKmlToolStripMenuItem.Text = "导入kml";
			this.ImportKmlToolStripMenuItem.Click += new System.EventHandler(this.ImportKmlToolStripMenuItem_Click_1);
			// 
			// ImportKmlProToolStripMenuItem
			// 
			this.ImportKmlProToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ImportKmlProToolStripMenuItem.Image")));
			this.ImportKmlProToolStripMenuItem.Name = "ImportKmlProToolStripMenuItem";
			this.ImportKmlProToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
			this.ImportKmlProToolStripMenuItem.Text = "导入kml（高级设置）";
			this.ImportKmlProToolStripMenuItem.Click += new System.EventHandler(this.ImportKmlProToolStripMenuItem_Click);
			// 
			// LL2KmlToolStripMenuItem
			// 
			this.LL2KmlToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.转换;
			this.LL2KmlToolStripMenuItem.Name = "LL2KmlToolStripMenuItem";
			this.LL2KmlToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
			this.LL2KmlToolStripMenuItem.Text = "经纬度转kml";
			this.LL2KmlToolStripMenuItem.Click += new System.EventHandler(this.LL2KmlToolStripMenuItem_Click_1);
			// 
			// pOSToolStripMenuItem
			// 
			this.pOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MakeFeimaPOSPOSToolStripMenuItem,
            this.MergePOSToolStripMenuItem,
            this.AddDxDyToolStripMenuItem});
			this.pOSToolStripMenuItem.Name = "pOSToolStripMenuItem";
			this.pOSToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
			this.pOSToolStripMenuItem.Text = "POS";
			// 
			// MakeFeimaPOSPOSToolStripMenuItem
			// 
			this.MakeFeimaPOSPOSToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.马;
			this.MakeFeimaPOSPOSToolStripMenuItem.Name = "MakeFeimaPOSPOSToolStripMenuItem";
			this.MakeFeimaPOSPOSToolStripMenuItem.Size = new System.Drawing.Size(344, 34);
			this.MakeFeimaPOSPOSToolStripMenuItem.Text = "制作飞马无人机POS";
			this.MakeFeimaPOSPOSToolStripMenuItem.Click += new System.EventHandler(this.MakeFeimaPOSPOSToolStripMenuItem_Click);
			// 
			// MergePOSToolStripMenuItem
			// 
			this.MergePOSToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.合并;
			this.MergePOSToolStripMenuItem.Name = "MergePOSToolStripMenuItem";
			this.MergePOSToolStripMenuItem.Size = new System.Drawing.Size(344, 34);
			this.MergePOSToolStripMenuItem.Text = "合并POS文件";
			this.MergePOSToolStripMenuItem.Click += new System.EventHandler(this.MergePOSToolStripMenuItem_Click);
			// 
			// AddDxDyToolStripMenuItem
			// 
			this.AddDxDyToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.添加列;
			this.AddDxDyToolStripMenuItem.Name = "AddDxDyToolStripMenuItem";
			this.AddDxDyToolStripMenuItem.Size = new System.Drawing.Size(344, 34);
			this.AddDxDyToolStripMenuItem.Text = "POS文件添加水平和垂直精度";
			this.AddDxDyToolStripMenuItem.Click += new System.EventHandler(this.AddDxDyToolStripMenuItem_Click);
			// 
			// 小工具ToolStripMenuItem
			// 
			this.小工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.整理Lidar数据ToolStripMenuItem,
            this.DeleteFilesToolStripMenuItem,
            this.ExtractColumnToolStripMenuItem,
            this.OrganizePix4DmapperToolStripMenuItem,
            this.SplitFeimaCameraToolStripMenuItem,
            this.UniqueFeimaCameraToolStripMenuItem});
			this.小工具ToolStripMenuItem.Name = "小工具ToolStripMenuItem";
			this.小工具ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
			this.小工具ToolStripMenuItem.Text = "其他";
			// 
			// 整理Lidar数据ToolStripMenuItem
			// 
			this.整理Lidar数据ToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.整理;
			this.整理Lidar数据ToolStripMenuItem.Name = "整理Lidar数据ToolStripMenuItem";
			this.整理Lidar数据ToolStripMenuItem.Size = new System.Drawing.Size(354, 34);
			this.整理Lidar数据ToolStripMenuItem.Text = "整理华测Lidar数据";
			this.整理Lidar数据ToolStripMenuItem.Click += new System.EventHandler(this.整理Lidar数据ToolStripMenuItem_Click);
			// 
			// DeleteFilesToolStripMenuItem
			// 
			this.DeleteFilesToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.删除;
			this.DeleteFilesToolStripMenuItem.Name = "DeleteFilesToolStripMenuItem";
			this.DeleteFilesToolStripMenuItem.Size = new System.Drawing.Size(354, 34);
			this.DeleteFilesToolStripMenuItem.Text = "删除指定扩展名文件";
			this.DeleteFilesToolStripMenuItem.Click += new System.EventHandler(this.DeleteFilesToolStripMenuItem_Click);
			// 
			// ExtractColumnToolStripMenuItem
			// 
			this.ExtractColumnToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.列;
			this.ExtractColumnToolStripMenuItem.Name = "ExtractColumnToolStripMenuItem";
			this.ExtractColumnToolStripMenuItem.Size = new System.Drawing.Size(354, 34);
			this.ExtractColumnToolStripMenuItem.Text = "提取某几列数据";
			this.ExtractColumnToolStripMenuItem.Click += new System.EventHandler(this.ExtractColumnToolStripMenuItem_Click);
			// 
			// OrganizePix4DmapperToolStripMenuItem
			// 
			this.OrganizePix4DmapperToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.整理;
			this.OrganizePix4DmapperToolStripMenuItem.Name = "OrganizePix4DmapperToolStripMenuItem";
			this.OrganizePix4DmapperToolStripMenuItem.Size = new System.Drawing.Size(354, 34);
			this.OrganizePix4DmapperToolStripMenuItem.Text = "整理Pix4Dmapper工程文件夹";
			this.OrganizePix4DmapperToolStripMenuItem.Click += new System.EventHandler(this.OrganizePix4DmapperToolStripMenuItem_Click);
			// 
			// SplitFeimaCameraToolStripMenuItem
			// 
			this.SplitFeimaCameraToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.分离;
			this.SplitFeimaCameraToolStripMenuItem.Name = "SplitFeimaCameraToolStripMenuItem";
			this.SplitFeimaCameraToolStripMenuItem.Size = new System.Drawing.Size(354, 34);
			this.SplitFeimaCameraToolStripMenuItem.Text = "飞马无人机照片分架次处理";
			this.SplitFeimaCameraToolStripMenuItem.Click += new System.EventHandler(this.SplitFeimaCameraToolStripMenuItem_Click);
			// 
			// UniqueFeimaCameraToolStripMenuItem
			// 
			this.UniqueFeimaCameraToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.一对一;
			this.UniqueFeimaCameraToolStripMenuItem.Name = "UniqueFeimaCameraToolStripMenuItem";
			this.UniqueFeimaCameraToolStripMenuItem.Size = new System.Drawing.Size(354, 34);
			this.UniqueFeimaCameraToolStripMenuItem.Text = "飞马无人机照片唯一化处理";
			this.UniqueFeimaCameraToolStripMenuItem.Click += new System.EventHandler(this.UniqueFeimaCameraToolStripMenuItem_Click);
			// 
			// 帮助ToolStripMenuItem
			// 
			this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem,
            this.HelpToolStripMenuItem});
			this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
			this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
			this.帮助ToolStripMenuItem.Text = "帮助";
			// 
			// AboutToolStripMenuItem
			// 
			this.AboutToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.关于;
			this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
			this.AboutToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
			this.AboutToolStripMenuItem.Text = "关于";
			this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
			// 
			// HelpToolStripMenuItem
			// 
			this.HelpToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.帮助;
			this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
			this.HelpToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
			this.HelpToolStripMenuItem.Text = "查看帮助";
			this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point(0, 32);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.treeView);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.gMapControl);
			this.splitContainer.Size = new System.Drawing.Size(1539, 753);
			this.splitContainer.SplitterDistance = 211;
			this.splitContainer.TabIndex = 2;
			// 
			// treeView
			// 
			this.treeView.ContextMenuStrip = this.kmlContextMenuStrip;
			this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView.Location = new System.Drawing.Point(0, 0);
			this.treeView.Name = "treeView";
			this.treeView.Size = new System.Drawing.Size(211, 753);
			this.treeView.TabIndex = 0;
			// 
			// kmlContextMenuStrip
			// 
			this.kmlContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.kmlContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveKmlToolStripMenuItem,
            this.SaveKmlCheckedToolStripMenuItem,
            this.ExportImageToolStripMenuItem,
            this.DeleteLayerToolStripMenuItem,
            this.ToDxfToolStripMenuItem,
            this.ZoomToLayerToolStripMenuItem});
			this.kmlContextMenuStrip.Name = "kmlContextMenuStrip";
			this.kmlContextMenuStrip.Size = new System.Drawing.Size(265, 196);
			// 
			// SaveKmlToolStripMenuItem
			// 
			this.SaveKmlToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.保存;
			this.SaveKmlToolStripMenuItem.Name = "SaveKmlToolStripMenuItem";
			this.SaveKmlToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
			this.SaveKmlToolStripMenuItem.Text = "另存为kml";
			this.SaveKmlToolStripMenuItem.Click += new System.EventHandler(this.SaveKmlToolStripMenuItem_Click);
			// 
			// SaveKmlCheckedToolStripMenuItem
			// 
			this.SaveKmlCheckedToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.保存;
			this.SaveKmlCheckedToolStripMenuItem.Name = "SaveKmlCheckedToolStripMenuItem";
			this.SaveKmlCheckedToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
			this.SaveKmlCheckedToolStripMenuItem.Text = "另存为kml（被勾选）";
			this.SaveKmlCheckedToolStripMenuItem.Click += new System.EventHandler(this.SaveKmlCheckedToolStripMenuItem_Click);
			// 
			// ExportImageToolStripMenuItem
			// 
			this.ExportImageToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.图片;
			this.ExportImageToolStripMenuItem.Name = "ExportImageToolStripMenuItem";
			this.ExportImageToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
			this.ExportImageToolStripMenuItem.Text = "导出范围内图片";
			this.ExportImageToolStripMenuItem.Click += new System.EventHandler(this.ExportImageToolStripMenuItem_Click);
			// 
			// DeleteLayerToolStripMenuItem
			// 
			this.DeleteLayerToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.删除;
			this.DeleteLayerToolStripMenuItem.Name = "DeleteLayerToolStripMenuItem";
			this.DeleteLayerToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
			this.DeleteLayerToolStripMenuItem.Text = "删除图层";
			this.DeleteLayerToolStripMenuItem.Click += new System.EventHandler(this.DeleteLayerToolStripMenuItem_Click);
			// 
			// ToDxfToolStripMenuItem
			// 
			this.ToDxfToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.dxf文件;
			this.ToDxfToolStripMenuItem.Name = "ToDxfToolStripMenuItem";
			this.ToDxfToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
			this.ToDxfToolStripMenuItem.Text = "转换为dxf";
			this.ToDxfToolStripMenuItem.Click += new System.EventHandler(this.ToDxfToolStripMenuItem_Click);
			// 
			// ZoomToLayerToolStripMenuItem
			// 
			this.ZoomToLayerToolStripMenuItem.Image = global::GIS_Toolbox.Properties.Resources.缩放;
			this.ZoomToLayerToolStripMenuItem.Name = "ZoomToLayerToolStripMenuItem";
			this.ZoomToLayerToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
			this.ZoomToLayerToolStripMenuItem.Text = "缩放至该图层";
			this.ZoomToLayerToolStripMenuItem.Click += new System.EventHandler(this.ZoomToLayerToolStripMenuItem_Click);
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
			this.gMapControl.Location = new System.Drawing.Point(0, 0);
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
			this.gMapControl.Size = new System.Drawing.Size(1324, 753);
			this.gMapControl.TabIndex = 0;
			this.gMapControl.Zoom = 0D;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1539, 785);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "GIS Toolbox";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.kmlContextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private GMap.NET.WindowsForms.GMapControl gMapControl;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 小工具ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DeleteFilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ExtractColumnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 基于POS显示图片ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem HuaceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DJIToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 切换地图ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem TianDiTuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem TianDiTuImageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem BingImageToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.TreeView treeView;
		private System.Windows.Forms.ContextMenuStrip kmlContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem SaveKmlToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ImportKmlToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ExportImageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DeleteLayerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem LL2KmlToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveKmlCheckedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ImportKmlProToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 画图工具ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MeasureDistanceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DrawPolylineToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DrawPolygonToolStripMenuItem;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private System.Windows.Forms.ToolStripMenuItem ToDxfToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ZoomToLayerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pOSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MakeFeimaPOSPOSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MergePOSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AddDxDyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 整理Lidar数据ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OrganizePix4DmapperToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SplitFeimaCameraToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem UniqueFeimaCameraToolStripMenuItem;
	}
}

