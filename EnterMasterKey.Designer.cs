
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterMasterKey));
            label1 = new System.Windows.Forms.Label();
            MasterKeyEntry = new System.Windows.Forms.TextBox();
            OKButton = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(85, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 15);
            label1.TabIndex = 2;
            label1.Text = "Please Enter Master Key:";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MasterKeyEntry
            // 
            MasterKeyEntry.Location = new System.Drawing.Point(12, 42);
            MasterKeyEntry.Name = "MasterKeyEntry";
            MasterKeyEntry.PasswordChar = '*';
            MasterKeyEntry.Size = new System.Drawing.Size(284, 23);
            MasterKeyEntry.TabIndex = 0;
            MasterKeyEntry.UseSystemPasswordChar = true;
            // 
            // OKButton
            // 
            OKButton.Location = new System.Drawing.Point(115, 71);
            OKButton.Name = "OKButton";
            OKButton.Size = new System.Drawing.Size(75, 23);
            OKButton.TabIndex = 1;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // EnterMasterKey
            // 
            AcceptButton = OKButton;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            ClientSize = new System.Drawing.Size(309, 111);
            Controls.Add(OKButton);
            Controls.Add(MasterKeyEntry);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EnterMasterKey";
            Text = "Enter Master Key";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MasterKeyEntry;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Timer timer1;
    }
}