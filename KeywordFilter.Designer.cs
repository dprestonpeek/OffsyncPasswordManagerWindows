
namespace OffSyncPasswordManager
{
    partial class KeywordFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeywordFilter));
            SetFilter = new System.Windows.Forms.Button();
            Keyword = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // SetFilter
            // 
            SetFilter.Location = new System.Drawing.Point(111, 82);
            SetFilter.Name = "SetFilter";
            SetFilter.Size = new System.Drawing.Size(75, 23);
            SetFilter.TabIndex = 0;
            SetFilter.Text = "Set Filter";
            SetFilter.UseVisualStyleBackColor = true;
            SetFilter.Click += SetFilter_Click;
            // 
            // Keyword
            // 
            Keyword.Location = new System.Drawing.Point(12, 37);
            Keyword.Name = "Keyword";
            Keyword.Size = new System.Drawing.Size(263, 23);
            Keyword.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(68, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(151, 15);
            label1.TabIndex = 2;
            label1.Text = "Enter a keyword to filter by:";
            // 
            // KeywordFilter
            // 
            AcceptButton = SetFilter;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(287, 118);
            Controls.Add(label1);
            Controls.Add(Keyword);
            Controls.Add(SetFilter);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "KeywordFilter";
            Text = "Keyword Filter";
            FormClosed += KeywordFilter_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button SetFilter;
        public System.Windows.Forms.TextBox Keyword;
        private System.Windows.Forms.Label label1;
    }
}