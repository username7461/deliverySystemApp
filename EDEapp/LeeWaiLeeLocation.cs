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
    public partial class LeeWaiLeeLocation : Form
    {
        GMapOverlay mapOverlay;
        public LeeWaiLeeLocation()
        {
            InitializeComponent();
        }

        private void LeeWaiLeeLocation_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyBkKwrbXytJmrKgMNFQCeS38-fbR9VWYzo";
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(22.305467,114.252778);
            map.MinZoom = 5;
            map.MaxZoom = 50;
            map.Zoom = 16;

            //PointLatLng point = new PointLatLng();
            //GMapMarker marker = new GMarkerGoogle(point,GMarkerGoogleType.red_pushpin);

            //GMapOverlay markers = new GMapOverlay("markers");

           // markers.Markers.Add(marker);

           // map.Overlays.Add(markers);

        }
    }
}
