﻿
namespace OffSyncPasswordManager
{
    partial class EnterMasterKey
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterMasterKey));
            this.label1 = new System.Windows.Forms.Label();
            this.MasterKeyEntry = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Enter Master Key:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MasterKeyEntry
            // 
            this.MasterKeyEntry.Location = new System.Drawing.Point(12, 42);
            this.MasterKeyEntry.Name = "MasterKeyEntry";
            this.MasterKeyEntry.PasswordChar = '*';
            this.MasterKeyEntry.Size = new System.Drawing.Size(284, 23);
            this.MasterKeyEntry.TabIndex = 0;
            this.MasterKeyEntry.UseSystemPasswordChar = true;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(115, 71);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EnterMasterKey
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(309, 111);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.MasterKeyEntry);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterMasterKey";
            this.Text = "Enter Master Key";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MasterKeyEntry;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Timer timer1;
    }
}