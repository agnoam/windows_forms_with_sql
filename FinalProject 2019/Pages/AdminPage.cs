using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject_2019 {
    public partial class AdminPage : Form {

        private bool mouseDown = false;
        private Point lastLocation;
        private PanelSelector selector = PanelSelector.employees;


        public AdminPage() {
            InitializeComponent();

            DatabaseConnector.read();
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

        private void employees_Click(object sender, EventArgs e) {
            // Moving the buttonSelector
            ButtonSelector.Top = employees.Top;
            ButtonSelector.Height = employees.Height;

            // Show the employees Panel
            Console.WriteLine("employees Showing");
            //employeesContentPanel.Show();

            HidePanel();
            selector = PanelSelector.employees;
        }

        private void ManageATMs_Click(object sender, EventArgs e) {
            // Moving the buttonSelector
            ButtonSelector.Top = ManageATMs.Top;
            ButtonSelector.Height = ManageATMs.Height;

            // Show the ATMsContent Panel
            Console.WriteLine("ATMs Showing");
            //employees employeesView = new employees();
            // employeesView.TopLevel = false;
            Controls.Clear();
            //Controls.Add(employeesView);
            //employeesView.Show();

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
                case PanelSelector.employees:
                    Console.WriteLine("employees Hidden");

                    //employeesContentPanel.Hide();
                    employees.Hide();
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
    employees,
    ATMS,
    ROUTES
}
