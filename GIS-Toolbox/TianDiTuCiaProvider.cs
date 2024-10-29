using GMap.NET;
using System;

namespace GIS_Toolbox
{
	public class TianDiTuCiaProvider : MapProviderBase
	{
		public static readonly MapProviderBase Instance;

		readonly Guid id = System.Guid.NewGuid();
		public override Guid Id
		{
			get { return id; }
		}

		readonly string name = "TianDiTuCiaMap";
		public override string Name
		{
			get
			{
				return name;
			}
		}

		static TianDiTuCiaProvider()
		{
			Instance = new TianDiTuCiaProvider();
		}

		public override PureImage GetTileImage(GPoint pos, int zoom)
		{
			string url = MakeTileImageUrl(pos, zoom, LanguageStr);
			return GetTileImageUsingHttp(url);
		}

		string MakeTileImageUrl(GPoint pos, int zoom, string language)
		{
			string url = string.Format(MarkUrlFormat, pos.X, pos.Y, zoom);
			//Console.WriteLine("url:" + url);
			return url;
		}

		static readonly string MarkUrlFormat = "http://t2.tianditu.gov.cn/cia_w/wmts?SERVICE=WMTS&REQUEST=GetTile&VERSION=1.0.0&LAYER=cia&STYLE=default&TILEMATRIXSET=w&FORMAT=tiles&TILEMATRIX={2}&TILEROW={1}&TILECOL={0}&tk=5b2b5392e332e8b50565cbd04378b8d3";
	}
}
