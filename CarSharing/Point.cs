using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;
using System.Windows.Forms;
using System.Threading;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.ToolTips;

namespace CarSharing
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double _x, double _y)
        {
            X = _x;
            Y = _y;
        }
        public Point() { }

        public void GetLocation(GMap.NET.WindowsForms.GMapControl gMap)
        {
            bool abort = false;

            GeoCoordinate coord;
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
            GMapOverlay MyLocation = new GMapOverlay("Моё местоположение");
            gMap.Overlays.Add(MyLocation);

            if (watcher.TryStart(false, TimeSpan.FromMilliseconds(3000)))
            {
                DateTime start = DateTime.Now;

                while (watcher.Status != GeoPositionStatus.Ready && !abort)
                {
                    Thread.Sleep(200);
                    if (DateTime.Now.Subtract(start).TotalSeconds > 5)
                    {
                        abort = true;
                    }
                }

                coord = watcher.Position.Location;

                if (!coord.IsUnknown)
                {
                    double Latitude = coord.Latitude;
                    double Longitude = coord.Longitude;
                    MessageBox.Show($"Мое местоположение: {Latitude} -- {Longitude}");
                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(Latitude, Latitude), GMarkerGoogleType.red_dot);

                    marker.ToolTip = new GMapRoundedToolTip(marker);

                    marker.ToolTipText = "Мое местоположение";
                    MyLocation.Markers.Add(marker);

                }
                else
                {
                    throw new Exception("Координаты не числа!");
                }


            }
            else
            {
                throw new Exception("Данные не получены!");
            }
        }
    }
}
