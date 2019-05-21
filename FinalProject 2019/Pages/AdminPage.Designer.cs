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
            this.formBorder = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FrameLabel = new System.Windows.Forms.Label();
            this.closeForm = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.manageEmployees = new System.Windows.Forms.TabPage();
            this.atmsPage = new System.Windows.Forms.TabPage();
            this.routesPage = new System.Windows.Forms.TabPage();
            this.buttonsPanel = new System.Windows.Forms.Panel();
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
            this.formBorder.Name = "formBorder";
            this.formBorder.Size = new System.Drawing.Size(1101, 49);
            this.formBorder.TabIndex = 0;
            this.formBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formBorder_MouseDown);
            this.formBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formBorder_MouseMove);
            this.formBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formBorder_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(295, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 210);
            this.panel1.TabIndex = 3;
            // 
            // FrameLabel
            // 
            this.FrameLabel.AutoSize = true;
            this.FrameLabel.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.FrameLabel.Location = new System.Drawing.Point(14, 11);
            this.FrameLabel.Name = "FrameLabel";
            this.FrameLabel.Size = new System.Drawing.Size(115, 28);
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
            this.closeForm.Location = new System.Drawing.Point(1043, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(58, 49);
            this.closeForm.TabIndex = 1;
            this.closeForm.Text = "X";
            this.closeForm.UseVisualStyleBackColor = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.manageEmployees);
            this.tabControl.Controls.Add(this.atmsPage);
            this.tabControl.Controls.Add(this.routesPage);
            this.tabControl.Location = new System.Drawing.Point(278, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(823, 741);
            this.tabControl.TabIndex = 2;
            // 
            // manageEmployees
            // 
            this.manageEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.manageEmployees.Location = new System.Drawing.Point(4, 25);
            this.manageEmployees.Name = "manageEmployees";
            this.manageEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.manageEmployees.Size = new System.Drawing.Size(813, 702);
            this.manageEmployees.TabIndex = 0;
            // 
            // atmsPage
            // 
            this.atmsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(232)))));
            this.atmsPage.Location = new System.Drawing.Point(4, 25);
            this.atmsPage.Name = "atmsPage";
            this.atmsPage.Padding = new System.Windows.Forms.Padding(3);
            this.atmsPage.Size = new System.Drawing.Size(813, 702);
            this.atmsPage.TabIndex = 1;
            this.atmsPage.Text = "atmsPage";
            this.atmsPage.Controls.Add(null);
            // 
            // routesPage
            // 
            this.routesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.routesPage.Location = new System.Drawing.Point(4, 25);
            this.routesPage.Name = "routesPage";
            this.routesPage.Padding = new System.Windows.Forms.Padding(3);
            this.routesPage.Size = new System.Drawing.Size(813, 702);
            this.routesPage.TabIndex = 1;
            this.routesPage.Text = "RoutesPage";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonsPanel.Controls.Add(this.ManageRoutes);
            this.buttonsPanel.Controls.Add(this.ManageATMs);
            this.buttonsPanel.Controls.Add(this.ButtonSelector);
            this.buttonsPanel.Controls.Add(this.employees);
            this.buttonsPanel.Location = new System.Drawing.Point(-2, 47);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(305, 694);
            this.buttonsPanel.TabIndex = 1;
            // 
            // ManageRoutes
            // 
            this.ManageRoutes.Location = new System.Drawing.Point(0, 455);
            this.ManageRoutes.Name = "ManageRoutes";
            this.ManageRoutes.Size = new System.Drawing.Size(274, 212);
            this.ManageRoutes.TabIndex = 4;
            this.ManageRoutes.Text = "Routes";
            this.ManageRoutes.UseVisualStyleBackColor = true;
            this.ManageRoutes.Click += new System.EventHandler(this.ManageRoutes_Click);
            // 
            // ManageATMs
            // 
            this.ManageATMs.Location = new System.Drawing.Point(0, 225);
            this.ManageATMs.Name = "ManageATMs";
            this.ManageATMs.Size = new System.Drawing.Size(274, 212);
            this.ManageATMs.TabIndex = 1;
            this.ManageATMs.Text = "ATMs";
            this.ManageATMs.UseVisualStyleBackColor = true;
            this.ManageATMs.Click += new System.EventHandler(this.ManageATMs_Click);
            // 
            // ButtonSelector
            // 
            this.ButtonSelector.BackColor = System.Drawing.Color.DarkBlue;
            this.ButtonSelector.Location = new System.Drawing.Point(273, -1);
            this.ButtonSelector.Name = "ButtonSelector";
            this.ButtonSelector.Size = new System.Drawing.Size(32, 210);
            this.ButtonSelector.TabIndex = 3;
            // 
            // employees
            // 
            this.employees.Location = new System.Drawing.Point(0, -1);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(274, 212);
            this.employees.TabIndex = 2;
            this.employees.Text = "Manage employees";
            this.employees.UseVisualStyleBackColor = true;
            this.employees.Click += new System.EventHandler(this.employees_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1095, 741);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.formBorder);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.TabPage routesPage;
    }
}

