
namespace OffSyncPasswordManager
{
    partial class ConfirmationWindow
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.ConfirmationText = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(52, 76);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ConfirmationText
            // 
            this.ConfirmationText.AutoSize = true;
            this.ConfirmationText.Location = new System.Drawing.Point(89, 19);
            this.ConfirmationText.Name = "ConfirmationText";
            this.ConfirmationText.Size = new System.Drawing.Size(142, 30);
            this.ConfirmationText.TabIndex = 3;
            this.ConfirmationText.Text = "Delete all password data? \r\nThis cannot be undone.";
            this.ConfirmationText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(190, 76);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ConfirmationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 111);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ConfirmationText);
            this.Controls.Add(this.CancelButton);
            this.Name = "ConfirmationWindow";
            this.Text = "Clear all passwords?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label ConfirmationText;
        private System.Windows.Forms.Button OKButton;
    }
}