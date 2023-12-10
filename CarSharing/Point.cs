using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
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

        public void GetMyLocation(GMap.NET.WindowsForms.GMapControl gMap)
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

                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(Latitude, Longitude), new Bitmap("C:\\Users\\maslo\\OneDrive\\Рабочий стол\\Учёба\\3 курс\\1 семестр\\Курсовой проект(Конструирование программного обеспечения)\\CarSharing\\MyDestination.png"));
                    marker.ToolTipText = "Моё местоположение";
                    marker.Size = new Size(100,100);

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
