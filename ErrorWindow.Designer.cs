
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
            ErrorOK = new System.Windows.Forms.Button();
            ErrorMessage = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // ErrorOK
            // 
            ErrorOK.Location = new System.Drawing.Point(146, 90);
            ErrorOK.Name = "ErrorOK";
            ErrorOK.Size = new System.Drawing.Size(75, 23);
            ErrorOK.TabIndex = 2;
            ErrorOK.Text = "OK";
            ErrorOK.UseVisualStyleBackColor = true;
            ErrorOK.Click += ErrorOK_Click;
            // 
            // ErrorMessage
            // 
            ErrorMessage.Location = new System.Drawing.Point(49, 26);
            ErrorMessage.Multiline = true;
            ErrorMessage.Name = "ErrorMessage";
            ErrorMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            ErrorMessage.Size = new System.Drawing.Size(277, 58);
            ErrorMessage.TabIndex = 3;
            ErrorMessage.Text = "Cannot import passwords that were exported using a different master key.";
            ErrorMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ErrorWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(363, 140);
            Controls.Add(ErrorMessage);
            Controls.Add(ErrorOK);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "ErrorWindow";
            Text = "Error!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button ErrorOK;
        private System.Windows.Forms.TextBox ErrorMessage;
    }
}