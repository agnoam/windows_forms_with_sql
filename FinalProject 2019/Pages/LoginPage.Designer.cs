namespace FinalProject_2019 {
    partial class LoginPage {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.closeForm = new System.Windows.Forms.Button();
            this.formBorder = new System.Windows.Forms.Panel();
            this.FrameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.signInBtn = new System.Windows.Forms.Button();
            this.showPasswordBtn = new System.Windows.Forms.Button();
            this.formBorder.SuspendLayout();
            this.SuspendLayout();
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
            this.closeForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(44, 40);
            this.closeForm.TabIndex = 1;
            this.closeForm.Text = "X";
            this.closeForm.UseVisualStyleBackColor = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // formBorder
            // 
            this.formBorder.BackColor = System.Drawing.Color.DarkBlue;
            this.formBorder.Controls.Add(this.FrameLabel);
            this.formBorder.Controls.Add(this.closeForm);
            this.formBorder.Location = new System.Drawing.Point(-2, -2);
            this.formBorder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.formBorder.Name = "formBorder";
            this.formBorder.Size = new System.Drawing.Size(826, 40);
            this.formBorder.TabIndex = 0;
            this.formBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formBorder_MouseDown);
            this.formBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formBorder_MouseMove);
            this.formBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formBorder_MouseUp);
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
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.usernameTextBox.Location = new System.Drawing.Point(286, 169);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(252, 30);
            this.usernameTextBox.TabIndex = 2;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usernameLabel.Location = new System.Drawing.Point(284, 144);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(77, 17);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwordLabel.Location = new System.Drawing.Point(284, 258);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 17);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.passwordTextBox.Location = new System.Drawing.Point(286, 283);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(252, 30);
            this.passwordTextBox.TabIndex = 6;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // signInBtn
            // 
            this.signInBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.signInBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.signInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.signInBtn.Image = ((System.Drawing.Image)(resources.GetObject("signInBtn.Image")));
            this.signInBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signInBtn.Location = new System.Drawing.Point(602, 481);
            this.signInBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(203, 101);
            this.signInBtn.TabIndex = 1;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Visible = false;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // showPasswordBtn
            // 
            this.showPasswordBtn.BackColor = System.Drawing.Color.Transparent;
            this.showPasswordBtn.BackgroundImage = global::FinalProject_2019.Properties.Resources.hide;
            this.showPasswordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.showPasswordBtn.FlatAppearance.BorderSize = 0;
            this.showPasswordBtn.Location = new System.Drawing.Point(504, 284);
            this.showPasswordBtn.Margin = new System.Windows.Forms.Padding(2);
            this.showPasswordBtn.Name = "showPasswordBtn";
            this.showPasswordBtn.Size = new System.Drawing.Size(32, 28);
            this.showPasswordBtn.TabIndex = 8;
            this.showPasswordBtn.UseVisualStyleBackColor = false;
            this.showPasswordBtn.Visible = false;
            this.showPasswordBtn.Click += new System.EventHandler(this.showPasswordBtn_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(821, 602);
            this.Controls.Add(this.showPasswordBtn);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.formBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginPage";
            this.Text = "NSecurity";
            this.formBorder.ResumeLayout(false);
            this.formBorder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.Panel formBorder;
        private System.Windows.Forms.Label FrameLabel;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button showPasswordBtn;
    }
}