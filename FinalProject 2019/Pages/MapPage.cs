using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FinalProject_2019.Resources;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace FinalProject_2019.Pages {
    public partial class MapPage : Form {
        
        private bool mouseDown;
        private Point lastLocation;
        private DatabaseConnector db = new DatabaseConnector();
        private Employee signedEmp = null;
        private Dictionary<string, Track> allTracks = new Dictionary<string, Track>();
        private Track trackToShow;
        private string trackID;

        private GMapOverlay routeOverlay = null;
        private GMapOverlay markersOverlay = null;

        public MapPage() {
            InitializeComponent();
        }

        public MapPage(Employee signedEmp_c) {
            InitializeComponent();

            signedEmp = signedEmp_c;
            allTracks = db.getAllTracksForEmp(signedEmp.id);
        }

        public MapPage(string trackID_c) {
            InitializeComponent();

            trackID = trackID_c;
            trackToShow = db.getTrackByID(trackID);
        }

        private void MapPage_Load(object sender, EventArgs e) {
            loadGoogleMaps();

            if (trackToShow != null) {
                trackIdLabel.Text = $"Track ID: {trackID}";
                numOfPointsLabel.Text = $"Number of points: {trackToShow.atms.Length}";
                drawRoute(trackToShow);

                trackIdLabel.Visible = true;
                numOfPointsLabel.Visible = true;
            }

            if (signedEmp != null) {
                trackIdLabel.Text = $"Hello {signedEmp.name}";
                if(allTracks.Count > 0) {
                    string[] keysArr = allTracks.Keys.ToArray();

                    for (int i = 0; i < allTracks.Keys.Count; i++) {
                        dropdownList.Items.Add($"Track number {keysArr[i]}"); // trackID = keysArr[i]
                    }

                    numOfPointsLabel.Text = "Track selected: ";
                } else {
                    MessageBox.Show($"Hey {signedEmp.name}, You don't register to any track at all. Try again later.");
                    new LoginPage().Show();
                    Close();
                }
            } else {
                dropdownList.Hide();
                trackIdLabel.Visible = false;
                numOfPointsLabel.Visible = false;
            }
        }

        private void closeForm_Click(object sender, EventArgs e) {
            if (signedEmp != null) {
                Application.Exit();
            } else {
                Close();
            }
        }

        private void formBorder_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void formBorder_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDown) {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void formBorder_MouseUp(object sender, MouseEventArgs e) {
            mouseDown = false;
        }

        private void loadGoogleMaps() {
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.OpenStreetMap;
            map.MinZoom = 2;
            map.MaxZoom = 75;
            map.Zoom = 10;
            map.MarkersEnabled = true;
            map.ShowCenter = false;

            double lat = 0.0;
            double lng = 0.0;
            
            map.Position = new PointLatLng(lat, lng);
        }

        private void addMarker(GMapMarker marker, string toolTip) {
            GMapOverlay markersOverlay_i = new GMapOverlay("markersLayer");
            markersOverlay = markersOverlay_i;

            if(!AdditionalFunctions.isEmpty(toolTip)) {
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                marker.ToolTipText = toolTip;
            }

            markersOverlay_i.Markers.Add(marker);
            map.Overlays.Add(markersOverlay); // Adding markers overlay to the map

        }

        private void drawRoute(Track track) {
            GMapOverlay polyOverlay = new GMapOverlay("routeOverlay");
            List<PointLatLng> points = new List<PointLatLng>();
            List<LatLng> pointsToCalc = new List<LatLng>();

            Console.WriteLine("atmLength: " + track.atms.Length);
            for (int i = 0; i < track.atms.Length; i++) {
                Address atmAddr = track.atms[i].address;
                pointsToCalc.Add(new LatLng(atmAddr.lat, atmAddr.lng));
            }

            List<LatLng> sortedPoints = new DatabaseConnector().calcShortestTrack(pointsToCalc);
            for(int i = 0; i < sortedPoints.Count; i++) {
                addMarker(new GMarkerGoogle(sortedPoints[i].toPointLatLng(), GMarkerGoogleType.green), (i+1).ToString());
                points.Add(sortedPoints[i].toPointLatLng());
            }

            if(sortedPoints.Count > 1) {
                GMapPolygon polygon = new GMapPolygon(points, "routePolygon");
                polygon.Fill = new SolidBrush(Color.FromArgb(0, Color.Red));

                polygon.Stroke = new Pen(Color.Red, 5);
                polyOverlay.Polygons.Add(polygon);

                map.Overlays.Add(polyOverlay);
                map.ZoomAndCenterMarkers("markersLayer");

                routeOverlay = polyOverlay;
            } else {
                MessageBox.Show("There is one point with no direction, So you can't show it, wait for track update");
            }
        }

        private void dropdownList_SelectedIndexChanged(object sender, EventArgs e) {
            if(routeOverlay != null) {
                map.Overlays.Remove(routeOverlay);
            }

            if(markersOverlay != null) {
                map.Overlays.Remove(markersOverlay);
            }

            drawRoute(allTracks[dropdownList.Text.Split(' ')[2]]);
        }
    }
}