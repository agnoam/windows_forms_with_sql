﻿using System;
using System.Windows.Forms;

namespace FinalProject_2019.Pages {
    partial class MapPage {
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
            this.formBorder.SuspendLayout();
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
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1095, 741);
            this.Controls.Add(this.formBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPage";
            this.Text = "NSecurity";
            this.formBorder.ResumeLayout(false);
            this.formBorder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formBorder;
        private System.Windows.Forms.Label FrameLabel;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.Panel panel1;
    }
}