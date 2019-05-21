namespace FinalProject_2019.TabsContent {
    partial class EmployeesTab {
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
            this.addEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addEmployee
            // 
            this.addEmployee.Location = new System.Drawing.Point(713, 12);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(75, 23);
            this.addEmployee.TabIndex = 0;
            this.addEmployee.Text = "+";
            this.addEmployee.UseVisualStyleBackColor = true;
            // 
            // EmployeesTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.addEmployee);
            this.Name = "EmployeesTab";
            this.Text = "EmployeesTab";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addEmployee;
    }
}