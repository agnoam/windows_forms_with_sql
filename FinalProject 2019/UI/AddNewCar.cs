using FinalProject_2019.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_2019.UI {
    public partial class AddNewCar : Form {

        private Car carToUpdate = null;
        private DatabaseConnector db = new DatabaseConnector();
        private TabContent parent;

        private string carId;
        private string driverId;
        private string model;
        private string creationDate;
        private string code;

        private bool isChanged = false;

        public AddNewCar(TabContent parent_c) {
            InitializeComponent();

            parent = parent_c;
        }

        public AddNewCar(Car carToUpdate_c, string carId_c, TabContent parent_c) {
            InitializeComponent();

            parent = parent_c;
            carToUpdate = carToUpdate_c;
            carId = carId_c;
        }

        private void AddNewCar_Load(object sender, EventArgs e) {
            if(carToUpdate != null) {
                Text = "Update car";
                carIdTextBox.Text = carId;
                driverIdTextBox.Text = carToUpdate.driver_id;
                modelTextBox.Text = carToUpdate.model;
                codeTextBox.Text = carToUpdate.code;
                createCarBtn.Text = "Update";
                creationDatePicker.Value = 
                    new DateTime(carToUpdate.creation_date.year, carToUpdate.creation_date.month, carToUpdate.creation_date.day);

                isChanged = false;
            } else {
                carIDLabel.Visible = false;
                carIdTextBox.Visible = false;

                // Moving all content up
                driverIdLabel.Location = new Point(90, 77);
                driverIdTextBox.Location = new Point(94, 97);
                modelTextBox.Location = new Point(95, 162);
                modelLabel.Location = new Point(91, 143);
                creationDatePicker.Location = new Point(95, 230);
                creationDateLabel.Location = new Point(91, 210);
                codeTextBox.Location = new Point(95, 298);
                codeLabel.Location = new Point(91, 278);
            }
        }

        private void createCarBtn_Click(object sender, EventArgs e) {
            if(createCarBtn.Text == "Update" && carId != null) {
                if(
                    !AdditionalFunctions.isEmpty(code) &&
                    !AdditionalFunctions.isEmpty(model) &&
                    !AdditionalFunctions.isEmpty(creationDate) &&
                    !AdditionalFunctions.isEmpty(driverId) &&
                    isChanged
                ) {
                    try {
                        bool res = db.updateCar(
                            new Car(
                                AdditionalFunctions.trimFlWhitespaces(code),
                                AdditionalFunctions.trimFlWhitespaces(model),
                                new SqlDate(AdditionalFunctions.trimFlWhitespaces(creationDate)),
                                AdditionalFunctions.trimFlWhitespaces(driverId)
                            ),
                        carId);

                        if (res) {
                            Close();
                            parent.refreshTable(TabChooser.Cars);
                        } else {
                            MessageBox.Show("Error occord with Car's update, Please try again later.");
                            Close();
                        }
                    } catch(Exception ex) {
                        MessageBox.Show("Error occord with Car's update, Please try again later.");
                        Close();
                    }
                } else {
                    if(!isChanged) {
                        MessageBox.Show("No data has changed, If you want to close please click the X button on the top");
                    } else {
                        MessageBox.Show("One of the fields are not filled, Please fill and try again.");
                    }
                }
            } else {
                if (
                    !AdditionalFunctions.isEmpty(code) &&
                    !AdditionalFunctions.isEmpty(model) &&
                    !AdditionalFunctions.isEmpty(creationDate) &&
                    !AdditionalFunctions.isEmpty(driverId)
                ) {
                    bool res = db.addNewCar(new Car(
                        AdditionalFunctions.trimFlWhitespaces(code),
                        AdditionalFunctions.trimFlWhitespaces(model),
                        new SqlDate(AdditionalFunctions.trimFlWhitespaces(creationDate)),
                        AdditionalFunctions.trimFlWhitespaces(driverId)
                    ));

                    if (res) {
                        Close();
                        parent.refreshTable(TabChooser.Cars);
                    } else {
                        MessageBox.Show("Error occord with Car's creation, Please try again later.");
                        Close();
                    }
                } else {
                    MessageBox.Show("One of the fields are not filled, Please fill and try again.");
                }
            }
        }

        private void driverIdTextBox_TextChanged(object sender, EventArgs e) {
            driverId = driverIdTextBox.Text;

            if(!isChanged) {
                isChanged = true;
            }
        }

        private void modelTextBox_TextChanged(object sender, EventArgs e) {
            model = modelTextBox.Text;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void creationDatePicker_ValueChanged(object sender, EventArgs e) {
            creationDate = $"{creationDatePicker.Value.Day}/{creationDatePicker.Value.Month}/{creationDatePicker.Value.Year}";

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void codeTextBox_TextChanged(object sender, EventArgs e) {
            code = codeTextBox.Text;

            if (!isChanged) {
                isChanged = true;
            }
        }
    }
}