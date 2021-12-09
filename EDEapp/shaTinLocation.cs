using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace EDEapp
{
    public partial class shaTinLocation : Form
    {
        public shaTinLocation()
        {
            InitializeComponent();
        }

        private void shaTinLocation_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyBkKwrbXytJmrKgMNFQCeS38-fbR9VWYzo";
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(22.3907199, 114.1970226);
            map.MinZoom = 5;
            map.MaxZoom = 50;
            map.Zoom = 17;
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
