using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.Projections;

namespace GIS_Toolbox
{
	public abstract class MapProviderBase : GMapProvider
	{
		public MapProviderBase()
		{
			MaxZoom = null;
			RefererUrl = "https://www.tianditu.gov.cn";
		}

		public override PureProjection Projection
		{
			get { return MercatorProjection.Instance; }
		}

		GMapProvider[] overlays;
		public override GMapProvider[] Overlays
		{
			get
			{
				if (overlays == null)
				{
					overlays = new GMapProvider[] { this };
				}
				return overlays;
			}
		}
	}
}
