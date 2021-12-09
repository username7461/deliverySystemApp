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
    public partial class ShanghaiLocation : Form
    {
        public ShanghaiLocation()
        {
            InitializeComponent();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void ShanghaiLocation_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyBkKwrbXytJmrKgMNFQCeS38-fbR9VWYzo";
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(31.217708, 121.5388623);
            map.MinZoom = 5;
            map.MaxZoom = 50;
            map.Zoom = 17;
        }

        private void map_Load(object sender, EventArgs e)
        {

        }
    }
}
