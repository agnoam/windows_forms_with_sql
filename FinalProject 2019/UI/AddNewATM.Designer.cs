namespace FinalProject_2019.UI {
    partial class AddNewATM {
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
            this.atmStreetTextBox = new System.Windows.Forms.TextBox();
            this.grandLabel = new System.Windows.Forms.Label();
            this.houseNumLabel = new System.Windows.Forms.Label();
            this.atmHouseNumTextBox = new System.Windows.Forms.TextBox();
            this.streetLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.atmCityTextBox = new System.Windows.Forms.TextBox();
            this.zipcodeLabel = new System.Windows.Forms.Label();
            this.atmZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.secondGrandLabel = new System.Windows.Forms.Label();
            this.addNewATMButton = new System.Windows.Forms.Button();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.atmBrandTextBox = new System.Windows.Forms.TextBox();
            this.atmCapacity = new System.Windows.Forms.TextBox();
            this.wideATM_Radio = new System.Windows.Forms.RadioButton();
            this.singleATM_Radio = new System.Windows.Forms.RadioButton();
            this.atmIdLabel = new System.Windows.Forms.Label();
            this.atmIdTextBox = new System.Windows.Forms.TextBox();
            this.LngLabel = new System.Windows.Forms.Label();
            this.LngTextBox = new System.Windows.Forms.TextBox();
            this.LatLabel = new System.Windows.Forms.Label();
            this.LatTextBox = new System.Windows.Forms.TextBox();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // atmStreetTextBox
            // 
            this.atmStreetTextBox.Location = new System.Drawing.Point(52, 94);
            this.atmStreetTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.atmStreetTextBox.Name = "atmStreetTextBox";
            this.atmStreetTextBox.Size = new System.Drawing.Size(132, 22);
            this.atmStreetTextBox.TabIndex = 0;
            this.atmStreetTextBox.TextChanged += new System.EventHandler(this.atmStreet_TextChanged);
            // 
            // grandLabel
            // 
            this.grandLabel.AutoSize = true;
            this.grandLabel.Location = new System.Drawing.Point(12, 36);
            this.grandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.grandLabel.Name = "grandLabel";
            this.grandLabel.Size = new System.Drawing.Size(102, 17);
            this.grandLabel.TabIndex = 1;
            this.grandLabel.Text = "ATM\'s address";
            // 
            // houseNumLabel
            // 
            this.houseNumLabel.AutoSize = true;
            this.houseNumLabel.Location = new System.Drawing.Point(48, 130);
            this.houseNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.houseNumLabel.Name = "houseNumLabel";
            this.houseNumLabel.Size = new System.Drawing.Size(101, 17);
            this.houseNumLabel.TabIndex = 3;
            this.houseNumLabel.Text = "House number";
            // 
            // atmHouseNumTextBox
            // 
            this.atmHouseNumTextBox.Location = new System.Drawing.Point(52, 150);
            this.atmHouseNumTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.atmHouseNumTextBox.Name = "atmHouseNumTextBox";
            this.atmHouseNumTextBox.Size = new System.Drawing.Size(132, 22);
            this.atmHouseNumTextBox.TabIndex = 2;
            this.atmHouseNumTextBox.TextChanged += new System.EventHandler(this.atmHouseNum_TextChanged);
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(48, 74);
            this.streetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(46, 17);
            this.streetLabel.TabIndex = 4;
            this.streetLabel.Text = "Street";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(48, 188);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(31, 17);
            this.cityLabel.TabIndex = 6;
            this.cityLabel.Text = "City";
            // 
            // atmCityTextBox
            // 
            this.atmCityTextBox.Location = new System.Drawing.Point(52, 208);
            this.atmCityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.atmCityTextBox.Name = "atmCityTextBox";
            this.atmCityTextBox.Size = new System.Drawing.Size(132, 22);
            this.atmCityTextBox.TabIndex = 5;
            this.atmCityTextBox.TextChanged += new System.EventHandler(this.atmCity_TextChanged);
            // 
            // zipcodeLabel
            // 
            this.zipcodeLabel.AutoSize = true;
            this.zipcodeLabel.Location = new System.Drawing.Point(48, 246);
            this.zipcodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zipcodeLabel.Name = "zipcodeLabel";
            this.zipcodeLabel.Size = new System.Drawing.Size(64, 17);
            this.zipcodeLabel.TabIndex = 8;
            this.zipcodeLabel.Text = "ZIP code";
            // 
            // atmZipCodeTextBox
            // 
            this.atmZipCodeTextBox.Location = new System.Drawing.Point(52, 266);
            this.atmZipCodeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.atmZipCodeTextBox.Name = "atmZipCodeTextBox";
            this.atmZipCodeTextBox.Size = new System.Drawing.Size(132, 22);
            this.atmZipCodeTextBox.TabIndex = 7;
            this.atmZipCodeTextBox.TextChanged += new System.EventHandler(this.atmZipCode_TextChanged);
            // 
            // secondGrandLabel
            // 
            this.secondGrandLabel.AutoSize = true;
            this.secondGrandLabel.Location = new System.Drawing.Point(279, 34);
            this.secondGrandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secondGrandLabel.Name = "secondGrandLabel";
            this.secondGrandLabel.Size = new System.Drawing.Size(92, 17);
            this.secondGrandLabel.TabIndex = 9;
            this.secondGrandLabel.Text = "ATM\'s details";
            // 
            // addNewATMButton
            // 
            this.addNewATMButton.Location = new System.Drawing.Point(684, 407);
            this.addNewATMButton.Margin = new System.Windows.Forms.Padding(4);
            this.addNewATMButton.Name = "addNewATMButton";
            this.addNewATMButton.Size = new System.Drawing.Size(100, 28);
            this.addNewATMButton.TabIndex = 10;
            this.addNewATMButton.Text = "Submit";
            this.addNewATMButton.UseVisualStyleBackColor = true;
            this.addNewATMButton.Click += new System.EventHandler(this.addNewATMButton_Click);
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Location = new System.Drawing.Point(311, 74);
            this.capacityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(62, 17);
            this.capacityLabel.TabIndex = 14;
            this.capacityLabel.Text = "Capacity";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(311, 130);
            this.brandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(46, 17);
            this.brandLabel.TabIndex = 13;
            this.brandLabel.Text = "Brand";
            // 
            // atmBrandTextBox
            // 
            this.atmBrandTextBox.Location = new System.Drawing.Point(315, 150);
            this.atmBrandTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.atmBrandTextBox.Name = "atmBrandTextBox";
            this.atmBrandTextBox.Size = new System.Drawing.Size(132, 22);
            this.atmBrandTextBox.TabIndex = 12;
            this.atmBrandTextBox.TextChanged += new System.EventHandler(this.atmBrand_TextChanged);
            // 
            // atmCapacity
            // 
            this.atmCapacity.Location = new System.Drawing.Point(315, 94);
            this.atmCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.atmCapacity.Name = "atmCapacity";
            this.atmCapacity.Size = new System.Drawing.Size(132, 22);
            this.atmCapacity.TabIndex = 11;
            this.atmCapacity.TextChanged += new System.EventHandler(this.atmCapacity_TextChanged);
            // 
            // wideATM_Radio
            // 
            this.wideATM_Radio.AutoSize = true;
            this.wideATM_Radio.Location = new System.Drawing.Point(315, 208);
            this.wideATM_Radio.Margin = new System.Windows.Forms.Padding(4);
            this.wideATM_Radio.Name = "wideATM_Radio";
            this.wideATM_Radio.Size = new System.Drawing.Size(135, 21);
            this.wideATM_Radio.TabIndex = 15;
            this.wideATM_Radio.TabStop = true;
            this.wideATM_Radio.Text = "Wide ATM (Wall)";
            this.wideATM_Radio.UseVisualStyleBackColor = true;
            this.wideATM_Radio.CheckedChanged += new System.EventHandler(this.wideATM_CheckedChanged);
            // 
            // singleATM_Radio
            // 
            this.singleATM_Radio.AutoSize = true;
            this.singleATM_Radio.Location = new System.Drawing.Point(464, 208);
            this.singleATM_Radio.Margin = new System.Windows.Forms.Padding(4);
            this.singleATM_Radio.Name = "singleATM_Radio";
            this.singleATM_Radio.Size = new System.Drawing.Size(143, 21);
            this.singleATM_Radio.TabIndex = 16;
            this.singleATM_Radio.TabStop = true;
            this.singleATM_Radio.Text = "Thin ATM (Single)";
            this.singleATM_Radio.UseVisualStyleBackColor = true;
            this.singleATM_Radio.CheckedChanged += new System.EventHandler(this.singleATM_CheckedChanged);
            // 
            // atmIdLabel
            // 
            this.atmIdLabel.AutoSize = true;
            this.atmIdLabel.Location = new System.Drawing.Point(0, 0);
            this.atmIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.atmIdLabel.Name = "atmIdLabel";
            this.atmIdLabel.Size = new System.Drawing.Size(0, 17);
            this.atmIdLabel.TabIndex = 18;
            // 
            // atmIdTextBox
            // 
            this.atmIdTextBox.Location = new System.Drawing.Point(0, 0);
            this.atmIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.atmIdTextBox.Name = "atmIdTextBox";
            this.atmIdTextBox.Size = new System.Drawing.Size(0, 22);
            this.atmIdTextBox.TabIndex = 17;
            // 
            // LngLabel
            // 
            this.LngLabel.AutoSize = true;
            this.LngLabel.Location = new System.Drawing.Point(48, 361);
            this.LngLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LngLabel.Name = "LngLabel";
            this.LngLabel.Size = new System.Drawing.Size(142, 17);
            this.LngLabel.TabIndex = 22;
            this.LngLabel.Text = "Longitude coordinate";
            // 
            // LngTextBox
            // 
            this.LngTextBox.Location = new System.Drawing.Point(52, 381);
            this.LngTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LngTextBox.Name = "LngTextBox";
            this.LngTextBox.Size = new System.Drawing.Size(132, 22);
            this.LngTextBox.TabIndex = 21;
            this.LngTextBox.TextChanged += new System.EventHandler(this.LngTextBox_TextChanged);
            // 
            // LatLabel
            // 
            this.LatLabel.AutoSize = true;
            this.LatLabel.Location = new System.Drawing.Point(48, 303);
            this.LatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LatLabel.Name = "LatLabel";
            this.LatLabel.Size = new System.Drawing.Size(130, 17);
            this.LatLabel.TabIndex = 20;
            this.LatLabel.Text = "Latitude coordinate";
            // 
            // LatTextBox
            // 
            this.LatTextBox.Location = new System.Drawing.Point(52, 323);
            this.LatTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LatTextBox.Name = "LatTextBox";
            this.LatTextBox.Size = new System.Drawing.Size(132, 22);
            this.LatTextBox.TabIndex = 19;
            this.LatTextBox.TextChanged += new System.EventHandler(this.LatTextBox_TextChanged);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(197, 344);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(171, 34);
            this.instructionsLabel.TabIndex = 23;
            this.instructionsLabel.Text = "Must be number with 8\r\nfigures after decimal point";
            // 
            // AddNewATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.LngLabel);
            this.Controls.Add(this.LngTextBox);
            this.Controls.Add(this.LatLabel);
            this.Controls.Add(this.LatTextBox);
            this.Controls.Add(this.atmIdLabel);
            this.Controls.Add(this.atmIdTextBox);
            this.Controls.Add(this.singleATM_Radio);
            this.Controls.Add(this.wideATM_Radio);
            this.Controls.Add(this.capacityLabel);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.atmBrandTextBox);
            this.Controls.Add(this.atmCapacity);
            this.Controls.Add(this.addNewATMButton);
            this.Controls.Add(this.secondGrandLabel);
            this.Controls.Add(this.zipcodeLabel);
            this.Controls.Add(this.atmZipCodeTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.atmCityTextBox);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.houseNumLabel);
            this.Controls.Add(this.atmHouseNumTextBox);
            this.Controls.Add(this.grandLabel);
            this.Controls.Add(this.atmStreetTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddNewATM";
            this.Text = "Add new ATM";
            this.Load += new System.EventHandler(this.AddNewATM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox atmStreetTextBox;
        private System.Windows.Forms.Label grandLabel;
        private System.Windows.Forms.Label houseNumLabel;
        private System.Windows.Forms.TextBox atmHouseNumTextBox;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox atmCityTextBox;
        private System.Windows.Forms.Label zipcodeLabel;
        private System.Windows.Forms.TextBox atmZipCodeTextBox;
        private System.Windows.Forms.Label secondGrandLabel;
        private System.Windows.Forms.Button addNewATMButton;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.TextBox atmBrandTextBox;
        private System.Windows.Forms.TextBox atmCapacity;
        private System.Windows.Forms.RadioButton wideATM_Radio;
        private System.Windows.Forms.RadioButton singleATM_Radio;
        private System.Windows.Forms.Label atmIdLabel;
        private System.Windows.Forms.TextBox atmIdTextBox;
        private System.Windows.Forms.Label LngLabel;
        private System.Windows.Forms.TextBox LngTextBox;
        private System.Windows.Forms.Label LatLabel;
        private System.Windows.Forms.TextBox LatTextBox;
        private System.Windows.Forms.Label instructionsLabel;
    }
}