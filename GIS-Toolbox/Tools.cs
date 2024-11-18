using GMap.NET.WindowsForms;
using GMap.NET;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;
using System;
using Placemark = SharpKml.Dom.Placemark;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Text;
using GMap.NET.WindowsForms.Markers;
using System.Drawing;

namespace GIS_Toolbox
{
	public class Tools
	{
		/// <summary>
		/// 度分秒转十进制度
		/// </summary>
		/// <param name="value">度分秒</param>
		/// <returns>十进制度</returns>
		public static double DMSToDecimalDegree(string value)
		{
			string valueNoSpace = value.Replace(" ", "").Replace('″', '"').Replace("′", "'");

			double decimalDegree = 0.0;
			// 度
			int d = valueNoSpace.IndexOf('°');
			if (d < 0)
			{
				return decimalDegree;
			}
			string degree = valueNoSpace.Substring(0, d);
			decimalDegree += Convert.ToDouble(degree);

			// 分
			int m = valueNoSpace.IndexOf("'");
			if (m < 0)
			{
				return decimalDegree;
			}
			string minute = valueNoSpace.Substring(d + 1, m - d - 1);
			decimalDegree += ((Convert.ToDouble(minute)) / 60);

			// 秒
			int s = valueNoSpace.IndexOf('"');
			if (s < 0)
			{
				return decimalDegree;
			}
			string second = valueNoSpace.Substring(m + 1, s - m - 1);
			decimalDegree += (Convert.ToDouble(second) / 3600);

			return decimalDegree;
		}

		/// <summary>
		/// 十进制度转弧度
		/// </summary>
		/// <param name="degree"></param>
		/// <returns></returns>
		public static double DecimalDegree2RAD(double degree)
		{
			return degree * Math.PI / 180.0;
		}

		/// <summary>
		/// 弧度转十进制度
		/// </summary>
		/// <param name="rad"></param>
		/// <returns></returns>
		public static double RAD2DecimalDegree(double rad)
		{
			return rad * 180.0 / Math.PI;
		}

		/// <summary>
		/// 保存kml文件
		/// </summary>
		/// <param name="mapOverlay">图层</param>
		/// <param name="filename">输出kml文件</param>
		public static void SaveKmlFile(GMapOverlay mapOverlay, string filename)
		{
			//创建kml文件
			Kml root = new Kml();
			Document document = new Document();

			if (mapOverlay.Markers.Count > 0)
			{
				foreach (GMapMarker marker in mapOverlay.Markers)
				{
					Placemark feature = new Placemark();
					SharpKml.Dom.Point point = new SharpKml.Dom.Point
					{
						Coordinate = new Vector(marker.Position.Lat, marker.Position.Lng)
					};
					feature.Geometry = point;
					feature.Name = marker.ToolTipText;
					document.AddFeature(feature);
				}
			}

			if (mapOverlay.Routes.Count > 0)
			{
				foreach (GMapRoute route in mapOverlay.Routes)
				{
					Placemark feature = new Placemark
					{
						Name = route.Name,
					};
					LineString str = new LineString
					{
						Coordinates = new CoordinateCollection()
					};
					foreach (PointLatLng lng in route.Points)
					{
						str.Coordinates.Add(new Vector(lng.Lat, lng.Lng));
					}
					feature.Geometry = str;
					document.AddFeature(feature);
				}
			}

			if (mapOverlay.Polygons.Count > 0)
			{
				foreach (GMapPolygon polygonIn in mapOverlay.Polygons)
				{
					Placemark feature = new Placemark();
					feature.Name = polygonIn.Name;

					SharpKml.Dom.Polygon polygon2 = new SharpKml.Dom.Polygon
					{
						OuterBoundary = new OuterBoundary()
					};
					polygon2.OuterBoundary.LinearRing = new LinearRing();
					polygon2.OuterBoundary.LinearRing.Coordinates = new CoordinateCollection();
					foreach (PointLatLng lng in polygonIn.Points)
					{
						polygon2.OuterBoundary.LinearRing.Coordinates.Add(new Vector(lng.Lat, lng.Lng));
					}
					feature.Geometry = polygon2;
					document.AddFeature(feature);
				}
			}

			root.Feature = document;
			KmlFile.Create(root, false).Save(filename);
		}

		/// <summary>
		/// 添加子节点
		/// </summary>
		/// <param name="parentNode">父节点</param>
		/// <param name="nodeName"></param>
		/// <param name="nodeText"></param>
		public static void addChildNode(TreeNode parentNode, string nodeName, string nodeText)
		{
			TreeNode childNode = new TreeNode(nodeName)
			{
				Tag = nodeName,
				Text = nodeText,
				Checked = true,
				Name = nodeName
			};

			parentNode.Nodes.Add(childNode);
			parentNode.ExpandAll();
		}

		/// <summary>
		/// 通过名称获取文件夹路径
		/// </summary>
		/// <param name="path"></param>
		/// <param name="name"></param>
		/// <returns></returns>
		public static List<string> GetDirectoryByName(string path, string name)
		{
			List<string> directorys = new List<string>();

			foreach (string directory in Directory.GetDirectories(path, "*", SearchOption.AllDirectories))
			{
				if (Path.GetFileName(directory) == name)
				{
					directorys.Add(directory);
				}
			}

			return directorys;
		}

		/// <summary>
		/// 合并POS文件
		/// </summary>
		/// <param name="originalPOS"></param>
		/// <param name="mergedPOS"></param>
		/// <param name="firstLine"></param>
		public static void MergePOS(List<string> originalPOS, string mergedPOS, bool skipFirstLine)
		{
			FileInfo outputFile = new FileInfo(mergedPOS);
			StreamWriter sw = outputFile.CreateText();

			foreach (string file in originalPOS)
			{
				if (File.Exists(file))
				{
					string[] lines = File.ReadAllLines(file, Encoding.ASCII);

					for (int i = 0; i < lines.Length; i++)
					{
						if (skipFirstLine && i == 0)
						{
							continue;
						}
						else
						{
							sw.WriteLine(lines[i]);
						}
					}
				}
				else
				{
					Console.WriteLine($"cannnot find {file}");
				}

			}

			sw.Close();
		}

		/// <summary>
		/// 使用图片名查找POS
		/// </summary>
		/// <param name="posFile"></param>
		/// <param name="picName"></param>
		/// <returns></returns>
		public static string GetPosUsingName(string posFile, string picName)
		{
			string pos = null;

			string[] lines = File.ReadAllLines(posFile, Encoding.ASCII);
			foreach (string line in lines)
			{
				if (line.StartsWith(picName))
				{
					pos = line;
				}
			}

			return pos;
		}

		/// <summary>
		/// 经纬度坐标转2000平面坐标（高斯投影）
		/// </summary>
		/// <param name="B">纬度</param>
		/// <param name="L">经度</param>
		/// <param name="X">北坐标</param>
		/// <param name="Y">东坐标</param>
		public static void BL2XY(double B, double L, out double X, out double Y)
		{
			//2000椭球参数
			double aa = 6378137.000000;
			double af = 298.257222101;

			double ll, C, A, v, M, bb, e;
			double e1, T;

			//中央子午线
			double L0 = 3 * (int)(Math.Round(L / 3, MidpointRounding.AwayFromZero));

			B = DecimalDegree2RAD(B);
			L = DecimalDegree2RAD(L);
			L0 = DecimalDegree2RAD(L0);

			double X0 = 0.0;
			double Y0 = 500000.0;

			ll = L - L0;

			int nSignOfB = 1;
			if (B < 0) nSignOfB = -1;
			B = Math.Abs(B);

			bb = (1 - 1.0 / af) * aa;
			e = Math.Sqrt(1.0 - (bb / aa * bb / aa));
			e1 = Math.Sqrt(aa / bb * aa / bb - 1.0);

			T = Math.Tan(B) * Math.Tan(B);
			C = e * e * Math.Cos(B) * Math.Cos(B) / (1 - e * e);
			A = ll * Math.Cos(B);
			v = aa / Math.Sqrt(1 - e * e * Math.Sin(B) * Math.Sin(B));
			M = aa * ((1 - e * e / 4.0 - (3.0 / 64.0) * Math.Pow(e, 4) - (5.0 / 256.0) * Math.Pow(e, 6)) * B
				- ((3.0 / 8.0) * e * e + (3.0 / 32.0) * Math.Pow(e, 4) + (45.0 / 1024.0) * Math.Pow(e, 6)) * Math.Sin(2 * B)
				+ ((15.0 / 256.0) * Math.Pow(e, 4) + (45.0 / 1024.0) * Math.Pow(e, 6)) * Math.Sin(4 * B)
				- ((35.0 / 3072.0) * Math.Pow(e, 6)) * Math.Sin(6 * B));

			X = (M + v * Math.Tan(B) * (A * A / 2.0 + (5.0 - T + 9.0 * C + 4 * C * C) * A * A * A * A / 24.0
				+ (61.0 - 58.0 * T + T * T + 600.0 * C - 330 * e1 * e1) * A * A * A * A * A * A / 720.0));
			Y = v * (A + (1 - T + C) * A * A * A / 6.0 + (5.0 - 18.0 * T + T * T + 72.0 * C - 58.0 * e1 * e1) * A * A * A * A * A / 120.0);

			X = nSignOfB * X;

			X = X + X0;
			Y = Y + Y0;
		}

		/// <summary>
		/// 2000平面坐标转经纬度坐标（高斯投影）
		/// </summary>
		/// <param name="X">北坐标</param>
		/// <param name="Y">东坐标</param>
		/// <param name="L0">中央子午线</param>
		/// <param name="B">纬度</param>
		/// <param name="L">经度</param>
		public static void XY2BL(double X, double Y, double L0, out double B, out double L)
		{
			//84椭球参数
			double aa = 6378137.000000;
			double af = 298.257223563;

			double bb, e, e1;
			double M1, u1, phi1, T1, C1, v1, p1, D, e2, e12;

			double X0 = 0.0;
			double Y0 = 500000.0;

			X = X - X0;
			Y = Y - Y0;
			B = 0;
			L = 0;

			int nSignOfX = 1;
			if (X < 0)
				nSignOfX = -1;

			X = Math.Abs(X);    //change negative value to positive

			bb = (1 - 1.0 / af) * aa;
			e = Math.Sqrt(1.0 - (bb / aa * bb / aa));  //sqrt(aa*aa-bb*bb)/aa
			e1 = Math.Sqrt(aa / bb * aa / bb - 1.0);

			e2 = 2 / af - 1 / af / af;
			e1 = (1 - Math.Sqrt(1 - e2)) / (1 + Math.Sqrt(1 - e2));
			e12 = e2 / (1 - e2);
			M1 = X;
			u1 = M1 / (aa * (1 - e2 / 4.0 - (3.0 / 64.0) * e2 * e2 - (5.0 / 256.0) * e2 * e2 * e2));
			phi1 = u1 + (1.5 * e1 - (27.0 / 32.0) * e1 * e1 * e1) * Math.Sin(2 * u1) + ((21.0 / 16.0)
				* e1 * e1 - (55.0 / 32.0) * e1 * e1 * e1 * e1) * Math.Sin(4 * u1) + ((151.0 / 96.0)
				* e1 * e1 * e1) * Math.Sin(6 * u1) + ((1097.0 / 512.0) * e1 * e1 * e1 * e1) * Math.Sin(8 * u1);
			T1 = Math.Tan(phi1) * Math.Tan(phi1);
			C1 = e12 * Math.Cos(phi1) * Math.Cos(phi1);
			v1 = aa / Math.Sqrt((1 - e2 * Math.Sin(phi1) * Math.Sin(phi1)));
			p1 = aa * (1 - e2) / Math.Sqrt((1 - e2 * Math.Sin(phi1) * Math.Sin(phi1)) * (1 - e2
				* Math.Sin(phi1) * Math.Sin(phi1)) * (1 - e2 * Math.Sin(phi1) * Math.Sin(phi1)));
			D = Y / v1;

			B = phi1 - (v1 * Math.Tan(phi1) / p1) * (D * D / 2.0 - (5.0 + 3.0 * T1 + 10.0 * C1 - 4.0
				* C1 * C1 - 9.0 * e12) * D * D * D * D / 24.0 + (61 + 90 * T1 + 298 * C1 + 45 * T1
				* T1 - 252 * e12 - 3 * C1 * C1) * D * D * D * D * D * D / 720.0);
			L = (D - (1 + 2.0 * T1 + C1) * D * D * D / 6.0 + (5.0 - 2.0 * C1 + 28.0 * T1 - 3 * C1
				* C1 + 8 * e12 + 24 * T1 * T1) * D * D * D * D * D / 120.0) / Math.Cos(phi1);
			B = nSignOfX * B;

			L0 = DecimalDegree2RAD(L0);
			L = L + L0;

			B = RAD2DecimalDegree(B);
			L = RAD2DecimalDegree(L);
		}

		/// <summary>
		/// 获取多个闭合多边形的Bounding Box
		/// </summary>
		/// <param name="polygons">多边形</param>
		/// <returns>Bounding Box</returns>
		public static GMapPolygon GetBoundingPolygon(List<GMapPolygon> polygons)
		{
			double latMin = polygons[0].Points[0].Lat;
			double latMax = polygons[0].Points[0].Lat;
			double lngMin = polygons[0].Points[0].Lng;
			double lngMax = polygons[0].Points[0].Lng;

			foreach (GMapPolygon polygon in polygons)
			{
				foreach (PointLatLng point in polygon.Points)
				{
					double lat = point.Lat;
					double lng = point.Lng;

					if (lat >= latMax)
					{
						latMax = lat;
					}

					if (lat <= latMin)
					{
						latMin = lat;
					}

					if (lng >= lngMax)
					{
						lngMax = lng;
					}

					if (lng <= lngMin)
					{
						lngMin = lng;
					}
				}
			}

			//BoundingBox四个角点
			PointLatLng pointBL = new PointLatLng(latMin, lngMin);
			PointLatLng pointBR = new PointLatLng(latMin, lngMax);
			PointLatLng pointUL = new PointLatLng(latMax, lngMin);
			PointLatLng pointUR = new PointLatLng(latMax, lngMax);

			List<PointLatLng> boundingPoints = new List<PointLatLng>
			{
				pointBL,
				pointBR,
				pointUR,
				pointUL
			};

			//闭合多边形
			GMapPolygon boundingPolygon = new GMapPolygon(boundingPoints, "boundingPolygon");

			return boundingPolygon;
		}


		public static int FindKeyUsingMarkerType(Dictionary<int, GMarkerGoogleType> markerTypeDict, GMarkerGoogleType makerType)
		{
			int k = 999;

			foreach (int key in markerTypeDict.Keys)
			{
				if (markerTypeDict[key] == makerType)
				{
					k = key;
				}
			}

			return k;
		}

		public static int FindKeyUsingColor(Dictionary<int, Color> lineColorDict, Color color)
		{
			int k = 999;

			foreach (int key in lineColorDict.Keys)
			{
				if (lineColorDict[key] == color)
				{
					k = key;
				}
			}

			return k;
		}
	}
}
