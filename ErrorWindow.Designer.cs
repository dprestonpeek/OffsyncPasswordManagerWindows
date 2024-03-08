
namespace OffSyncPasswordManager
{
    partial class ErrorWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorWindow));
            this.ErrorOK = new System.Windows.Forms.Button();
            this.ErrorMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ErrorOK
            // 
            this.ErrorOK.Location = new System.Drawing.Point(146, 90);
            this.ErrorOK.Name = "ErrorOK";
            this.ErrorOK.Size = new System.Drawing.Size(75, 23);
            this.ErrorOK.TabIndex = 2;
            this.ErrorOK.Text = "OK";
            this.ErrorOK.UseVisualStyleBackColor = true;
            this.ErrorOK.Click += new System.EventHandler(this.ErrorOK_Click);
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.Location = new System.Drawing.Point(49, 26);
            this.ErrorMessage.Multiline = true;
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ErrorMessage.Size = new System.Drawing.Size(277, 58);
            this.ErrorMessage.TabIndex = 3;
            this.ErrorMessage.Text = "Cannot import passwords that were exported using a different master key.";
            this.ErrorMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ErrorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 140);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.ErrorOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ErrorWindow";
            this.Text = "Error!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ErrorOK;
        private System.Windows.Forms.TextBox ErrorMessage;
    }
}