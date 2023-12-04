using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;
using System.Windows.Forms;

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

        public void GetLocation()
        {
            GeoCoordinateWatcher geo = new GeoCoordinateWatcher();

            geo.TryStart(false,TimeSpan.FromMilliseconds(1000));

            GeoCoordinate coord = geo.Position.Location;

            if (!coord.IsUnknown)
            {
                MessageBox.Show($"Lat: {coord.Latitude}, Long: {coord.Longitude}");
            }

            else 
            {
                //MessageBox.Show("Unknown Data");
                MessageBox.Show($"Lat: {coord.Latitude}, Long: {coord.Longitude}");
            }
        }
    }
}
