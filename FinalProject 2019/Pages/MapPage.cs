using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace FinalProject_2019.Pages {
    public partial class MapPage : Form {
        
        private bool mouseDown;
        private Point lastLocation;

        public MapPage() {
            InitializeComponent();

            loadGoogleMaps();
        }

        private void closeForm_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void formBorder_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void formBorder_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDown) {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void formBorder_MouseUp(object sender, MouseEventArgs e) {
            mouseDown = false;
        }

        private void loadGoogleMaps() {
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.OpenStreetMap;
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 10;
            map.MarkersEnabled = true;

            double lat = 0.0;
            double lng = 0.0;
            
            map.Position = new PointLatLng(lat, lng);
        }

        private void addMarker(GMapMarker marker) {
            GMapOverlay markersOverlay = new GMapOverlay("markersLayer");
            markersOverlay.Markers.Add(marker);

            // Adding markers overlay to the map
            map.Overlays.Add(markersOverlay);
        }

        private void addMark_Click(object sender, EventArgs e) {
            PointLatLng latLng = new PointLatLng(0.0, 0.0);

            addMarker(new GMarkerCross(latLng));
            addMarker(new GMarkerGoogle(latLng, GMarkerGoogleType.orange));
        }
    }
}