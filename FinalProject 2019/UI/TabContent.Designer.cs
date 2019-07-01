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
            this.showTrackButton = new System.Windows.Forms.Button();
            this.filledATMsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.atmsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // addATMButton
            // 
            this.addATMButton.Location = new System.Drawing.Point(717, 33);
            this.addATMButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addATMButton.Name = "addATMButton";
            this.addATMButton.Size = new System.Drawing.Size(75, 23);
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
            this.atmsGridView.Location = new System.Drawing.Point(87, 85);
            this.atmsGridView.Margin = new System.Windows.Forms.Padding(4);
            this.atmsGridView.Name = "atmsGridView";
            this.atmsGridView.Size = new System.Drawing.Size(704, 599);
            this.atmsGridView.TabIndex = 1;
            this.atmsGridView.SelectionChanged += new System.EventHandler(this.atmsGridView_SelectionChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(637, 33);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "-";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(557, 33);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "🔄";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // showTrackButton
            // 
            this.showTrackButton.Location = new System.Drawing.Point(476, 33);
            this.showTrackButton.Name = "showTrackButton";
            this.showTrackButton.Size = new System.Drawing.Size(75, 23);
            this.showTrackButton.TabIndex = 4;
            this.showTrackButton.Text = "Show";
            this.showTrackButton.UseVisualStyleBackColor = true;
            this.showTrackButton.Click += new System.EventHandler(this.showTrackButton_Click);
            // 
            // filledATMsLabel
            // 
            this.filledATMsLabel.AutoSize = true;
            this.filledATMsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.filledATMsLabel.Location = new System.Drawing.Point(44, 36);
            this.filledATMsLabel.Name = "filledATMsLabel";
            this.filledATMsLabel.Size = new System.Drawing.Size(332, 34);
            this.filledATMsLabel.TabIndex = 5;
            this.filledATMsLabel.Text = "Filled ATMs: 28,  EmptyATMs: 12, Total ATMs: 125 \r\nCurrent money: 120 / 150";
            // 
            // TabContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 720);
            this.Controls.Add(this.filledATMsLabel);
            this.Controls.Add(this.showTrackButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.atmsGridView);
            this.Controls.Add(this.addATMButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TabContent";
            this.Text = "AtmsTab";
            this.Load += new System.EventHandler(this.TabContent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atmsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addATMButton;
        private System.Windows.Forms.DataGridView atmsGridView;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button showTrackButton;
        private System.Windows.Forms.Label filledATMsLabel;
    }
}