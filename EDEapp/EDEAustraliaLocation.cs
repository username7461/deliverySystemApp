using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Windows.Forms;

namespace EDEapp
{
    public partial class EDEAustraliaLocation : Form
    {
        public EDEAustraliaLocation()
        {
            InitializeComponent();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void EDEAustraliaLocation_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyBkKwrbXytJmrKgMNFQCeS38-fbR9VWYzo";
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(-35.3330928, 149.1770918);
            map.MinZoom = 5;
            map.MaxZoom = 50;
            map.Zoom = 17;
        }
    }
}
