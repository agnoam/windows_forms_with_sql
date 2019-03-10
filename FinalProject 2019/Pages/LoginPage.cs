using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalProject_2019 {
    public partial class LoginPage : Form {

        private bool mouseDown = false;
        private bool isPassword = true;
        private Point lastLocation;
        private string usernameText;
        private string passwordText;

        public LoginPage() {
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

        public void RemoveText(object sender, EventArgs e) {
            this.usernameTextBox.Text = "";
        }

        private void showSignInBtn() {

            Console.WriteLine(usernameText + ", " + passwordText);

            if ((usernameText != null && usernameText != "") && (passwordText != null && passwordText != "")) {
                signInBtn.Visible = true;
            } else {
                signInBtn.Visible = false;
            }
        }

        private void username_TextChanged(object sender, EventArgs e) {
            usernameText = usernameTextBox.Text;
            showSignInBtn();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e) {
            passwordText = passwordTextBox.Text;
            showSignInBtn();
        }

        private void passwordTextBox_GotFocus(object sender, EventArgs e) {
            showPasswordBtn.Visible = true;
        }

        private void showPasswordBtn_Hide(object sender, EventArgs e) {
            showPasswordBtn.Visible = false;
        }

        private void showPasswordBtn_Click(object sender, EventArgs e) {
            Console.WriteLine("Clicked");

            Image bImg;

            if(isPassword) {
                passwordTextBox.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
                bImg = Properties.Resources.view;
                isPassword = false;
            } else {
                passwordTextBox.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
                bImg = Properties.Resources.hide;
                isPassword = true;
            }

            showPasswordBtn.BackgroundImage = bImg;
        }

        private void signInBtn_Click(object sender, EventArgs e) {
            // Check with the Database the username and the password and move to the HomePage || AdminPage


            // WinForms navigation needs to be like this
            AdminPage adminPage = new AdminPage();
            adminPage.TopLevel = false;
            Controls.Clear();
            Controls.Add(adminPage);
            adminPage.Show();
        }
    }
}