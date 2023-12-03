using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSharing
{
    internal class Polygons
    {
        public void getPoligons()
        {
            GMapOverlay polygons = new GMapOverlay("Polygons");

            List<PointLatLng> points = new List<PointLatLng>();

            points.Add(new PointLatLng(53.864572, 27.427057));
            points.Add(new PointLatLng(53.844839, 27.458564));
            points.Add(new PointLatLng(53.843217, 27.482394));
            points.Add(new PointLatLng(53.858018, 27.503475));
            points.Add(new PointLatLng(53.870787, 27.494080));
            points.Add(new PointLatLng(53.875313, 27.475520));
            points.Add(new PointLatLng(53.871665, 27.461771));
            points.Add(new PointLatLng(53.865585, 27.447679));
            points.Add(new PointLatLng(53.864572, 27.427057));
            points.Add(new PointLatLng());
            points.Add(new PointLatLng());
            points.Add(new PointLatLng());
            points.Add(new PointLatLng());
            points.Add(new PointLatLng());
            points.Add(new PointLatLng());

            points.Add(new PointLatLng());
            points.Add(new PointLatLng());
            points.Add(new PointLatLng());


        }
    }
}
