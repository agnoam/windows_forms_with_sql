namespace FinalProject_2019.UI {
    partial class WithdrawalsDemo {
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
            this.startLabel = new System.Windows.Forms.Label();
            this.StratDayPicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(13, 13);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(181, 17);
            this.startLabel.TabIndex = 0;
            this.startLabel.Text = "Starting date of withdrawals";
            // 
            // StratDayPicker
            // 
            this.StratDayPicker.Location = new System.Drawing.Point(16, 34);
            this.StratDayPicker.Name = "StratDayPicker";
            this.StratDayPicker.Size = new System.Drawing.Size(200, 22);
            this.StratDayPicker.TabIndex = 1;
            this.StratDayPicker.ValueChanged += new System.EventHandler(this.StratDayPicker_ValueChanged);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(287, 34);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 22);
            this.endDatePicker.TabIndex = 2;
            this.endDatePicker.ValueChanged += new System.EventHandler(this.endDatePicker_ValueChanged);
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(284, 14);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(157, 17);
            this.endLabel.TabIndex = 3;
            this.endLabel.Text = "End date of withdrawals";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(447, 243);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(121, 56);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Calculate";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // WithdrawalsDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 311);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.StratDayPicker);
            this.Controls.Add(this.startLabel);
            this.Name = "WithdrawalsDemo";
            this.Text = "WithdrawalsDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.DateTimePicker StratDayPicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Button StartButton;
    }
}