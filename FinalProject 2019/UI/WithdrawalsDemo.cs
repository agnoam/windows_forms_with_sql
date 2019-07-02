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
    public partial class WithdrawalsDemo : Form {
        private string startDate;
        private string endDate;

        public WithdrawalsDemo() {
            InitializeComponent();
        }

        private void StratDayPicker_ValueChanged(object sender, EventArgs e) {
            startDate = $"{StratDayPicker.Value.Day}/{StratDayPicker.Value.Month}/{StratDayPicker.Value.Year}";
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e) {
            endDate = $"{endDatePicker.Value.Day}/{endDatePicker.Value.Month}/{endDatePicker.Value.Year}";
        }
    }
}
