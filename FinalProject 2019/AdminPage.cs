using FinalProject_2019.AdminPageTabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace FinalProject_2019 {
    public partial class AdminPage : Form {

        private bool mouseDown = false;
        private Point lastLocation;
        private PanelSelector selector = PanelSelector.EMPLOEES;


        public AdminPage() {
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

        private void Emploees_Click(object sender, EventArgs e) {
            // Moving the buttonSelector
            ButtonSelector.Top = Emploees.Top;
            ButtonSelector.Height = Emploees.Height;

            // Show the Emploees Panel
            Console.WriteLine("Emploees Showing");
            //EmploeesContentPanel.Show();

            HidePanel();
            selector = PanelSelector.EMPLOEES;
        }

        private void ManageATMs_Click(object sender, EventArgs e) {
            // Moving the buttonSelector
            ButtonSelector.Top = ManageATMs.Top;
            ButtonSelector.Height = ManageATMs.Height;

            // Show the ATMsContent Panel
            Console.WriteLine("ATMs Showing");
            Emploees emploeesView = new Emploees();
            // emploeesView.TopLevel = false;
            Controls.Clear();
            Controls.Add(emploeesView);
            emploeesView.Show();

            HidePanel();
            selector = PanelSelector.ATMS;
        }

        private void ManageRoutes_Click(object sender, EventArgs e) {
            // Moving the buttonSelector
            ButtonSelector.Top = ManageRoutes.Top;
            ButtonSelector.Height = ManageRoutes.Height;

            // Show the RoutesContent Panel
            Console.WriteLine("Routes Showing");
            //RoutesContentPanel.Show();

            HidePanel();
            selector = PanelSelector.ROUTES;
        }

        private void HidePanel() {
            switch(selector) {
                case PanelSelector.EMPLOEES:
                    Console.WriteLine("Emploees Hidden");

                    //EmploeesContentPanel.Hide();
                    Emploees.Hide();
                    break;

                case PanelSelector.ATMS:
                    Console.WriteLine("ATMs Hidden");

                    //ATMsContentPanel.Hide();
                    break;

                case PanelSelector.ROUTES:
                    Console.WriteLine("Routes Hidden");

                    //RoutesContentPanel.Hide();
                    break;
            }
        }
    }
}

enum PanelSelector {
    EMPLOEES,
    ATMS,
    ROUTES
}
