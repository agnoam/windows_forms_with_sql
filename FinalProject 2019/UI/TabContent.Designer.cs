namespace FinalProject_2019.UI {
    partial class TabContent {
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
            this.components = new System.ComponentModel.Container();
            this.addATMButton = new System.Windows.Forms.Button();
            this.atmsGridView = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.atmsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // addATMButton
            // 
            this.addATMButton.Location = new System.Drawing.Point(538, 27);
            this.addATMButton.Margin = new System.Windows.Forms.Padding(2);
            this.addATMButton.Name = "addATMButton";
            this.addATMButton.Size = new System.Drawing.Size(56, 19);
            this.addATMButton.TabIndex = 0;
            this.addATMButton.Text = "+";
            this.addATMButton.UseVisualStyleBackColor = true;
            this.addATMButton.Click += new System.EventHandler(this.addATM_Click);
            // 
            // atmsGridView
            // 
            this.atmsGridView.AllowUserToAddRows = false;
            this.atmsGridView.AllowUserToDeleteRows = false;
            this.atmsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.atmsGridView.Location = new System.Drawing.Point(65, 69);
            this.atmsGridView.Name = "atmsGridView";
            this.atmsGridView.Size = new System.Drawing.Size(528, 487);
            this.atmsGridView.TabIndex = 1;
            this.atmsGridView.SelectionChanged += new System.EventHandler(this.atmsGridView_SelectionChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(478, 27);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(56, 19);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "-";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(418, 27);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(56, 19);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "🔄";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // AtmsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 585);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.atmsGridView);
            this.Controls.Add(this.addATMButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AtmsTab";
            this.Text = "AtmsTab";
            ((System.ComponentModel.ISupportInitialize)(this.atmsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addATMButton;
        private System.Windows.Forms.DataGridView atmsGridView;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
    }
}