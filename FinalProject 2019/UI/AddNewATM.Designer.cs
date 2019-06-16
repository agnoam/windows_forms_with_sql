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
            this.atmStreet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.houseNum = new System.Windows.Forms.Label();
            this.atmHouseNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.atmCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.atmZipCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addNewATMButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.atmBrand = new System.Windows.Forms.TextBox();
            this.atmCapacity = new System.Windows.Forms.TextBox();
            this.wideATM = new System.Windows.Forms.RadioButton();
            this.singleATM = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // atmStreet
            // 
            this.atmStreet.Location = new System.Drawing.Point(52, 94);
            this.atmStreet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.atmStreet.Name = "atmStreet";
            this.atmStreet.Size = new System.Drawing.Size(132, 22);
            this.atmStreet.TabIndex = 0;
            this.atmStreet.TextChanged += new System.EventHandler(this.atmStreet_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ATM\'s address";
            // 
            // houseNum
            // 
            this.houseNum.AutoSize = true;
            this.houseNum.Location = new System.Drawing.Point(48, 130);
            this.houseNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.houseNum.Name = "houseNum";
            this.houseNum.Size = new System.Drawing.Size(101, 17);
            this.houseNum.TabIndex = 3;
            this.houseNum.Text = "House number";
            // 
            // atmHouseNum
            // 
            this.atmHouseNum.Location = new System.Drawing.Point(52, 150);
            this.atmHouseNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.atmHouseNum.Name = "atmHouseNum";
            this.atmHouseNum.Size = new System.Drawing.Size(132, 22);
            this.atmHouseNum.TabIndex = 2;
            this.atmHouseNum.TextChanged += new System.EventHandler(this.atmHouseNum_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Street";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "City";
            // 
            // atmCity
            // 
            this.atmCity.Location = new System.Drawing.Point(52, 208);
            this.atmCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.atmCity.Name = "atmCity";
            this.atmCity.Size = new System.Drawing.Size(132, 22);
            this.atmCity.TabIndex = 5;
            this.atmCity.TextChanged += new System.EventHandler(this.atmCity_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "ZIP code";
            // 
            // atmZipCode
            // 
            this.atmZipCode.Location = new System.Drawing.Point(52, 266);
            this.atmZipCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.atmZipCode.Name = "atmZipCode";
            this.atmZipCode.Size = new System.Drawing.Size(132, 22);
            this.atmZipCode.TabIndex = 7;
            this.atmZipCode.TextChanged += new System.EventHandler(this.atmZipCode_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "ATM\'s details";
            // 
            // addNewATMButton
            // 
            this.addNewATMButton.Location = new System.Drawing.Point(684, 407);
            this.addNewATMButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addNewATMButton.Name = "addNewATMButton";
            this.addNewATMButton.Size = new System.Drawing.Size(100, 28);
            this.addNewATMButton.TabIndex = 10;
            this.addNewATMButton.Text = "Submit";
            this.addNewATMButton.UseVisualStyleBackColor = true;
            this.addNewATMButton.Click += new System.EventHandler(this.addNewATMButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Capacity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Brand";
            // 
            // atmBrand
            // 
            this.atmBrand.Location = new System.Drawing.Point(319, 150);
            this.atmBrand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.atmBrand.Name = "atmBrand";
            this.atmBrand.Size = new System.Drawing.Size(132, 22);
            this.atmBrand.TabIndex = 12;
            this.atmBrand.TextChanged += new System.EventHandler(this.atmBrand_TextChanged);
            // 
            // atmCapacity
            // 
            this.atmCapacity.Location = new System.Drawing.Point(319, 94);
            this.atmCapacity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.atmCapacity.Name = "atmCapacity";
            this.atmCapacity.Size = new System.Drawing.Size(132, 22);
            this.atmCapacity.TabIndex = 11;
            this.atmCapacity.TextChanged += new System.EventHandler(this.atmCapacity_TextChanged);
            // 
            // wideATM
            // 
            this.wideATM.AutoSize = true;
            this.wideATM.Location = new System.Drawing.Point(319, 208);
            this.wideATM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wideATM.Name = "wideATM";
            this.wideATM.Size = new System.Drawing.Size(135, 21);
            this.wideATM.TabIndex = 15;
            this.wideATM.TabStop = true;
            this.wideATM.Text = "Wide ATM (Wall)";
            this.wideATM.UseVisualStyleBackColor = true;
            this.wideATM.CheckedChanged += new System.EventHandler(this.wideATM_CheckedChanged);
            // 
            // singleATM
            // 
            this.singleATM.AutoSize = true;
            this.singleATM.Location = new System.Drawing.Point(468, 208);
            this.singleATM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.singleATM.Name = "singleATM";
            this.singleATM.Size = new System.Drawing.Size(143, 21);
            this.singleATM.TabIndex = 16;
            this.singleATM.TabStop = true;
            this.singleATM.Text = "Thin ATM (Single)";
            this.singleATM.UseVisualStyleBackColor = true;
            this.singleATM.CheckedChanged += new System.EventHandler(this.singleATM_CheckedChanged);
            // 
            // AddNewATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.singleATM);
            this.Controls.Add(this.wideATM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.atmBrand);
            this.Controls.Add(this.atmCapacity);
            this.Controls.Add(this.addNewATMButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.atmZipCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.atmCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.houseNum);
            this.Controls.Add(this.atmHouseNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.atmStreet);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddNewATM";
            this.Text = "Add new ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox atmStreet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label houseNum;
        private System.Windows.Forms.TextBox atmHouseNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox atmCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox atmZipCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addNewATMButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox atmBrand;
        private System.Windows.Forms.TextBox atmCapacity;
        private System.Windows.Forms.RadioButton wideATM;
        private System.Windows.Forms.RadioButton singleATM;
    }
}