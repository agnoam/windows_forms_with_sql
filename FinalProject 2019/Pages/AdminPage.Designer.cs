using FinalProject_2019.Pages;

namespace FinalProject_2019 {
    partial class AdminPage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.formBorder = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FrameLabel = new System.Windows.Forms.Label();
            this.closeForm = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.manageEmployees = new System.Windows.Forms.TabPage();
            this.atmsPage = new System.Windows.Forms.TabPage();
            this.carsPage = new System.Windows.Forms.TabPage();
            this.routesPage = new System.Windows.Forms.TabPage();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.WiseAlgBtn = new System.Windows.Forms.Button();
            this.ManageCars = new System.Windows.Forms.Button();
            this.ManageRoutes = new System.Windows.Forms.Button();
            this.ManageATMs = new System.Windows.Forms.Button();
            this.ButtonSelector = new System.Windows.Forms.Panel();
            this.employees = new System.Windows.Forms.Button();
            this.formBorder.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // formBorder
            // 
            this.formBorder.BackColor = System.Drawing.Color.DarkBlue;
            this.formBorder.Controls.Add(this.panel1);
            this.formBorder.Controls.Add(this.FrameLabel);
            this.formBorder.Controls.Add(this.closeForm);
            this.formBorder.Location = new System.Drawing.Point(-2, -2);
            this.formBorder.Margin = new System.Windows.Forms.Padding(2);
            this.formBorder.Name = "formBorder";
            this.formBorder.Size = new System.Drawing.Size(826, 40);
            this.formBorder.TabIndex = 0;
            this.formBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formBorder_MouseDown);
            this.formBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formBorder_MouseMove);
            this.formBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formBorder_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(221, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 171);
            this.panel1.TabIndex = 3;
            // 
            // FrameLabel
            // 
            this.FrameLabel.AutoSize = true;
            this.FrameLabel.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.FrameLabel.Location = new System.Drawing.Point(10, 9);
            this.FrameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FrameLabel.Name = "FrameLabel";
            this.FrameLabel.Size = new System.Drawing.Size(93, 22);
            this.FrameLabel.TabIndex = 2;
            this.FrameLabel.Text = "NSecurities";
            // 
            // closeForm
            // 
            this.closeForm.BackColor = System.Drawing.Color.DarkBlue;
            this.closeForm.FlatAppearance.BorderSize = 0;
            this.closeForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.closeForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.closeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.closeForm.ForeColor = System.Drawing.SystemColors.Control;
            this.closeForm.Location = new System.Drawing.Point(782, 0);
            this.closeForm.Margin = new System.Windows.Forms.Padding(2);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(44, 40);
            this.closeForm.TabIndex = 1;
            this.closeForm.Text = "X";
            this.closeForm.UseVisualStyleBackColor = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.manageEmployees);
            this.tabControl.Controls.Add(this.atmsPage);
            this.tabControl.Controls.Add(this.carsPage);
            this.tabControl.Controls.Add(this.routesPage);
            this.tabControl.Location = new System.Drawing.Point(208, 10);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(617, 602);
            this.tabControl.TabIndex = 2;
            // 
            // manageEmployees
            // 
            this.manageEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.manageEmployees.Location = new System.Drawing.Point(4, 22);
            this.manageEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.manageEmployees.Name = "manageEmployees";
            this.manageEmployees.Padding = new System.Windows.Forms.Padding(2);
            this.manageEmployees.Size = new System.Drawing.Size(609, 576);
            this.manageEmployees.TabIndex = 0;
            // 
            // atmsPage
            // 
            this.atmsPage.Location = new System.Drawing.Point(4, 22);
            this.atmsPage.Margin = new System.Windows.Forms.Padding(2);
            this.atmsPage.Name = "atmsPage";
            this.atmsPage.Padding = new System.Windows.Forms.Padding(2);
            this.atmsPage.Size = new System.Drawing.Size(609, 576);
            this.atmsPage.TabIndex = 1;
            this.atmsPage.Text = "atmsPage";
            // 
            // carsPage
            // 
            this.carsPage.Location = new System.Drawing.Point(4, 22);
            this.carsPage.Name = "carsPage";
            this.carsPage.Size = new System.Drawing.Size(609, 576);
            this.carsPage.TabIndex = 2;
            // 
            // routesPage
            // 
            this.routesPage.Location = new System.Drawing.Point(4, 22);
            this.routesPage.Margin = new System.Windows.Forms.Padding(2);
            this.routesPage.Name = "routesPage";
            this.routesPage.Padding = new System.Windows.Forms.Padding(2);
            this.routesPage.Size = new System.Drawing.Size(609, 576);
            this.routesPage.TabIndex = 1;
            this.routesPage.Text = "RoutesPage";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonsPanel.Controls.Add(this.logoutBtn);
            this.buttonsPanel.Controls.Add(this.WiseAlgBtn);
            this.buttonsPanel.Controls.Add(this.ManageCars);
            this.buttonsPanel.Controls.Add(this.ManageRoutes);
            this.buttonsPanel.Controls.Add(this.ManageATMs);
            this.buttonsPanel.Controls.Add(this.ButtonSelector);
            this.buttonsPanel.Controls.Add(this.employees);
            this.buttonsPanel.Location = new System.Drawing.Point(-2, 38);
            this.buttonsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(229, 564);
            this.buttonsPanel.TabIndex = 1;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoutBtn.BackgroundImage")));
            this.logoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.logoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Location = new System.Drawing.Point(0, 505);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(50, 59);
            this.logoutBtn.TabIndex = 7;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // WiseAlgBtn
            // 
            this.WiseAlgBtn.Location = new System.Drawing.Point(0, 283);
            this.WiseAlgBtn.Margin = new System.Windows.Forms.Padding(2);
            this.WiseAlgBtn.Name = "WiseAlgBtn";
            this.WiseAlgBtn.Size = new System.Drawing.Size(206, 182);
            this.WiseAlgBtn.TabIndex = 6;
            this.WiseAlgBtn.Text = "Start Computing";
            this.WiseAlgBtn.UseVisualStyleBackColor = true;
            // 
            // ManageCars
            // 
            this.ManageCars.Location = new System.Drawing.Point(0, 149);
            this.ManageCars.Margin = new System.Windows.Forms.Padding(2);
            this.ManageCars.Name = "ManageCars";
            this.ManageCars.Size = new System.Drawing.Size(206, 63);
            this.ManageCars.TabIndex = 5;
            this.ManageCars.Text = "Cars";
            this.ManageCars.UseVisualStyleBackColor = true;
            this.ManageCars.Click += new System.EventHandler(this.ManageCars_Click);
            // 
            // ManageRoutes
            // 
            this.ManageRoutes.Location = new System.Drawing.Point(0, 216);
            this.ManageRoutes.Margin = new System.Windows.Forms.Padding(2);
            this.ManageRoutes.Name = "ManageRoutes";
            this.ManageRoutes.Size = new System.Drawing.Size(206, 63);
            this.ManageRoutes.TabIndex = 4;
            this.ManageRoutes.Text = "Tracks";
            this.ManageRoutes.UseVisualStyleBackColor = true;
            this.ManageRoutes.Click += new System.EventHandler(this.ManageRoutes_Click);
            // 
            // ManageATMs
            // 
            this.ManageATMs.Location = new System.Drawing.Point(0, 77);
            this.ManageATMs.Margin = new System.Windows.Forms.Padding(2);
            this.ManageATMs.Name = "ManageATMs";
            this.ManageATMs.Size = new System.Drawing.Size(206, 68);
            this.ManageATMs.TabIndex = 1;
            this.ManageATMs.Text = "ATMs";
            this.ManageATMs.UseVisualStyleBackColor = true;
            this.ManageATMs.Click += new System.EventHandler(this.ManageATMs_Click);
            // 
            // ButtonSelector
            // 
            this.ButtonSelector.BackColor = System.Drawing.Color.DarkBlue;
            this.ButtonSelector.Location = new System.Drawing.Point(205, -1);
            this.ButtonSelector.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSelector.Name = "ButtonSelector";
            this.ButtonSelector.Size = new System.Drawing.Size(24, 73);
            this.ButtonSelector.TabIndex = 3;
            // 
            // employees
            // 
            this.employees.Location = new System.Drawing.Point(0, -1);
            this.employees.Margin = new System.Windows.Forms.Padding(2);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(206, 74);
            this.employees.TabIndex = 2;
            this.employees.Text = "Employees";
            this.employees.UseVisualStyleBackColor = true;
            this.employees.Click += new System.EventHandler(this.employees_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(821, 602);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.formBorder);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminPage";
            this.Text = "NSecurity";
            this.formBorder.ResumeLayout(false);
            this.formBorder.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formBorder;
        private System.Windows.Forms.Label FrameLabel;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button employees;
        private System.Windows.Forms.Button ManageRoutes;
        private System.Windows.Forms.Button ManageATMs;
        private System.Windows.Forms.Panel ButtonSelector;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage manageEmployees;
        private System.Windows.Forms.TabPage atmsPage;
        private System.Windows.Forms.TabPage carsPage;
        private System.Windows.Forms.TabPage routesPage;
        private System.Windows.Forms.Button ManageCars;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button WiseAlgBtn;
    }
}

