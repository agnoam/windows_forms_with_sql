using FinalProject_2019.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_2019.TabsContent {
    public partial class EmployeesTab : Form {

        private int tabIndex;
        private TabControl tabCtrl;
        private int contentHeight;
        private int contentWidth;
        
        public EmployeesTab(AdminPage parent_c, int tabIndex_c) {
            tabIndex = tabIndex_c;
            tabCtrl = parent_c.getTabControl();
            contentHeight = tabCtrl.TabPages[tabIndex].Size.Height;
            contentWidth = tabCtrl.TabPages[tabIndex].Size.Width;

            InitializeComponent();

            // Getting all the data from database
            DatabaseConnector database = new DatabaseConnector();
            DataSet ds = database.getAllTable("Employees");

            bindingSource1.DataSource = ds.Tables[0];
            dataGridView.DataSource = bindingSource1;
        }

        private void addEmployee_Click(object sender, EventArgs e) {
            new AddNewEmployee().ShowDialog();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e) {
            if (dataGridView.SelectedCells.Count > 0) {
                int selectedrowindex = dataGridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["id"].Value);

                Console.WriteLine(a);
            }
        }
    }
}
