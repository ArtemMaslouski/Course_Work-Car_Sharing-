using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using System.Drawing;
using System.IO;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.Data;

namespace CarSharing
{
    internal class Map
    {
        GMapOverlay cars = new GMapOverlay("Автомобили");
        public void GetMap(GMap.NET.WindowsForms.GMapControl gMap)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gMap.MinZoom = 1;
            gMap.MaxZoom = 20;
            gMap.Zoom = 4;
            gMap.Position = new GMap.NET.PointLatLng(53.896651, 27.555887);
            gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMap.CanDragMap = true;
            gMap.DragButton = MouseButtons.Left;
            gMap.ShowCenter = false;
            gMap.ShowTileGridLines = false;

        }

        public void DrawPolygon(GMap.NET.WindowsForms.GMapControl gMap)
        {
            //Полигон Минска(по МКАД)
            GMapOverlay poligon = new GMapOverlay("Полигоны Минска");

            List<PointLatLng> minskPoints = new List<PointLatLng>();
            
            minskPoints.Add(new PointLatLng(53.849816, 27.436729));
            minskPoints.Add(new PointLatLng(53.867736, 27.423339));
            minskPoints.Add(new PointLatLng(53.894854, 27.409778));
            minskPoints.Add(new PointLatLng(53.904361, 27.407032));
            minskPoints.Add(new PointLatLng(53.930546, 27.420936));
            minskPoints.Add(new PointLatLng(53.963684, 27.464538));
            minskPoints.Add(new PointLatLng(53.967925, 27.495266));
            minskPoints.Add(new PointLatLng(53.971459, 27.588478));
            minskPoints.Add(new PointLatLng(53.954897, 27.640663));
            minskPoints.Add(new PointLatLng(53.940955, 27.673450));
            minskPoints.Add(new PointLatLng(53.897180, 27.690616));
            minskPoints.Add(new PointLatLng(53.876845, 27.696281));
            minskPoints.Add(new PointLatLng(53.839182, 27.660060));
            minskPoints.Add(new PointLatLng(53.833611, 27.643409));
            minskPoints.Add(new PointLatLng(53.832800, 27.554832));
            minskPoints.Add(new PointLatLng(53.842423, 27.469345));
            minskPoints.Add(new PointLatLng(53.849816, 27.436729));

            var southWestpolygon = new GMapPolygon(minskPoints, "Minsk Poligon");
            southWestpolygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Turquoise));
            southWestpolygon.Stroke = new Pen(Color.Turquoise);


            //Парк Уго-Чавеса
            List<PointLatLng> UgoPark = new List<PointLatLng>();

            UgoPark.Add(new PointLatLng(53.923601, 27.420124));
            UgoPark.Add(new PointLatLng(53.921027, 27.437482));
            UgoPark.Add(new PointLatLng(53.916381, 27.436389));
            UgoPark.Add(new PointLatLng(53.917525, 27.416482));
            UgoPark.Add(new PointLatLng(53.923601, 27.420124));

            var Ugopolygon = new GMapPolygon(UgoPark, "UgoPark");
            Ugopolygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            Ugopolygon.Stroke = new Pen(Color.Red);

            //Парк возле бывшего аэропорта
            List<PointLatLng> AirPark = new List<PointLatLng>();

            AirPark.Add(new PointLatLng(53.872635, 27.526660));
            AirPark.Add(new PointLatLng(53.871552, 27.560956));
            AirPark.Add(new PointLatLng(53.854578, 27.556873));
            AirPark.Add(new PointLatLng(53.855541, 27.539521));
            AirPark.Add(new PointLatLng(53.864089, 27.531151));
            AirPark.Add(new PointLatLng(53.872635, 27.526660));

            var Airpoligon = new GMapPolygon(AirPark, "AirPark");
            Airpoligon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            Airpoligon.Stroke = new Pen(Color.Red);


            //Зеленая зона возле Дроздов и Новинок
            List<PointLatLng> north = new List<PointLatLng>();

            north.Add(new PointLatLng(53.943407, 27.438773));
            north.Add(new PointLatLng(53.964013, 27.465208));
            north.Add(new PointLatLng(53.970577, 27.569235));
            north.Add(new PointLatLng(53.967043, 27.570437));
            north.Add(new PointLatLng(53.962802, 27.595671));
            north.Add(new PointLatLng(53.947650, 27.579535));
            north.Add(new PointLatLng(53.940578, 27.555502));
            north.Add(new PointLatLng(53.936738, 27.527693));
            north.Add(new PointLatLng(53.919960, 27.546748));
            north.Add(new PointLatLng(53.915612, 27.538336));
            north.Add(new PointLatLng(53.930573, 27.513789));
            north.Add(new PointLatLng(53.942700, 27.490958));
            north.Add(new PointLatLng(53.945986, 27.474336));
            north.Add(new PointLatLng(53.944066, 27.459058));
            north.Add(new PointLatLng(53.943407, 27.438773));


            var northPoligon = new GMapPolygon(north, "North");
            northPoligon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            northPoligon.Stroke = new Pen(Color.Red);

            //Зеленая зона недалеко от степянки
            List<PointLatLng> stepyanka = new List<PointLatLng>();

            stepyanka.Add(new PointLatLng(53.940195, 27.672743));
            stepyanka.Add(new PointLatLng(53.930821, 27.639060));
            stepyanka.Add(new PointLatLng(53.912188, 27.634365));
            stepyanka.Add(new PointLatLng(53.910384, 27.654779));
            stepyanka.Add(new PointLatLng(53.897636, 27.653758));
            stepyanka.Add(new PointLatLng(53.894027, 27.670089));
            stepyanka.Add(new PointLatLng(53.890658, 27.691728));
            stepyanka.Add(new PointLatLng(53.915434, 27.682950));
            stepyanka.Add(new PointLatLng(53.939955, 27.672335));

            var stepyankaPolygon = new GMapPolygon(stepyanka, "stepyanka");
            stepyankaPolygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            stepyankaPolygon.Stroke = new Pen(Color.Red);



            //Парк в Чижовке
            List<PointLatLng> chizhovka = new List<PointLatLng>();

            chizhovka.Add(new PointLatLng(53.868757, 27.575980));
            chizhovka.Add(new PointLatLng(53.859487, 27.572102));
            chizhovka.Add(new PointLatLng(53.840461, 27.574551));
            chizhovka.Add(new PointLatLng(53.840220, 27.628036));
            chizhovka.Add(new PointLatLng(53.855514, 27.634365));
            chizhovka.Add(new PointLatLng(53.855514, 27.625791));
            chizhovka.Add(new PointLatLng(53.849132, 27.599661));
            chizhovka.Add(new PointLatLng(53.865748, 27.583942));
            chizhovka.Add(new PointLatLng(53.868757, 27.575980));

            var chizhovkaPolygon = new GMapPolygon(chizhovka, "chizhovka");
            chizhovkaPolygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            chizhovkaPolygon.Stroke = new Pen(Color.Red);



            //Парк тивали
            List<PointLatLng> tivali = new List<PointLatLng>();

            tivali.Add(new PointLatLng(53.916094, 27.462676));
            tivali.Add(new PointLatLng(53.893630, 27.462851));
            tivali.Add(new PointLatLng(53.884525, 27.447659));
            tivali.Add(new PointLatLng(53.879415, 27.418476));
            tivali.Add(new PointLatLng(53.864638, 27.426115));
            tivali.Add(new PointLatLng(53.868131, 27.453324));
            tivali.Add(new PointLatLng(53.876126, 27.470661));
            tivali.Add(new PointLatLng(53.883918, 27.473236));
            tivali.Add(new PointLatLng(53.907689, 27.472893));
            tivali.Add(new PointLatLng(53.916094, 27.462676));


            var tivaliPolygon = new GMapPolygon(tivali, "tivali");
            tivaliPolygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            tivaliPolygon.Stroke = new Pen(Color.Red);



            //К основному полигону добавляем дополнительно созданные
            gMap.Overlays.Add(poligon);
            poligon.Polygons.Add(southWestpolygon);
            poligon.Polygons.Add(Ugopolygon);
            poligon.Polygons.Add(Airpoligon);
            poligon.Polygons.Add(northPoligon);
            poligon.Polygons.Add(stepyankaPolygon);
            poligon.Polygons.Add(chizhovkaPolygon);
            poligon.Polygons.Add(tivaliPolygon);
        }

        public void LoadMarker(GMap.NET.WindowsForms.GMapControl gMap)
        {
            List<Point> carsCoordinate = new List<Point>();

            gMap.Overlays.Add(cars);

            string[] CoordinatesInFile = File.ReadAllLines("C:\\Users\\maslo\\OneDrive\\Рабочий стол\\Учёба\\3 курс\\1 семестр\\Курсовой проект(Конструирование программного обеспечения)\\CarSharing\\CarCoordinates.txt");
            for (int i = 0; i < CoordinatesInFile.Length; i++)
            {
                string[] Coordinates = CoordinatesInFile[i].Split(new char[] { ';' });
                carsCoordinate.Add(new Point(Convert.ToDouble(Coordinates[0]), Convert.ToDouble(Coordinates[1])));
            }

            string[] CarInfo = File.ReadAllLines("C:\\Users\\maslo\\OneDrive\\Рабочий стол\\Учёба\\3 курс\\1 семестр\\Курсовой проект(Конструирование программного обеспечения)\\CarSharing\\CarInfo.txt");
            for (int i = 0; i < carsCoordinate.Count; i++)
            {
                string[] Info = CarInfo[i].Split(' ');
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(carsCoordinate[i].X, carsCoordinate[i].Y), GMarkerGoogleType.red_dot);
                marker.ToolTip = new GMapRoundedToolTip(marker);

                marker.ToolTipText = "Марка: " + Info[0] + '\n' +  "Модель: "+ Info[1] + '\n' + "Год: " + Info[2] + '\n' +  "Объём" + Info[3];
                cars.Markers.Add(marker);
            }
        }

        public void GetLocation(GMap.NET.WindowsForms.GMapControl gMap,MouseEventArgs e,TextBox X,TextBox Y)
        {
            if (e.Button == MouseButtons.Right)
            {
                PointLatLng point = gMap.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double lng = point.Lng;
                X.Text = Convert.ToString(lat);
                Y.Text = Convert.ToString(lng);
            }
        }

        public void ShowMarkerCoordinates(GMap.NET.WindowsForms.GMapControl gMap, GMapMarker item, TextBox X, TextBox Y)
        {
            Point point = new Point();

            X.Text = item.Position.Lat.ToString();
            Y.Text = item.Position.Lng.ToString();

        }

        public void ReservationOfCar(TextBox X, TextBox Y, GMap.NET.WindowsForms.GMapControl gMap,DataGridView view)
        {
            double lat = Convert.ToDouble(X.Text);
            double lng = Convert.ToDouble(Y.Text);

            DataTable table = new DataTable();
            table.Columns.Add("Марка");
            table.Columns.Add("Модель");
            table.Columns.Add("Год");
            table.Columns.Add("Объём");


            if (cars != null)
            {
                GMapMarker markerToRemove = cars.Markers.FirstOrDefault(m => m.Position.Lat == lat && m.Position.Lng == lng);

                if (markerToRemove != null)
                {
                    if (markerToRemove.ToolTipText != "Моё местоположение")
                    {
                        cars.Markers.Remove(markerToRemove);

                        string[] newRow = markerToRemove.ToolTipText.Split('\n');
                        table.Rows.Add(newRow[0], newRow[1], newRow[2], newRow[3]);

                        view.DataSource = table;
                        MessageBox.Show("Автомобиль был успешно забронирован!", "Внимание!");
                    }
                    else
                    {
                        MessageBox.Show("Нельзя забронировать моё местоположение!","Внимание!");
                    }
                   

                }
            }
            else
            {
                MessageBox.Show("Выберите маркер!");
            }
        }


    }
}
