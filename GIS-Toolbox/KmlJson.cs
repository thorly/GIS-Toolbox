namespace GIS_Toolbox
{
	public class KmlJson
	{
		public string kmlPath {  get; set; }
		public string overlayId { get; set; }
		public string nodeText { get; set; }
		public int markerTypeIndex { get; set; }
		public int colorIndex { get; set; }

		public bool showToolTip { get; set; }
	}
}
