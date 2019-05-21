﻿using FinalProject_2019.Pages;
using FinalProject_2019.TabsContent;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject_2019 {
    public partial class AdminPage : Form {

        private bool mouseDown = false;
        private Point lastLocation;

        public AdminPage() {
            InitializeComponent();

            employees_Click(null, null);
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
            EmployeesTab m = new EmployeesTab();
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
