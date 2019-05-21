using System;
using System.Windows.Forms;

namespace FinalProject_2019.UI {
    public partial class AddNewATM : Form {
        private AtmSize atmSize = AtmSize.NONE;
        private int capacity;
        private string brand;

        // Address
        private string street;
        private string houseNumber;
        private string zipCode;
        private string city;

        public AddNewATM() {
            InitializeComponent();
        }

        private void wideATM_CheckedChanged(object sender, EventArgs e) {
            atmSize = AtmSize.BIG;

            if(singleATM.Checked) {
                singleATM.Checked = false;
            }

            wideATM.Checked = true;
        }

        private void singleATM_CheckedChanged(object sender, EventArgs e) {
            atmSize = AtmSize.SMALL;

            if(wideATM.Checked) {
                wideATM.Checked = false;
            }

            singleATM.Checked = true;
        }

        private void atmStreet_TextChanged(object sender, EventArgs e) {
            street = atmStreet.Text;
        }

        private void atmHouseNum_TextChanged(object sender, EventArgs e) {
            houseNumber = atmHouseNum.Text;
        }

        private void atmCity_TextChanged(object sender, EventArgs e) {
            city = atmCity.Text;
        }

        private void atmZipCode_TextChanged(object sender, EventArgs e) {
            zipCode = atmZipCode.Text;
        }

        private void atmCapacity_TextChanged(object sender, EventArgs e) {
            if(atmCapacity.Text != null && atmCapacity.Text != "") {
                capacity = int.Parse(atmCapacity.Text);
            }
        }

        private bool isEmpty(string str) {
            if(str != null && str != "") {
                return true;
            }

            return false;
        }

        private void addNewATMButton_Click(object sender, EventArgs e) {
            if(
                atmSize != AtmSize.NONE && 
                capacity > 0 && 
                !isEmpty(brand) && 
                !isEmpty(street) && 
                !isEmpty(houseNumber) && 
                !isEmpty(zipCode) && 
                !isEmpty(city)
            ) {
                // Add new changes into the database
                
            } else {
                MessageBox.Show("Please check again if all the necessary parameters are inserted");
            }
        }
    }

    enum AtmSize {
        BIG = 2,
        SMALL = 1,
        NONE
    }
}
