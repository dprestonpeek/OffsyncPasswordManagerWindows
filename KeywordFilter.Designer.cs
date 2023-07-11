
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
            this.SetFilter = new System.Windows.Forms.Button();
            this.Keyword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SetFilter
            // 
            this.SetFilter.Location = new System.Drawing.Point(111, 82);
            this.SetFilter.Name = "SetFilter";
            this.SetFilter.Size = new System.Drawing.Size(75, 23);
            this.SetFilter.TabIndex = 0;
            this.SetFilter.Text = "Set Filter";
            this.SetFilter.UseVisualStyleBackColor = true;
            this.SetFilter.Click += new System.EventHandler(this.SetFilter_Click);
            // 
            // Keyword
            // 
            this.Keyword.Location = new System.Drawing.Point(12, 37);
            this.Keyword.Name = "Keyword";
            this.Keyword.Size = new System.Drawing.Size(263, 23);
            this.Keyword.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter a keyword to filter by:";
            // 
            // KeywordFilter
            // 
            this.AcceptButton = this.SetFilter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 118);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Keyword);
            this.Controls.Add(this.SetFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KeywordFilter";
            this.Text = "Keyword Filter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KeywordFilter_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetFilter;
        public System.Windows.Forms.TextBox Keyword;
        private System.Windows.Forms.Label label1;
    }
}