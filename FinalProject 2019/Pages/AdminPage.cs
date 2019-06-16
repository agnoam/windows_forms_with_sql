using FinalProject_2019.Pages;
using FinalProject_2019.TabsContent;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject_2019 {
    public partial class AdminPage : Form {

        private bool mouseDown = false;
        private Point lastLocation;

        public AdminPage() {
            InitializeComponent();

            // Select employees tab
            employees_Click(null, null);

            // SqlDate bDate = new SqlDate(1, 1, 1975);
            // Address add = new Address("test", 0, "test", "000000", 0.0, 0.0);
            // Emploeey emp = new Emploeey("000000100", "Jhon p", bDate, "user", "testJhon", "0502123649", Gender.MALE, add);
            // new DatabaseConnector().addNewEmploeey(emp);

            List<LatLng> list = new List<LatLng>();
            list.Add(new LatLng(0.0, -2.0)); // D
            list.Add(new LatLng(0.0, 8.0)); // D
            list.Add(new LatLng(-1.0, 3.0)); // A
            list.Add(new LatLng(4.0, 0.0)); // C
            list.Add(new LatLng(0.0, 7.0)); // D
            list.Add(new LatLng(-2.0, 1.0)); // B
            list.Add(new LatLng(0.0, 5.0)); // D
            list.Add(new LatLng(5.0, 0.0)); // D
            list.Add(new LatLng(6.0, 0.0)); // D
            list.Add(new LatLng(7.0, 0.0)); // D
            

            Console.WriteLine(list.Count);

            List<LatLng> l = new DatabaseConnector().calcShortestTrack(list);
            for(int i = 0; i < l.Count; i++) {
                Console.WriteLine(l[i].ToString());
            }
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
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void formBorder_MouseUp(object sender, MouseEventArgs e) {
            mouseDown = false;
        }

        private void employees_Click(object sender, EventArgs e) {
            // Moving the buttonSelector
            ButtonSelector.Top = employees.Top;
            ButtonSelector.Height = employees.Height;

            // Show the employees Panel
            Console.WriteLine("employees Showing");
            tabControl.SelectedIndex = 0;

            // Hiding all the other tabs avilable
            tabControl.TabPages[1].Hide();
            tabControl.TabPages[2].Hide();

            // Loading tab's content
            // EmployeesTab m = new EmployeesTab(this, 0);
            EmployeesTab m = new EmployeesTab(this, 0);
            m.TopLevel = false;

            // Attching it to the TabPage
            tabControl.TabPages[0].Controls.Add(m);

            // Showing the content
            m.FormBorderStyle = FormBorderStyle.None;
            m.Dock = DockStyle.Fill;
            m.Show();

            tabControl.TabPages[0].Show();
        }

        private void ManageATMs_Click(object sender, EventArgs e) {
            // Moving the buttonSelector
            ButtonSelector.Top = ManageATMs.Top;
            ButtonSelector.Height = ManageATMs.Height;

            // Show the ATMsContent Panel
            Console.WriteLine("ATMs Showing");

            // Hiding all the other tabs avilable
            tabControl.TabPages[0].Hide();
            tabControl.TabPages[2].Hide();

            // Loading tab's content
            // EmployeesTab m = new EmployeesTab(this, 1);
            // m.TopLevel = false;

            // Attching it to the TabPage
            // tabControl.TabPages[1].Controls.Add(m);

            // Showing the content
           // m.FormBorderStyle = FormBorderStyle.None;
            // m.Dock = DockStyle.Fill;
            // m.Show();

            // Displaying the TabPage
            tabControl.TabPages[1].Show();
        }

        private void ManageRoutes_Click(object sender, EventArgs e) {
            // Moving the buttonSelector
            ButtonSelector.Top = ManageRoutes.Top;
            ButtonSelector.Height = ManageRoutes.Height;

            // Show the RoutesContent Panel
            Console.WriteLine("Routes Showing");

            // Hiding all the other tabs avilable
            tabControl.TabPages[0].Hide();
            tabControl.TabPages[1].Hide();

            tabControl.TabPages[2].Show();
        }

        public TabControl getTabControl() {
            return tabControl;
        }
    }
}
