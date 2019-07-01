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
    public partial class AddNewEmployee : Form {

        TabContent parent;
        Employee employee = null;
        Address address = null;
        DatabaseConnector db = new DatabaseConnector();

        private bool showPass = true;
        private string addressID;
        private bool isChanged = false;

        // Employee
        private string id;
        private string name;
        private string birth_date;
        private string role;
        private string username;
        private string password;
        private string secPassword;
        private string phoneNumber;
        private string gender;
        
        // Address
        private string street;
        private string house_num;
        private string city;
        private string zip_code;

        public AddNewEmployee(TabContent parent_c) {
            InitializeComponent();

            passwordTextBox.UseSystemPasswordChar = true;
            secPasswordTextBox.UseSystemPasswordChar = showPass;

            parent = parent_c;
        }

        public AddNewEmployee(Employee employee_c, Address address_c, string addressID_c, TabContent parent_c) {
            InitializeComponent();

            parent = parent_c;
            addressID = addressID_c;
            employee = employee_c;
            address = address_c;

            Text = "Update Employee";
            submitButton.Text = "Update";
        }

        private void AddNewEmployee_Load(object sender, EventArgs e) {
            if(submitButton.Text == "Update") {
                passwordTextBox.UseSystemPasswordChar = true;
                secPasswordTextBox.UseSystemPasswordChar = showPass;

                idTextBox.Text = employee.id;
                nameTextBox.Text = employee.name;
                birthdayPicker.Value = new DateTime(employee.birthDate.year, employee.birthDate.month, employee.birthDate.day);
                // birthDateTextbox.Text = employee.birthDate.ToString();

                if (employee.role == ConstVars.Roles.ADMIN) {
                    adminRadioButton.Checked = true;
                } else if (employee.role == ConstVars.Roles.EMPLOYEE) {
                    empRadioButton.Checked = true;
                }

                usernameTextbox.Text = employee.username;
                phoneNumberTextBox.Text = employee.phone_number;
                // birthDateTextbox.Text = $"{ employee.birthDate.day }/{ employee.birthDate.month }/{ employee.birthDate.year }";

                if (employee.gender == ConstVars.Gender.MALE) {
                    maleRadioButton.Checked = true;
                } else if (employee.gender == ConstVars.Gender.FEMALE) {
                    femaleRadioButton.Checked = true;
                }

                // Updating the address details
                streetTextBox.Text = address.street;
                houseNumTextBox.Text = address.house_num.ToString();
                cityTextBox.Text = address.city;
                zipCodeTextBox.Text = address.zip_code;

                isChanged = false;
            }
        }

        private void streetTextBox_TextChanged(object sender, EventArgs e) {
            street = streetTextBox.Text;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void houseNumTextBox_TextChanged(object sender, EventArgs e) {
            house_num = houseNumTextBox.Text;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e) {
            city = cityTextBox.Text;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void zipCodeTextBox_TextChanged(object sender, EventArgs e) {
            zip_code = zipCodeTextBox.Text;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void idTextBox_TextChanged(object sender, EventArgs e) {
            id = idTextBox.Text;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e) {
            name = nameTextBox.Text;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void birthDateTextbox_TextChanged(object sender, EventArgs e) {
            // birth_date = birthDateTextbox.Text;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void adminRadioButton_CheckedChanged(object sender, EventArgs e) {
            role = ConstVars.Roles.ADMIN;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void empRadioButton_CheckedChanged(object sender, EventArgs e) {
            role = ConstVars.Roles.EMPLOYEE;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e) {
            username = usernameTextbox.Text;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e) {
            password = passwordTextBox.Text;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void secPasswordTextBox_TextChanged(object sender, EventArgs e) {
            secPassword = secPasswordTextBox.Text;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void showPasswordBtn_Click(object sender, EventArgs e) {
            if(showPass) {
                showPass = false;
                showPasswordBtn.BackgroundImage = Properties.Resources.view;

                passwordTextBox.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
                secPasswordTextBox.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            } else {
                showPass = true;
                showPasswordBtn.BackgroundImage = Properties.Resources.hide;

                passwordTextBox.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
                secPasswordTextBox.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e) {
            phoneNumber = phoneNumberTextBox.Text;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e) {
            gender = ConstVars.Gender.MALE;
            maleRadioButton.Checked = !femaleRadioButton.Checked;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e) { 
            gender = ConstVars.Gender.FEMALE;
            femaleRadioButton.Checked = !maleRadioButton.Checked;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void birthdayPicker_ValueChanged(object sender, EventArgs e) {
            birth_date = $"{birthdayPicker.Value.Day}/{birthdayPicker.Value.Month}/{birthdayPicker.Value.Year}";

            if(!isChanged) {
                isChanged = true;
            }
        }

        private void submitButton_Click(object sender, EventArgs e) {
            if(
                !AdditionalFunctions.isEmpty(id) &&
                !AdditionalFunctions.isEmpty(name) &&
                !AdditionalFunctions.isEmpty(birth_date) &&
                !AdditionalFunctions.isEmpty(role) &&
                !AdditionalFunctions.isEmpty(username) &&
                !AdditionalFunctions.isEmpty(password) &&
                !AdditionalFunctions.isEmpty(secPassword) &&
                !AdditionalFunctions.isEmpty(phoneNumber) &&
                !AdditionalFunctions.isEmpty(gender) &&
                !AdditionalFunctions.isEmpty(street) &&
                !AdditionalFunctions.isEmpty(house_num) &&
                !AdditionalFunctions.isEmpty(city) &&
                !AdditionalFunctions.isEmpty(zip_code) &&
                isChanged
            ) {
                if (password == secPassword) {
                    if(submitButton.Text == "Update") {
                        try {
                            bool res = db.updateEmployee(
                                new Employee(
                                    id,
                                    name,
                                    new SqlDate(birth_date),
                                    role,
                                    username,
                                    password,
                                    phoneNumber,
                                    new Address(
                                        street,
                                        int.Parse(house_num),
                                        city,
                                        zip_code,
                                        0.0,
                                        0.0
                                    )
                                ),
                                address,
                                addressID
                            );

                            if (res) {
                                Close();
                                parent.refreshTable(TabChooser.Employees);
                            } else {
                                MessageBox.Show($"Error occord with { name }'s update, Please try again later.");
                                Close();
                            }
                        } catch(Exception ex) {
                            MessageBox.Show($"Error occord with { name }'s update, Please try again later.");
                            Close();
                        }
                    } else {
                        db.addNewEmploeey(
                            new Employee(
                                id,
                                name,
                                new SqlDate(birth_date),
                                role, username,
                                AdditionalFunctions.MD5(AdditionalFunctions.MD5(password)),
                                phoneNumber,
                                gender,
                                address
                            )
                        );
                    }
                }
            } else {
                if (!isChanged) {
                    MessageBox.Show("No data has changed, If you want to close please click the X button on the top");
                } else {
                    MessageBox.Show("One of the fields are not filled, Please fill and try again.");
                }

                if(AdditionalFunctions.isEmpty(id)) {
                    idTextBox.BackColor = Color.Red;
                }
            }
        }
    }
}
