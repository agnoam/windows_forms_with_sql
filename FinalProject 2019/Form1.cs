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
    public partial class LoginPage : Form {
        public LoginPage() {
            InitializeComponent();
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e) {

        }

        private void closeForm_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
