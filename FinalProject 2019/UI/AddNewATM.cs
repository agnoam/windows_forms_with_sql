using FinalProject_2019.Resources;
using System;
using System.Windows.Forms;

namespace FinalProject_2019.UI {
    public partial class AddNewATM : Form {

        private TabContent parent;
        private DatabaseConnector db = new DatabaseConnector();
        private int atmSize = (int) AtmSize.NONE;

        private string baseAddressId;
        private string atmId;
        private bool isChanged = false;

        private int capacity;
        private string brand;
        private string id = null;

        // Address
        private string street;
        private string houseNumber;
        private string zipCode;
        private string city;
        private string lat;
        private string lng;


        public AddNewATM(TabContent parent_c) {
            InitializeComponent();

            parent = parent_c;
        }

        public AddNewATM(string id_c, int size_c, int capacity_c, string brand_c, string baseAddressId_c, TabContent parent_c, string atmId_c) {
            InitializeComponent();

            Address address_c = db.getAddressByID(baseAddressId_c);

            parent = parent_c;
            baseAddressId = baseAddressId_c;
            atmId = atmId_c;

            id = id_c;
            atmSize = size_c;
            capacity = capacity_c;
            brand = brand_c;
            street = address_c.street;
            houseNumber = address_c.house_num.ToString();
            zipCode = address_c.zip_code;
            city = address_c.city;
            lat = address_c.lat.ToString();
            lng = address_c.lng.ToString();

            Text = "Update ATM";
            addNewATMButton.Text = "Update";
        }

        private void AddNewATM_Load(object sender, EventArgs e) {
            if(addNewATMButton.Text == "Update") {
                atmIdLabel.Location = new System.Drawing.Point(236, 60);
                atmIdLabel.Size = new System.Drawing.Size(18, 13);
                atmIdLabel.TabIndex = 18;
                atmIdLabel.Text = "ID";

                atmIdTextBox.Location = new System.Drawing.Point(239, 76);
                atmIdTextBox.Size = new System.Drawing.Size(100, 20);
                atmIdTextBox.TabIndex = 17;
                atmIdTextBox.ReadOnly = true;
                atmIdTextBox.Text = id;

                brandLabel.Location = new System.Drawing.Point(236, 152);

                atmBrandTextBox.Location = new System.Drawing.Point(239, 168);
                atmBrandTextBox.Size = new System.Drawing.Size(100, 20);
                atmBrandTextBox.TabIndex = 12;
                atmBrandTextBox.Text = brand;

                capacityLabel.Location = new System.Drawing.Point(236, 106);
                capacityLabel.TabIndex = 14;

                atmCapacity.Location = new System.Drawing.Point(239, 122);
                atmCapacity.Size = new System.Drawing.Size(100, 20);
                atmCapacity.TabIndex = 11;
                atmCapacity.Text = capacity.ToString();

                wideATM_Radio.Location = new System.Drawing.Point(239, 215);
                if (atmSize == (int) AtmSize.BIG) {
                    wideATM_Radio.Checked = true;
                }

                singleATM_Radio.Location = new System.Drawing.Point(351, 215);
                if (atmSize == (int) AtmSize.SMALL) {
                    singleATM_Radio.Checked = true;
                }

                // Updating the address details
                atmStreetTextBox.Text = street;
                atmHouseNumTextBox.Text = houseNumber;
                atmCityTextBox.Text = city;
                atmZipCodeTextBox.Text = zipCode;
                LatTextBox.Text = lat;
                LngTextBox.Text = lng;
            }

            isChanged = false;
        }

        private void wideATM_CheckedChanged(object sender, EventArgs e) {
            atmSize = (int) AtmSize.BIG;
            wideATM_Radio.Checked = !singleATM_Radio.Checked;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void singleATM_CheckedChanged(object sender, EventArgs e) {
            atmSize = (int) AtmSize.SMALL;
            singleATM_Radio.Checked = !wideATM_Radio.Checked;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void atmStreet_TextChanged(object sender, EventArgs e) {
            street = atmStreetTextBox.Text;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void atmHouseNum_TextChanged(object sender, EventArgs e) {
            houseNumber = atmHouseNumTextBox.Text;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void atmCity_TextChanged(object sender, EventArgs e) {
            city = atmCityTextBox.Text;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void atmZipCode_TextChanged(object sender, EventArgs e) {
            zipCode = atmZipCodeTextBox.Text;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void atmCapacity_TextChanged(object sender, EventArgs e) {
            if(atmCapacity.Text != null && atmCapacity.Text != "") {
                capacity = int.Parse(atmCapacity.Text);
            }

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void atmBrand_TextChanged(object sender, EventArgs e) {
            brand = atmBrandTextBox.Text;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void LatTextBox_TextChanged(object sender, EventArgs e) {
            lat = LatTextBox.Text;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void LngTextBox_TextChanged(object sender, EventArgs e) {
            lng = LngTextBox.Text;

            if (!isChanged) {
                isChanged = true;
            }
        }

        private void addNewATMButton_Click(object sender, EventArgs e) {
            if (
                atmSize != (int) AtmSize.NONE &&
                capacity > 0 &&
                !AdditionalFunctions.isEmpty(brand) &&
                !AdditionalFunctions.isEmpty(street) &&
                !AdditionalFunctions.isEmpty(houseNumber) &&
                !AdditionalFunctions.isEmpty(zipCode) &&
                !AdditionalFunctions.isEmpty(city) &&
                !AdditionalFunctions.isEmpty(lat) &&
                !AdditionalFunctions.isEmpty(lng) &&
                isChanged
            ) {
                // Add new changes into the database
                Address addr = new Address(
                    AdditionalFunctions.trimFlWhitespaces(street),
                    int.Parse(AdditionalFunctions.trimFlWhitespaces(houseNumber)),
                    AdditionalFunctions.trimFlWhitespaces(city),
                    AdditionalFunctions.trimFlWhitespaces(zipCode),
                    AdditionalFunctions.isEmpty(AdditionalFunctions.trimFlWhitespaces(lat)) ? 0.0 : double.Parse(lat),
                    AdditionalFunctions.isEmpty(AdditionalFunctions.trimFlWhitespaces(lng)) ? 0.0 : double.Parse(lng)
                );

                if (addNewATMButton.Text == "Update") {
                    try {
                        bool res = db.updateATM(
                            new ATM(
                                addr,
                                capacity,
                                (int) atmSize,
                                brand
                            ),
                            db.getAddressByID(baseAddressId),
                            atmId,
                            baseAddressId
                        );

                        MessageBox.Show($"ATM number {atmId} updated successfuly");
                        Close();
                    } catch (Exception ex) {
                        Console.WriteLine(ex);
                        MessageBox.Show("Error occord with ATM's update, Please try again later.");
                        Close();
                    }
                } else {
                    bool res = db.addNewATM(
                        new ATM(
                            addr,
                            capacity,
                            (int) atmSize,
                            AdditionalFunctions.trimFlWhitespaces(brand)
                        )
                    );
                }
            } else {
                if (!isChanged) {
                    MessageBox.Show("No data has changed, If you want to close please click the X button on the top");
                } else {
                    MessageBox.Show("One of the fields are not filled, Please fill and try again.");
                }
            }
        }
    }
}

public enum AtmSize {
    BIG = 2,
    SMALL = 1,
    NONE = 0
}