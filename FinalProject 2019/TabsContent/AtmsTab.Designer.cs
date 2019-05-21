namespace FinalProject_2019.TabsContent {
    partial class AtmsTab {
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
            this.addATM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addATM
            // 
            this.addATM.Location = new System.Drawing.Point(13, 13);
            this.addATM.Name = "addATM";
            this.addATM.Size = new System.Drawing.Size(75, 23);
            this.addATM.TabIndex = 0;
            this.addATM.Text = "new ATM";
            this.addATM.UseVisualStyleBackColor = true;
            this.addATM.Click += new System.EventHandler(this.addATM_Click);
            // 
            // AtmsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addATM);
            this.Name = "AtmsTab";
            this.Text = "AtmsTab";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addATM;
    }
}