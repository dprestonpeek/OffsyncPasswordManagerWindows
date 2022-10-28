
namespace OffSyncPasswordManager
{
    partial class ChangeKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeKey));
            this.PreviousKeyLabel = new System.Windows.Forms.Label();
            this.PreviousKey = new System.Windows.Forms.TextBox();
            this.NewKey1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewKey2 = new System.Windows.Forms.TextBox();
            this.ChangeKeyButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviousKeyLabel
            // 
            this.PreviousKeyLabel.AutoSize = true;
            this.PreviousKeyLabel.Location = new System.Drawing.Point(19, 9);
            this.PreviousKeyLabel.Name = "PreviousKeyLabel";
            this.PreviousKeyLabel.Size = new System.Drawing.Size(107, 15);
            this.PreviousKeyLabel.TabIndex = 3;
            this.PreviousKeyLabel.Text = "Enter Previous Key:";
            this.PreviousKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PreviousKey
            // 
            this.PreviousKey.Location = new System.Drawing.Point(19, 27);
            this.PreviousKey.Name = "PreviousKey";
            this.PreviousKey.PasswordChar = '*';
            this.PreviousKey.Size = new System.Drawing.Size(272, 23);
            this.PreviousKey.TabIndex = 4;
            this.PreviousKey.UseSystemPasswordChar = true;
            // 
            // NewKey1
            // 
            this.NewKey1.Location = new System.Drawing.Point(6, 22);
            this.NewKey1.Name = "NewKey1";
            this.NewKey1.PasswordChar = '*';
            this.NewKey1.Size = new System.Drawing.Size(272, 23);
            this.NewKey1.TabIndex = 6;
            this.NewKey1.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NewKey2);
            this.groupBox1.Controls.Add(this.NewKey1);
            this.groupBox1.Location = new System.Drawing.Point(13, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 112);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter New Key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Confirm:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NewKey2
            // 
            this.NewKey2.Location = new System.Drawing.Point(6, 77);
            this.NewKey2.Name = "NewKey2";
            this.NewKey2.PasswordChar = '*';
            this.NewKey2.Size = new System.Drawing.Size(272, 23);
            this.NewKey2.TabIndex = 7;
            this.NewKey2.UseSystemPasswordChar = true;
            // 
            // ChangeKeyButton
            // 
            this.ChangeKeyButton.Location = new System.Drawing.Point(90, 194);
            this.ChangeKeyButton.Name = "ChangeKeyButton";
            this.ChangeKeyButton.Size = new System.Drawing.Size(128, 23);
            this.ChangeKeyButton.TabIndex = 8;
            this.ChangeKeyButton.Text = "Change Master Key";
            this.ChangeKeyButton.UseVisualStyleBackColor = true;
            this.ChangeKeyButton.Click += new System.EventHandler(this.ChangeKeyButton_Click);
            // 
            // ChangeKey
            // 
            this.AcceptButton = this.ChangeKeyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 233);
            this.Controls.Add(this.ChangeKeyButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PreviousKey);
            this.Controls.Add(this.PreviousKeyLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeKey";
            this.Text = "Change Master Key";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangeKey_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PreviousKeyLabel;
        private System.Windows.Forms.TextBox PreviousKey;
        private System.Windows.Forms.TextBox NewKey1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewKey2;
        private System.Windows.Forms.Button ChangeKeyButton;
    }
}