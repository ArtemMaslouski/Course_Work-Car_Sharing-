using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device.Location;

namespace CarSharing
{
    public partial class MainWindow : Form
    {
        Point point = new Point();
        Map map = new Map();
        GMap_Load GMap;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

            GMap_Load GMap = map.GetMap;


            GMap += map.DrawPolygon;

            GMap += map.LoadMarker;
            GMap.Invoke(gMapControl1);

            point.GetMyLocation(gMapControl1);

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            map.GetLocation(gMapControl1,e,XtextBox,YtextBox);
        }

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            map.ShowMarkerCoordinates(gMapControl1, item, XtextBox, YtextBox,MarktextBox,ModeltextBox,YeartextBox,CapacitytextBox,KmLabel);
        }

        private void ReservationButton_Click_1(object sender, EventArgs e)
        {
            map.ReservationOfCar(XtextBox, YtextBox, gMapControl1,ReservationDataGridView, MarktextBox, ModeltextBox, YeartextBox, CapacitytextBox);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            map.ReturnAuto(gMapControl1,XtextBox,YtextBox,MarktextBox,ModeltextBox,YeartextBox,CapacitytextBox,ReservationDataGridView);

        }

        delegate void GMap_Load(GMap.NET.WindowsForms.GMapControl gMap);

    }
}
