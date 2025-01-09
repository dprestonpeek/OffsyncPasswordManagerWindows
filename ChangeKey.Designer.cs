
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
            PreviousKeyLabel = new System.Windows.Forms.Label();
            PreviousKey = new System.Windows.Forms.TextBox();
            NewKey1 = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            NewKey2 = new System.Windows.Forms.TextBox();
            ChangeKeyButton = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // PreviousKeyLabel
            // 
            PreviousKeyLabel.AutoSize = true;
            PreviousKeyLabel.Location = new System.Drawing.Point(19, 9);
            PreviousKeyLabel.Name = "PreviousKeyLabel";
            PreviousKeyLabel.Size = new System.Drawing.Size(107, 15);
            PreviousKeyLabel.TabIndex = 3;
            PreviousKeyLabel.Text = "Enter Previous Key:";
            PreviousKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PreviousKey
            // 
            PreviousKey.Location = new System.Drawing.Point(19, 27);
            PreviousKey.Name = "PreviousKey";
            PreviousKey.PasswordChar = '*';
            PreviousKey.Size = new System.Drawing.Size(272, 23);
            PreviousKey.TabIndex = 4;
            PreviousKey.UseSystemPasswordChar = true;
            // 
            // NewKey1
            // 
            NewKey1.Location = new System.Drawing.Point(6, 22);
            NewKey1.Name = "NewKey1";
            NewKey1.PasswordChar = '*';
            NewKey1.Size = new System.Drawing.Size(272, 23);
            NewKey1.TabIndex = 6;
            NewKey1.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(NewKey2);
            groupBox1.Controls.Add(NewKey1);
            groupBox1.Location = new System.Drawing.Point(13, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(284, 112);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter New Key:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 59);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 15);
            label2.TabIndex = 8;
            label2.Text = "Confirm:";
            label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NewKey2
            // 
            NewKey2.Location = new System.Drawing.Point(6, 77);
            NewKey2.Name = "NewKey2";
            NewKey2.PasswordChar = '*';
            NewKey2.Size = new System.Drawing.Size(272, 23);
            NewKey2.TabIndex = 7;
            NewKey2.UseSystemPasswordChar = true;
            // 
            // ChangeKeyButton
            // 
            ChangeKeyButton.Location = new System.Drawing.Point(90, 194);
            ChangeKeyButton.Name = "ChangeKeyButton";
            ChangeKeyButton.Size = new System.Drawing.Size(128, 23);
            ChangeKeyButton.TabIndex = 8;
            ChangeKeyButton.Text = "Change Master Key";
            ChangeKeyButton.UseVisualStyleBackColor = true;
            ChangeKeyButton.Click += ChangeKeyButton_Click;
            // 
            // ChangeKey
            // 
            AcceptButton = ChangeKeyButton;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(309, 233);
            Controls.Add(ChangeKeyButton);
            Controls.Add(groupBox1);
            Controls.Add(PreviousKey);
            Controls.Add(PreviousKeyLabel);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "ChangeKey";
            Text = "Change Master Key";
            FormClosed += ChangeKey_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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