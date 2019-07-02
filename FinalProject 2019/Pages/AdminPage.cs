using FinalProject_2019.Resources;
using FinalProject_2019.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject_2019 {
    public partial class AdminPage : Form {

        private bool mouseDown = false;
        private Point lastLocation;
        private Employee loginedEmp;

        public AdminPage() {
            InitializeComponent();

            // Select employees tab
            employees_Click(null, null);
        }

        public AdminPage(Employee loginedEmp_c) {
            InitializeComponent();

            loginedEmp = loginedEmp_c;

            // Select employees tab
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
            tabControl.TabPages[3].Hide();

            // Loading tab's content
            TabContent m = new TabContent(this, 0, TabChooser.Employees);
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
            tabControl.TabPages[3].Hide();
            
            // Loading tab's content
            TabContent m = new TabContent(this, 1, TabChooser.ATM);
            m.TopLevel = false;

            // Attching it to the TabPage
            tabControl.TabPages[1].Controls.Add(m);

            // Showing the content
            m.FormBorderStyle = FormBorderStyle.None;
            m.Dock = DockStyle.Fill;
            m.Show();

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
            tabControl.TabPages[3].Hide();

            TabContent m = new TabContent(this, 2, TabChooser.Tracks);
            m.TopLevel = false;
            m.FormBorderStyle = FormBorderStyle.None;
            m.Dock = DockStyle.Fill;
            m.Show();

            // Attching it to the TabPage and showing
            tabControl.TabPages[2].Controls.Add(m);
            tabControl.TabPages[2].Show();
        }

        private void ManageCars_Click(object sender, EventArgs e) {
            // Moving the buttonSelector
            ButtonSelector.Top = ManageCars.Top;
            ButtonSelector.Height = ManageCars.Height;

            // Change Tab
            tabControl.TabPages[0].Hide();
            tabControl.TabPages[1].Hide();
            tabControl.TabPages[2].Hide();

            TabContent m = new TabContent(this, 3, TabChooser.Cars);
            m.TopLevel = false;
            m.FormBorderStyle = FormBorderStyle.None;
            m.Dock = DockStyle.Fill;
            m.Show();

            // Attching it to the TabPage and showing
            tabControl.TabPages[3].Controls.Add(m);
            tabControl.TabPages[3].Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e) {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();

            // Closes AdminPage
            Hide();
        }

        public TabControl getTabControl() {
            return tabControl;
        }

        private void WiseAlgBtn_Click(object sender, EventArgs e) {
            DatabaseConnector db = new DatabaseConnector();

            Dictionary<string, int> atms = db.getAllAtms();
            Dictionary<string, DictionaryData> allAtmsWithAVG = new Dictionary<string, DictionaryData>(); // { id: '', { avg: [7 cels], liveMoney: int} }
            bool showWithdrawalsErr = false;
            string[] ids = atms.Keys.ToArray();

            for (int i = 0; i < ids.Length; i++) {
                // Set the id of the atm and the money its contains
                allAtmsWithAVG.Add(ids[i], new DictionaryData(atms[ids[i]]));
                int[] allDaysAvg = new int[7];

                // Fill the avg of each day
                for (int j = 1; j <= 7; j++) {
                    allDaysAvg[j - 1] = db.getAvgWithdrawalsOfDay(ids[i], j);
                }

                allAtmsWithAVG[ids[i]].avg = allDaysAvg;


                // Calculate the date the money will end or will be critical
                int daysUntilEmpty = 0;
                int day = (int) DateTime.Now.DayOfWeek;

                if (withdrawalsExists(allAtmsWithAVG[ids[i]].avg)) {
                    while (allAtmsWithAVG[ids[i]].liveMoneyAvilable >= 0) {
                        allAtmsWithAVG[ids[i]].liveMoneyAvilable -= allAtmsWithAVG[ids[i]].avg[day];

                        daysUntilEmpty++;
                        day++;
                        if (day >= 7) {
                            day = 1;
                        }
                    }

                    // Book into Track at the date needed
                    DateTime today = DateTime.Now;
                    DateTime emptyDay = today.AddDays(daysUntilEmpty - 2);
                    SqlDate emptyDate = new SqlDate(emptyDay.Day, emptyDay.Month, emptyDay.Year);

                    // Check if exists Track at this day
                    Track[] allTracksAtEmptyDate = db.getTracksByDate(emptyDate);
                    if (allTracksAtEmptyDate.Length > 0) {
                        for (int j = 0; j < allTracksAtEmptyDate.Length; j++) {
                            if (allTracksAtEmptyDate[j].atms.Length < 6 && !allTracksAtEmptyDate[j].is_done) {
                                // Insert this ATM into this Track
                                db.addAtmToTrack(int.Parse(ids[i]), int.Parse(db.getIdByTrack(allTracksAtEmptyDate[j]))); // ids[i] -> currentAtmID
                            }
                        }
                    } else {
                        // Creates new Track with the specified atm inside
                        int newTrackID = db.addTrack(
                            new Track(
                                null,
                                false,
                                emptyDate,
                                db.getRandID(RandChooser.Car),
                                db.getRandID(RandChooser.Employee),
                                db.getRandID(RandChooser.Admin)
                            )
                        );
                        db.addAtmToTrack(int.Parse(ids[i]), newTrackID);
                    }
                } else {
                    showWithdrawalsErr = true;
                }
            }

            if(showWithdrawalsErr) {
                MessageBox.Show("There is no withdrawals to work with, Please withdrawal and try again");
            }
        }

        private bool withdrawalsExists(int[] avgWithdrawalsArr) {
            bool isFilled = false;

            for (int i = 0; i < avgWithdrawalsArr.Length; i++) {
                if (avgWithdrawalsArr[i] != 0) {
                    isFilled = true;
                }
            }

            return isFilled;
        }

        private class DictionaryData {
            public int[] avg { get; set; }
            public int liveMoneyAvilable { get; set; }

            public DictionaryData(int liveMoneyAvilable_c) {
                avg = new int[7];
                liveMoneyAvilable = liveMoneyAvilable_c;
            }
        }

        private void withdrawalsBtn_Click(object sender, EventArgs e) {
            DatabaseConnector db = new DatabaseConnector();
            Dictionary<string, int> allAtms = db.getAllAtms(); // { id, live_money_avilable }

            string[] keys = allAtms.Keys.ToArray();
            int[] days = { 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

            for (int i = 0; i < 1400; i++) {

                SqlDate date = new SqlDate(days[i / 200], 6, 2019);
                Random random = new Random();
                int randID = random.Next(0, keys.Length);

                db.makeWithdrawal(keys[randID], date, random.Next(1, 50) * 100);
            }

            MessageBox.Show("All withdrawals saved successfuly");
        }
    }
}