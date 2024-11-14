using DotSpatial.Projections;
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

namespace GIS_Toolbox
{
	public class Tools
	{
		/// <summary>
		/// 3°带中央子午线对应的投影
		/// </summary>
		private readonly static Dictionary<int, ProjectionInfo> projectionInfoDict = new Dictionary<int, ProjectionInfo>()
		{
			{ 75, KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM75E },
			{ 78, KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM78E },
			{ 81, KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM81E },
			{ 84, KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM84E },
			{ 87, KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM87E },
			{ 90, KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM90E },
			{ 93, KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM93E },
			{ 96, KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM96E },
			{ 99, KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM99E },
			{ 102, KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM102E },
			{ 105, KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM105E },
			{ 108, KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM108E },
			{ 111, KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM111E },
			{ 114, KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM114E },
			{ 117, KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM117E },
			{ 120, KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM120E },
			{ 123, KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM123E },
			{ 126, KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM126E },
			{ 129, KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM129E },
			{ 132, KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM132E },
			{ 135, KnownCoordinateSystems.Projected.KrugerXian1980.Xian19803DegreeGKCM135E }
		};

		/// <summary>
		/// CGCS2000平面坐标转经纬度坐标（3°带）
		/// </summary>
		/// <param name="x">北坐标</param>
		/// <param name="y">东坐标</param>
		/// <param name="centerLng">中央子午线</param>
		/// <returns>纬度，经度</returns>
		public static double[] ConvertCGCS2000ToWGS84(double x, double y, int centerLng)
		{
			//定义CGCS2000投影
			ProjectionInfo cgcs2000 = projectionInfoDict[centerLng];

			//定义WGS84地理坐标系
			ProjectionInfo wgs84 = KnownCoordinateSystems.Geographic.World.WGS1984;

			//输入的CGCS2000坐标
			double[] xy = new double[] { x, y };
			double[] z = new double[] { 0 };

			//执行坐标转换
			Reproject.ReprojectPoints(xy, z, cgcs2000, wgs84, 0, 1);

			//返回转换后的经纬度
			return new double[] { xy[1], xy[0] }; // 纬度在前，经度在后
		}

		/// <summary>
		/// 经纬度坐标转CGCS2000平面坐标（3°带）
		/// </summary>
		/// <param name="lat"></param>
		/// <param name="lng"></param>
		/// <returns>东坐标，北坐标</returns>
		public static double[] ConvertWGS84ToCGCS2000(double lat, double lng)
		{
			//定义WGS84地理坐标系
			ProjectionInfo wgs84 = KnownCoordinateSystems.Geographic.World.WGS1984;

			//计算3度带中央子午线
			int centerLng = 3 * (int)(Math.Round(lng / 3, MidpointRounding.AwayFromZero));

            Console.WriteLine(centerLng);

			//定义CGCS2000投影
			ProjectionInfo cgcs2000 = projectionInfoDict[centerLng];

			//输入的WGS84坐标
			double[] lnglat = new double[] { lng, lat };
			double[] z = new double[] { 0 };

			//执行坐标转换
			Reproject.ReprojectPoints(lnglat, z, wgs84, cgcs2000, 0, 1);

			Console.WriteLine(lnglat[0]);
			Console.WriteLine(lnglat[1]);

			//返回转换后的2000坐标
			return new double[] { lnglat[0], lnglat[1] };
		}

		/// <summary>
		/// 度分秒转十进制度
		/// </summary>
		/// <param name="value">度分秒</param>
		/// <returns>十进制度</returns>
		public static double ConvertDMSToDecimalDegree(string value)
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
					Point point = new Point
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
	}
}
