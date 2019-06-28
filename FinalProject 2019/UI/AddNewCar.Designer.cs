namespace FinalProject_2019.UI {
    partial class AddNewCar {
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
            this.bigLabel = new System.Windows.Forms.Label();
            this.driverIdLabel = new System.Windows.Forms.Label();
            this.driverIdTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.creationDateTextBox = new System.Windows.Forms.TextBox();
            this.creationDateLabel = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.dateInstructionsLabel = new System.Windows.Forms.Label();
            this.createCarBtn = new System.Windows.Forms.Button();
            this.carIdTextBox = new System.Windows.Forms.TextBox();
            this.carIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bigLabel
            // 
            this.bigLabel.AutoSize = true;
            this.bigLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bigLabel.Location = new System.Drawing.Point(43, 38);
            this.bigLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bigLabel.Name = "bigLabel";
            this.bigLabel.Size = new System.Drawing.Size(119, 25);
            this.bigLabel.TabIndex = 0;
            this.bigLabel.Text = "Car\'s details";
            // 
            // driverIdLabel
            // 
            this.driverIdLabel.AutoSize = true;
            this.driverIdLabel.Location = new System.Drawing.Point(89, 138);
            this.driverIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.driverIdLabel.Name = "driverIdLabel";
            this.driverIdLabel.Size = new System.Drawing.Size(63, 17);
            this.driverIdLabel.TabIndex = 1;
            this.driverIdLabel.Text = "Driver ID";
            // 
            // driverIdTextBox
            // 
            this.driverIdTextBox.Location = new System.Drawing.Point(93, 158);
            this.driverIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.driverIdTextBox.Name = "driverIdTextBox";
            this.driverIdTextBox.Size = new System.Drawing.Size(132, 22);
            this.driverIdTextBox.TabIndex = 2;
            this.driverIdTextBox.TextChanged += new System.EventHandler(this.driverIdTextBox_TextChanged);
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(94, 223);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(132, 22);
            this.modelTextBox.TabIndex = 4;
            this.modelTextBox.TextChanged += new System.EventHandler(this.modelTextBox_TextChanged);
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(90, 204);
            this.modelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(46, 17);
            this.modelLabel.TabIndex = 3;
            this.modelLabel.Text = "Model";
            // 
            // creationDateTextBox
            // 
            this.creationDateTextBox.Location = new System.Drawing.Point(94, 291);
            this.creationDateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.creationDateTextBox.Name = "creationDateTextBox";
            this.creationDateTextBox.Size = new System.Drawing.Size(132, 22);
            this.creationDateTextBox.TabIndex = 6;
            this.creationDateTextBox.TextChanged += new System.EventHandler(this.creationDateTextBox_TextChanged);
            // 
            // creationDateLabel
            // 
            this.creationDateLabel.AutoSize = true;
            this.creationDateLabel.Location = new System.Drawing.Point(90, 271);
            this.creationDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.creationDateLabel.Name = "creationDateLabel";
            this.creationDateLabel.Size = new System.Drawing.Size(93, 17);
            this.creationDateLabel.TabIndex = 5;
            this.creationDateLabel.Text = "Creation date";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(94, 359);
            this.codeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(132, 22);
            this.codeTextBox.TabIndex = 8;
            this.codeTextBox.TextChanged += new System.EventHandler(this.codeTextBox_TextChanged);
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(90, 339);
            this.codeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(41, 17);
            this.codeLabel.TabIndex = 7;
            this.codeLabel.Text = "Code";
            // 
            // dateInstructionsLabel
            // 
            this.dateInstructionsLabel.AutoSize = true;
            this.dateInstructionsLabel.Location = new System.Drawing.Point(235, 295);
            this.dateInstructionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateInstructionsLabel.Name = "dateInstructionsLabel";
            this.dateInstructionsLabel.Size = new System.Drawing.Size(92, 17);
            this.dateInstructionsLabel.TabIndex = 9;
            this.dateInstructionsLabel.Text = "(dd/mm/yyyy)";
            // 
            // createCarBtn
            // 
            this.createCarBtn.Location = new System.Drawing.Point(303, 464);
            this.createCarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.createCarBtn.Name = "createCarBtn";
            this.createCarBtn.Size = new System.Drawing.Size(137, 77);
            this.createCarBtn.TabIndex = 10;
            this.createCarBtn.Text = "Create";
            this.createCarBtn.UseVisualStyleBackColor = true;
            this.createCarBtn.Click += new System.EventHandler(this.createCarBtn_Click);
            // 
            // carIdTextBox
            // 
            this.carIdTextBox.Location = new System.Drawing.Point(94, 97);
            this.carIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.carIdTextBox.Name = "carIdTextBox";
            this.carIdTextBox.ReadOnly = true;
            this.carIdTextBox.Size = new System.Drawing.Size(132, 22);
            this.carIdTextBox.TabIndex = 12;
            // 
            // carIDLabel
            // 
            this.carIDLabel.AutoSize = true;
            this.carIDLabel.Location = new System.Drawing.Point(90, 77);
            this.carIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carIDLabel.Name = "carIDLabel";
            this.carIDLabel.Size = new System.Drawing.Size(47, 17);
            this.carIDLabel.TabIndex = 11;
            this.carIDLabel.Text = "Car ID";
            // 
            // AddNewCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 554);
            this.Controls.Add(this.carIdTextBox);
            this.Controls.Add(this.carIDLabel);
            this.Controls.Add(this.createCarBtn);
            this.Controls.Add(this.dateInstructionsLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.creationDateTextBox);
            this.Controls.Add(this.creationDateLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.driverIdTextBox);
            this.Controls.Add(this.driverIdLabel);
            this.Controls.Add(this.bigLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNewCar";
            this.Text = "Add new car";
            this.Load += new System.EventHandler(this.AddNewCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bigLabel;
        private System.Windows.Forms.Label driverIdLabel;
        private System.Windows.Forms.TextBox driverIdTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TextBox creationDateTextBox;
        private System.Windows.Forms.Label creationDateLabel;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label dateInstructionsLabel;
        private System.Windows.Forms.Button createCarBtn;
        private System.Windows.Forms.TextBox carIdTextBox;
        private System.Windows.Forms.Label carIDLabel;
    }
}