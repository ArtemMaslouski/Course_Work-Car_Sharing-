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
using System.Security.Cryptography;
using System.Device.Location;

namespace CarSharing
{
    public class Map
    {
        GMapOverlay poligon = new GMapOverlay("Полигоны Минска");
        GMapOverlay cars = new GMapOverlay("Автомобили");
        public  void GetMap(GMap.NET.WindowsForms.GMapControl gMap)
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

            List<PointLatLng> minskPoints = new List<PointLatLng>();
            string[] MinskCoordinates = File.ReadAllLines("C:\\Users\\maslo\\OneDrive\\Рабочий стол\\Учёба\\3 курс\\1 семестр\\Курсовой проект(Конструирование программного обеспечения)\\CarSharing\\PolygonCoordinates\\Minsk.txt");

            for (int i = 0; i < MinskCoordinates.Length; i++)
            {
                string[] coordinates = MinskCoordinates[i].Replace(".", ",").Split(';');
                minskPoints.Add(new PointLatLng(Convert.ToDouble(coordinates[0]), Convert.ToDouble(coordinates[1])));
            }
            var southWestpolygon = new GMapPolygon(minskPoints, "Minsk Poligon");
            southWestpolygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Turquoise));
            southWestpolygon.Stroke = new Pen(Color.Turquoise);


            //Парк Уго-Чавеса
            List<PointLatLng> UgoPark = new List<PointLatLng>();

            string[] UgoCoordinates = File.ReadAllLines("C:\\Users\\maslo\\OneDrive\\Рабочий стол\\Учёба\\3 курс\\1 семестр\\Курсовой проект(Конструирование программного обеспечения)\\CarSharing\\PolygonCoordinates\\Ugo.txt");

            for (int i = 0; i < UgoCoordinates.Length; i++)
            {
                string[] coordinates = UgoCoordinates[i].Replace(".",",").Split(';');
                UgoPark.Add(new PointLatLng(Convert.ToDouble(coordinates[0]), Convert.ToDouble(coordinates[1])));
            }
            var Ugopolygon = new GMapPolygon(UgoPark, "UgoPark");
            Ugopolygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            Ugopolygon.Stroke = new Pen(Color.Red);

            //Парк возле бывшего аэропорта
            List<PointLatLng> AirPark = new List<PointLatLng>();

            string[] AirParkCoordinates = File.ReadAllLines("C:\\Users\\maslo\\OneDrive\\Рабочий стол\\Учёба\\3 курс\\1 семестр\\Курсовой проект(Конструирование программного обеспечения)\\CarSharing\\PolygonCoordinates\\AirPark.txt");
            for (int i = 0; i < AirParkCoordinates.Length; i++)
            {
                string[] coordinates = AirParkCoordinates[i].Replace(".", ",").Split(';');
                AirPark.Add(new PointLatLng(Convert.ToDouble(coordinates[0]), Convert.ToDouble(coordinates[1])));
            }
            var Airpoligon = new GMapPolygon(AirPark, "AirPark");
            Airpoligon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            Airpoligon.Stroke = new Pen(Color.Red);


            //Зеленая зона возле Дроздов и Новинок
            List<PointLatLng> north = new List<PointLatLng>();

            string[] NorthCoordinates = File.ReadAllLines("C:\\Users\\maslo\\OneDrive\\Рабочий стол\\Учёба\\3 курс\\1 семестр\\Курсовой проект(Конструирование программного обеспечения)\\CarSharing\\PolygonCoordinates\\North.txt");
            for (int i = 0; i < NorthCoordinates.Length; i++)
            {
                string[] coordinates = NorthCoordinates[i].Replace(".",",").Split(';');
                north.Add(new PointLatLng(Convert.ToDouble(coordinates[0]), Convert.ToDouble(coordinates[1])));
            }
            var northPoligon = new GMapPolygon(north, "North");
            northPoligon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            northPoligon.Stroke = new Pen(Color.Red);

            //Зеленая зона недалеко от степянки
            List<PointLatLng> stepyanka = new List<PointLatLng>();

            string[] StepyankaCoordinates = File.ReadAllLines("C:\\Users\\maslo\\OneDrive\\Рабочий стол\\Учёба\\3 курс\\1 семестр\\Курсовой проект(Конструирование программного обеспечения)\\CarSharing\\PolygonCoordinates\\Stepyanka.txt");
            for (int i = 0; i < StepyankaCoordinates.Length; i++)
            {
                string[] coordinates = StepyankaCoordinates[i].Replace(".", ",").Split(';');
                stepyanka.Add(new PointLatLng(Convert.ToDouble(coordinates[0]), Convert.ToDouble(coordinates[1])));
            }
            var stepyankaPolygon = new GMapPolygon(stepyanka, "stepyanka");
            stepyankaPolygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            stepyankaPolygon.Stroke = new Pen(Color.Red);


            //Парк в Чижовке
            List<PointLatLng> chizhovka = new List<PointLatLng>();

            string[] ChizhovkaCoordinates = File.ReadAllLines("C:\\Users\\maslo\\OneDrive\\Рабочий стол\\Учёба\\3 курс\\1 семестр\\Курсовой проект(Конструирование программного обеспечения)\\CarSharing\\PolygonCoordinates\\Chizhovka.txt");
            for (int i = 0; i < ChizhovkaCoordinates.Length; i++)
            {
                string[] coordinates = ChizhovkaCoordinates[i].Replace(".",",").Split(';');
                chizhovka.Add(new PointLatLng(Convert.ToDouble(coordinates[0]), Convert.ToDouble(coordinates[1])));
            }
            var chizhovkaPolygon = new GMapPolygon(chizhovka, "chizhovka");
            chizhovkaPolygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            chizhovkaPolygon.Stroke = new Pen(Color.Red);



            //Парк тивали
            List<PointLatLng> tivali = new List<PointLatLng>();

            string[] TivaliCoordinates = File.ReadAllLines("C:\\Users\\maslo\\OneDrive\\Рабочий стол\\Учёба\\3 курс\\1 семестр\\Курсовой проект(Конструирование программного обеспечения)\\CarSharing\\PolygonCoordinates\\Tivali.txt");
            for (int i = 0; i < TivaliCoordinates.Length; i++)
            {
                string[] coordinates = TivaliCoordinates[i].Replace(".", ",").Split(';');
                tivali.Add(new PointLatLng(Convert.ToDouble(coordinates[0]), Convert.ToDouble(coordinates[1])));
            }
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

            string[] CoordinatesInFile = File.ReadAllLines("C:\\Users\\maslo\\OneDrive\\Рабочий стол\\Учёба\\3 курс\\1 семестр\\Курсовой проект(Конструирование программного обеспечения)\\CarSharing\\CarInformation\\CarCoordinates.txt");
            for (int i = 0; i < CoordinatesInFile.Length; i++)
            {
                string[] Coordinates = CoordinatesInFile[i].Split(new char[] { ';' });
                carsCoordinate.Add(new Point(Convert.ToDouble(Coordinates[0]), Convert.ToDouble(Coordinates[1])));
            }

            string[] CarInfo = File.ReadAllLines("C:\\Users\\maslo\\OneDrive\\Рабочий стол\\Учёба\\3 курс\\1 семестр\\Курсовой проект(Конструирование программного обеспечения)\\CarSharing\\CarInformation\\CarInfo.txt");
            for (int i = 0; i < carsCoordinate.Count; i++)
            {
                string[] Info = CarInfo[i].Split(' ');
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(carsCoordinate[i].X, carsCoordinate[i].Y), new Bitmap("C:\\Users\\maslo\\OneDrive\\Рабочий стол\\Учёба\\3 курс\\1 семестр\\Курсовой проект(Конструирование программного обеспечения)\\CarSharing\\Images\\Car.png"));
                marker.ToolTip = new GMapRoundedToolTip(marker);

                marker.ToolTipText = "Марка: " + Info[0] + " \n" +  "Модель: "+ Info[1] + " \n" + "Год: " + Info[2] + " \n" +  "Объём: " + Info[3] + " " ;
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

                List<string> coordinates = Convertion(lat,lng); 
                X.Text = coordinates[0];
                Y.Text = coordinates[1];
            }
        }

        public List<string> Convertion(double lat,double lng)
        {
            string latitude = Convert.ToString(lat);
            string longitude = Convert.ToString(lng);

            List<string> coordinates = new List<string>();

            coordinates.Add(latitude);
            coordinates.Add(longitude);

            return coordinates;
        }

        public void ShowMarkerCoordinates(GMap.NET.WindowsForms.GMapControl gMap, GMapMarker item, TextBox X, TextBox Y,TextBox Mark,TextBox Model,TextBox Year,TextBox Capacity,Label km)
        {
            Point point = new Point();

            List<double> coordinates = point.GetMyLocation(gMap);

            Mark.Clear();
            Model.Clear();
            Year.Clear();
            Capacity.Clear();

            X.Text = item.Position.Lat.ToString();
            Y.Text = item.Position.Lng.ToString();

            GeoCoordinate MyLocation = new GeoCoordinate(coordinates[0], coordinates[1]);
            GeoCoordinate currentCar = new GeoCoordinate(Convert.ToDouble(X.Text),Convert.ToDouble(Y.Text));

            double distance = Math.Ceiling(MyLocation.GetDistanceTo(currentCar)) / 1000;

            km.Text = GetString(distance);


            string[] Info = item.ToolTipText.Replace(";","").Split(' ');
            if (Info.Length > 2)
            {
                Mark.Text = Info[1];
                Model.Text = Info[3];
                Year.Text = Info[5];
                Capacity.Text = Info[7];
            }
            

        }

        public string GetString(double kilometers)
        {
            return kilometers.ToString() + "Км";
        }

        public void ReservationOfCar(TextBox X, TextBox Y, GMap.NET.WindowsForms.GMapControl gMap,DataGridView view, TextBox Mark, TextBox Model, TextBox Year, TextBox Capacity)
        {
            
            Mark.Clear();
            Model.Clear();
            Year.Clear();
            Capacity.Clear();

            double lat = Convert.ToDouble(X.Text);
            double lng = Convert.ToDouble(Y.Text);
            if (lat != null && lng != null)
            {
                DataTable table = new DataTable();
                table.Columns.Add("Марка");
                table.Columns.Add("Модель");
                table.Columns.Add("Год");
                table.Columns.Add("Объём");

                string path = "C:\\Users\\maslo\\OneDrive\\Рабочий стол\\Учёба\\3 курс\\1 семестр\\Курсовой проект(Конструирование программного обеспечения)\\CarSharing\\CarInformation\\CarCoordinates.txt";
                string coordinates = $"{lat};{lng}";

                if (cars != null)
                {
                    GMapMarker markerToRemove = cars.Markers.FirstOrDefault(m => m.Position.Lat == lat && m.Position.Lng == lng);

                    if (markerToRemove != null)
                    {
                        if (markerToRemove.ToolTipText != "Моё местоположение")
                        {
                            cars.Markers.Remove(markerToRemove);
                            var lines = File.ReadAllLines(path).Where(l => l != coordinates).ToArray();
                            File.WriteAllLines(path, lines);


                            string[] newRow = markerToRemove.ToolTipText.Replace(";", "").Split(' ');
                            table.Rows.Add(newRow[1], newRow[3], newRow[5], newRow[7]);

                            view.DataSource = table;
                            MessageBox.Show("Автомобиль был успешно забронирован!", "Внимание!");
                            X.Clear();
                            Y.Clear();
                        }


                    }
                }
                else
                {
                    MessageBox.Show("Выберите маркер!");
                }
            }

            else 
            {
                MessageBox.Show("Выберите метку!","Внимание!");
            }
            
        }

        public void ReturnAuto(GMap.NET.WindowsForms.GMapControl gMap, TextBox X, TextBox Y,TextBox Mark,TextBox Model,TextBox Year,TextBox Capacity,DataGridView view)
        {
            if (X.Text != "" && Y.Text != "")
            {
                gMap.Overlays.Add(cars);

                double latitude = Convert.ToDouble(X.Text);
                double longitude = Convert.ToDouble(Y.Text);

                if (PointInPoligon(gMap, X, Y))
                {
                    MessageBox.Show("В данном месте автомобиль оставлять запрещено!", "Внимание");
                }
                else 
                {
                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(latitude, longitude),new Bitmap("C:\\Users\\maslo\\OneDrive\\Рабочий стол\\Учёба\\3 курс\\1 семестр\\Курсовой проект(Конструирование программного обеспечения)\\CarSharing\\Images\\Car.png"));
                    marker.ToolTip = new GMapRoundedToolTip(marker);

                    string infoFromDGV = "";

                    for (int i = 0; i < view.ColumnCount; i++)
                    {
                        infoFromDGV += view[i, 0].Value.ToString() + " ";
                    }

                    string[] info = infoFromDGV.Split(' ');

                    marker.ToolTipText = "Марка: " + info[0] + " \n" + "Модель: " + info[1] + " \n" + "Год: " + info[2] + " \n" + "Объём: " + info[3] + " ";

                    cars.Markers.Add(marker);

                    string path = "C:\\Users\\maslo\\OneDrive\\Рабочий стол\\Учёба\\3 курс\\1 семестр\\Курсовой проект(Конструирование программного обеспечения)\\CarSharing\\CarInformation\\CarCoordinates.txt";
                    string text = $"{latitude};{longitude}";

                    using (StreamWriter wr = new StreamWriter(path))
                    {
                        wr.WriteLine(text);
                    }

                    for (int i = 0; i < view.Rows.Count; i++)
                    {
                        view.Rows.Remove(view.Rows[0]);
                    }
                }

                
               
            }
            else
            {
                MessageBox.Show("Проверьте наличие забронированной машины или выбранных координат","Внимание");
            }
            
        }


        public bool PointInPoligon(GMap.NET.WindowsForms.GMapControl gMap,TextBox X,TextBox Y)
        {
            gMap.Overlays.Add(poligon);

            if (X.Text != "" && Y.Text != "")
            {
                double x = Convert.ToDouble(X.Text);
                double y = Convert.ToDouble(Y.Text);

                PointLatLng point = new PointLatLng(x, y);

                var overlays = gMap.Overlays;
                foreach (var overlay in overlays)
                {
                    var poligons = overlay.Polygons;
                    foreach (var polygon in poligons)
                    {
                        if (polygon.Name != "Minsk Poligon")
                        {
                            if (polygon.IsInside(point))
                            {
                                return true;
                            }
                            else
                            {
                                continue;
                                
                            }
                        }
                        else 
                        {
                            continue;
                        }
                    }
                }

            }
            return false;
        }
    }
}
