using FinalProject_2019.Pages;
using FinalProject_2019.Resources;
using FinalProject_2019.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace FinalProject_2019.UI {
    public partial class TabContent : Form {
        private int tabIndex;
        private TabControl tabCtrl;
        private TabChooser tabChooser;

        private int contentHeight;
        private int contentWidth;

        private ATM selectedAtm;
        private Employee selectedEmployee;
        private Car selectedCar;
        private DatabaseConnector database = new DatabaseConnector();

        private string itemId;
        private string addrsId;

        public TabContent(AdminPage parent_c, int tabIndex_c, TabChooser tabChooser_c) {
            tabChooser = tabChooser_c;
            tabIndex = tabIndex_c;
            tabCtrl = parent_c.getTabControl();
            contentHeight = tabCtrl.TabPages[tabIndex].Size.Height;
            contentWidth = tabCtrl.TabPages[tabIndex].Size.Width;

            InitializeComponent();
        }

        private void TabContent_Load(object sender, EventArgs e) {
            if (tabChooser == TabChooser.Tracks) {
                hideButtons();
                filledATMsLabel.Hide();
            } else if (tabChooser == TabChooser.ATM) {
                showTrackButton.Text = "Fill";
            } else {
                showTrackButton.Hide();
                filledATMsLabel.Hide();
            }

            fillDataGrid();
        }

        private void hideButtons() {
            deleteButton.Hide();
            addATMButton.Hide();
            updateButton.Hide();
        }

        private void fillDataGrid() {
            DataSet ds = new DataSet();
            string atmsData = "Filled ATMs: 28,  EmptyATMs: 12, Total ATMs: 125 \r\nCurrent money: 120 / 150";

            if (tabChooser == TabChooser.ATM) {
                // Getting all the data from database
                ds = database.getAllTable("Atms");
                Dictionary<string, string> data = database.getATMsData();
                atmsData = $"Filled ATMs: {int.Parse(data["allATMs"]) - int.Parse(data["emptyATMs"])},  EmptyATMs: {data["emptyATMs"]}, Total ATMs: {data["allATMs"]} \r\nCurrent money: {String.Format("{0:n0}", int.Parse(data["cuurentMoney"]))} of {String.Format("{0:n0}", int.Parse(data["filledMoney"]))}";

                filledATMsLabel.Text = atmsData;
            } else if (tabChooser == TabChooser.Cars) {
                // Getting all the data from database
                ds = database.getAllTable("Cars");
            } else if (tabChooser == TabChooser.Employees) {
                // Getting all the data from database
                ds = database.getAllTable("Employees");
            } else if (tabChooser == TabChooser.Tracks) {
                // Getting all the data from database
                ds = database.getAllTable("Tracks");
            }

            bindingSource1.DataSource = ds.Tables[0];
            atmsGridView.DataSource = bindingSource1;
        }

        private void addATM_Click(object sender, EventArgs e) {
            if (tabChooser == TabChooser.ATM) {
                AddNewATM addAtmsPage = new AddNewATM(this);
                addAtmsPage.ShowDialog();
            } else if (tabChooser == TabChooser.Cars) {
                AddNewCar addCarPage = new AddNewCar(this);
                addCarPage.ShowDialog();
            } else if (tabChooser == TabChooser.Employees) {
                AddNewEmployee newEmp = new AddNewEmployee(this);
                newEmp.ShowDialog();
            }
        }

        private void updateButton_Click(object sender, EventArgs e) {
            if(tabChooser == TabChooser.ATM) {
                AddNewATM addAtmsPage =
                    new AddNewATM(itemId, selectedAtm.size, selectedAtm.capacity, selectedAtm.brand, addrsId, this, itemId);
                addAtmsPage.ShowDialog();
            } else if (tabChooser == TabChooser.Cars) {
                AddNewCar addNewCarPage = new AddNewCar(selectedCar, itemId, this);
                addNewCarPage.ShowDialog();
            } else if(tabChooser == TabChooser.Employees) {
                AddNewEmployee addEmpPage = new AddNewEmployee(selectedEmployee, database.getAddressByID(addrsId), addrsId, this);
                addEmpPage.ShowDialog();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            if(tabChooser == TabChooser.ATM) {
                DialogResult res = MessageBox.Show($"Are you sure that yow want to delete ATM of number {itemId} ?", "", MessageBoxButtons.OKCancel);

                if (res == DialogResult.OK) {
                    database.deleteFromTable("Atms", itemId);
                    database.deleteFromTable("Addresses", addrsId);
                }
            } else if(tabChooser == TabChooser.Cars) {
                DialogResult res = MessageBox.Show($"Are you sure that yow want to delete Car number {itemId} ?", "", MessageBoxButtons.OKCancel);

                if (res == DialogResult.OK) {
                    database.deleteFromTable("Cars", itemId);
                    database.deleteFromTable("Employees", selectedCar.driver_id);
                }
            } else if(tabChooser == TabChooser.Employees) {
                DialogResult res = MessageBox.Show($"Are you sure that yow want to delete Employee of id: {itemId} ?", "", MessageBoxButtons.OKCancel);

                if (res == DialogResult.OK) {
                    database.deleteFromTable("Employees", itemId);
                    database.deleteFromTable("Addresses", addrsId);
                }
            }

            // Updating the changes to the UI
            fillDataGrid();
        }

        private void atmsGridView_SelectionChanged(object sender, EventArgs e) {
            if (atmsGridView.SelectedCells.Count > 0) {
                int selectedrowindex = atmsGridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = atmsGridView.Rows[selectedrowindex];

                if (tabChooser == TabChooser.ATM) {
                    string id = Convert.ToString(selectedRow.Cells["id"].Value);
                    string capacity = Convert.ToString(selectedRow.Cells["capacity"].Value);
                    string atmSize = Convert.ToString(selectedRow.Cells["atm_size"].Value);
                    string brand = Convert.ToString(selectedRow.Cells["brand"].Value);
                    string addressId = Convert.ToString(selectedRow.Cells["Addresses_id"].Value);
                    string avilableMoney = Convert.ToString(selectedRow.Cells["live_money_avilable"].Value);

                    itemId = id;
                    addrsId = addressId;
                    selectedAtm =
                        new ATM(null, int.Parse(capacity), int.Parse(atmSize), brand);
                    Console.WriteLine(selectedAtm.ToString());
                } else if (tabChooser == TabChooser.Cars) {
                    string id = Convert.ToString(selectedRow.Cells["id"].Value);
                    string code = Convert.ToString(selectedRow.Cells["code"].Value);
                    string model = Convert.ToString(selectedRow.Cells["model"].Value);
                    string creationDate = Convert.ToString(selectedRow.Cells["creation_date"].Value);
                    string driverId = Convert.ToString(selectedRow.Cells["driver_id"].Value);

                    itemId = id;

                    selectedCar = new Car(code, model, new SqlDate(creationDate), driverId);
                } else if (tabChooser == TabChooser.Employees) {
                    string id = Convert.ToString(selectedRow.Cells["id"].Value);
                    string name = Convert.ToString(selectedRow.Cells["name"].Value);
                    string birthDay = Convert.ToString(selectedRow.Cells["birth_date"].Value);
                    string role = Convert.ToString(selectedRow.Cells["role"].Value);
                    string username = Convert.ToString(selectedRow.Cells["username"].Value);
                    string password = Convert.ToString(selectedRow.Cells["password"].Value);
                    string phoneNum = Convert.ToString(selectedRow.Cells["phone_number"].Value);
                    string email = Convert.ToString(selectedRow.Cells["email"].Value);
                    string gender = Convert.ToString(selectedRow.Cells["gender"].Value);
                    string addressId = Convert.ToString(selectedRow.Cells["Addresses_id"].Value);

                    itemId = id;
                    addrsId = addressId;
                    selectedEmployee = new Employee(id, name, new SqlDate(birthDay), role, username, phoneNum, gender, null);
                } else if(tabChooser == TabChooser.Tracks) {
                    string id = Convert.ToString(selectedRow.Cells["id"].Value);
                    itemId = id;
                }
            }
        }

        public void refreshTable(TabChooser chooser) {
            tabChooser = chooser;
            fillDataGrid();
        }

        private void showTrackButton_Click(object sender, EventArgs e) {
            if(tabChooser == TabChooser.Tracks) {
                if(database.getTrackByID(itemId).atms.Length > 1) {
                    MapPage map = new MapPage(itemId);
                    map.ShowDialog();
                } else {
                    MessageBox.Show("There is no route, Beacuse there is just 1 point in the track.");
                }
            } else if(tabChooser == TabChooser.ATM) {
                new DatabaseConnector().fillATM(itemId);
                refreshTable(TabChooser.ATM);
            }
        }
    }
}

public enum TabChooser {
    ATM,
    Cars,
    Employees,
    Tracks
}