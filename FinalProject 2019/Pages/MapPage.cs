using Google.Maps;
using Google.Maps.StaticMaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalProject_2019.Pages {
    public partial class MapPage : Form {
        private const string gMapsAPIKey = "";
        private bool mouseDown;
        private Point lastLocation;

        public MapPage() {
            InitializeComponent();
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
            // Always need to use YOUR_API_KEY for requests.  Do this in App_Start.
            GoogleSigned.AssignAllServices(new GoogleSigned(gMapsAPIKey));
            var map = new StaticMapRequest();
            map.Center = new Location("1600 Pennsylvania Ave NW, Washington, DC 20500");
            // map.Size = new System.Drawing.Size(400, 400);
            map.Zoom = 14;
        }
    }
}
