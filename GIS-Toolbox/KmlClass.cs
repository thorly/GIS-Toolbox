using GMap.NET.WindowsForms.Markers;
using LiteDB;
using System.Drawing;

namespace GIS_Toolbox
{
	public class KmlClass
	{
		[BsonId]
		public int Id { get; set; }
		public string KmlPath { get; set; }
		public string OverlayId { get; set; }
		public string NodeText { get; set; }
		public GMarkerGoogleType MarkerType { get; set; }
		public Color Color { get; set; }

		public bool ShowToolTip { get; set; }
	}
}
