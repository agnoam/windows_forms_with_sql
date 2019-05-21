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
    public partial class AtmsTab : Form {
        private int tabIndex;
        private TabControl tabCtrl;
        private int contentHeight;
        private int contentWidth;

        public AtmsTab(AdminPage parent_c, int tabIndex_c) {
            tabIndex = tabIndex_c;
            tabCtrl = parent_c.getTabControl();
            contentHeight = tabCtrl.TabPages[tabIndex].Size.Height;
            contentWidth = tabCtrl.TabPages[tabIndex].Size.Width;

            InitializeComponent();
        }

        private void showDialogBox() {
            
            
        }

        private void addATM_Click(object sender, EventArgs e) {

        }
    }
}
