
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmationWindow));
            CancelButton = new System.Windows.Forms.Button();
            ConfirmationText = new System.Windows.Forms.Label();
            OKButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Location = new System.Drawing.Point(190, 76);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new System.Drawing.Size(75, 23);
            CancelButton.TabIndex = 2;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // ConfirmationText
            // 
            ConfirmationText.AutoSize = true;
            ConfirmationText.Location = new System.Drawing.Point(95, 19);
            ConfirmationText.Name = "ConfirmationText";
            ConfirmationText.Size = new System.Drawing.Size(131, 30);
            ConfirmationText.TabIndex = 3;
            ConfirmationText.Text = "Delete all string data? \r\nThis cannot be undone.";
            ConfirmationText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OKButton
            // 
            OKButton.Location = new System.Drawing.Point(52, 76);
            OKButton.Name = "OKButton";
            OKButton.Size = new System.Drawing.Size(75, 23);
            OKButton.TabIndex = 4;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // ConfirmationWindow
            // 
            AcceptButton = CancelButton;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(309, 111);
            Controls.Add(OKButton);
            Controls.Add(ConfirmationText);
            Controls.Add(CancelButton);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "ConfirmationWindow";
            Text = "Clear all strings?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label ConfirmationText;
        private System.Windows.Forms.Button OKButton;
    }
}