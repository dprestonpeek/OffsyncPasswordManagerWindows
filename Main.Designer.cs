
namespace OffSyncPasswordManager
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.Original = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CredDescriptions = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeMasterPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllPasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSelectedCredentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CredDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Usernames = new System.Windows.Forms.ListBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ViewPasswordButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lockTimer = new System.Windows.Forms.Timer(this.components);
            this.UsernameFilter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PassCopyLabel = new System.Windows.Forms.Label();
            this.UserCopyLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncryptButton
            // 
            this.EncryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EncryptButton.Location = new System.Drawing.Point(319, 141);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(110, 23);
            this.EncryptButton.TabIndex = 4;
            this.EncryptButton.Text = "Add Credential";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DecryptButton.Location = new System.Drawing.Point(338, 432);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(109, 23);
            this.DecryptButton.TabIndex = 7;
            this.DecryptButton.Text = "Copy Password";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // Original
            // 
            this.Original.Location = new System.Drawing.Point(7, 93);
            this.Original.Name = "Original";
            this.Original.Size = new System.Drawing.Size(287, 23);
            this.Original.TabIndex = 2;
            this.Original.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "New Password:";
            // 
            // CredDescriptions
            // 
            this.CredDescriptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CredDescriptions.FormattingEnabled = true;
            this.CredDescriptions.ItemHeight = 15;
            this.CredDescriptions.Location = new System.Drawing.Point(0, 0);
            this.CredDescriptions.Name = "CredDescriptions";
            this.CredDescriptions.Size = new System.Drawing.Size(200, 199);
            this.CredDescriptions.TabIndex = 5;
            this.CredDescriptions.SelectedIndexChanged += new System.EventHandler(this.CredDescriptions_SelectedIndexChanged);
            this.CredDescriptions.DoubleClick += new System.EventHandler(this.CredDescriptions_DoubleClick);
            this.CredDescriptions.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CredDescriptions_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Credentials";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(459, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportPasswordsToolStripMenuItem,
            this.toolStripSeparator1,
            this.lockToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.importToolStripMenuItem.Text = "Import Passwords...";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportPasswordsToolStripMenuItem
            // 
            this.exportPasswordsToolStripMenuItem.Name = "exportPasswordsToolStripMenuItem";
            this.exportPasswordsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exportPasswordsToolStripMenuItem.Text = "Export Passwords...";
            this.exportPasswordsToolStripMenuItem.Click += new System.EventHandler(this.exportPasswordsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // lockToolStripMenuItem
            // 
            this.lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            this.lockToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.lockToolStripMenuItem.Text = "Lock";
            this.lockToolStripMenuItem.Click += new System.EventHandler(this.lockToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeMasterPasswordToolStripMenuItem,
            this.clearPasswordsToolStripMenuItem,
            this.toolStripSeparator2,
            this.optionsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // changeMasterPasswordToolStripMenuItem
            // 
            this.changeMasterPasswordToolStripMenuItem.Name = "changeMasterPasswordToolStripMenuItem";
            this.changeMasterPasswordToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.changeMasterPasswordToolStripMenuItem.Text = "Change Master Password";
            this.changeMasterPasswordToolStripMenuItem.Click += new System.EventHandler(this.changeMasterPasswordToolStripMenuItem_Click);
            // 
            // clearPasswordsToolStripMenuItem
            // 
            this.clearPasswordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllPasswordsToolStripMenuItem,
            this.clearSelectedCredentialsToolStripMenuItem});
            this.clearPasswordsToolStripMenuItem.Name = "clearPasswordsToolStripMenuItem";
            this.clearPasswordsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.clearPasswordsToolStripMenuItem.Text = "Clear Credentials";
            // 
            // clearAllPasswordsToolStripMenuItem
            // 
            this.clearAllPasswordsToolStripMenuItem.Name = "clearAllPasswordsToolStripMenuItem";
            this.clearAllPasswordsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.clearAllPasswordsToolStripMenuItem.Text = "Clear All Credentials...";
            this.clearAllPasswordsToolStripMenuItem.Click += new System.EventHandler(this.clearAllPasswordsToolStripMenuItem_Click);
            // 
            // clearSelectedCredentialsToolStripMenuItem
            // 
            this.clearSelectedCredentialsToolStripMenuItem.Name = "clearSelectedCredentialsToolStripMenuItem";
            this.clearSelectedCredentialsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.clearSelectedCredentialsToolStripMenuItem.Text = "Clear Selected Credentials";
            this.clearSelectedCredentialsToolStripMenuItem.Click += new System.EventHandler(this.clearSelectedCredentialsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // CredDesc
            // 
            this.CredDesc.Location = new System.Drawing.Point(8, 37);
            this.CredDesc.Name = "CredDesc";
            this.CredDesc.Size = new System.Drawing.Size(199, 23);
            this.CredDesc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Credential Description:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Location = new System.Drawing.Point(12, 227);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CredDescriptions);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Usernames);
            this.splitContainer1.Size = new System.Drawing.Size(435, 199);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 15;
            // 
            // Usernames
            // 
            this.Usernames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Usernames.FormattingEnabled = true;
            this.Usernames.ItemHeight = 15;
            this.Usernames.Location = new System.Drawing.Point(0, 0);
            this.Usernames.Name = "Usernames";
            this.Usernames.Size = new System.Drawing.Size(231, 199);
            this.Usernames.TabIndex = 6;
            this.Usernames.SelectedIndexChanged += new System.EventHandler(this.Usernames_SelectedIndexChanged);
            this.Usernames.DoubleClick += new System.EventHandler(this.Usernames_DoubleClick);
            this.Usernames.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Usernames_MouseUp);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(319, 92);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(110, 23);
            this.GenerateButton.TabIndex = 3;
            this.GenerateButton.Text = "Generate...";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(223, 37);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(206, 23);
            this.Username.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Username:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ViewPasswordButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.EncryptButton);
            this.groupBox1.Controls.Add(this.Original);
            this.groupBox1.Controls.Add(this.Username);
            this.groupBox1.Controls.Add(this.CredDesc);
            this.groupBox1.Controls.Add(this.GenerateButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 170);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter New Credentials";
            // 
            // ViewPasswordButton
            // 
            this.ViewPasswordButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewPasswordButton.Location = new System.Drawing.Point(292, 93);
            this.ViewPasswordButton.Name = "ViewPasswordButton";
            this.ViewPasswordButton.Size = new System.Drawing.Size(21, 23);
            this.ViewPasswordButton.TabIndex = 19;
            this.ViewPasswordButton.Text = "👁";
            this.ViewPasswordButton.UseVisualStyleBackColor = true;
            this.ViewPasswordButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPasswordButton_MouseDown);
            this.ViewPasswordButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPasswordButton_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "./";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "exportedPasswords";
            this.saveFileDialog1.InitialDirectory = "./";
            // 
            // lockTimer
            // 
            this.lockTimer.Enabled = true;
            this.lockTimer.Tick += new System.EventHandler(this.lockTimer_Tick);
            // 
            // UsernameFilter
            // 
            this.UsernameFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsernameFilter.FormattingEnabled = true;
            this.UsernameFilter.Items.AddRange(new object[] {
            "[all]",
            "[keyword]"});
            this.UsernameFilter.Location = new System.Drawing.Point(282, 203);
            this.UsernameFilter.Name = "UsernameFilter";
            this.UsernameFilter.Size = new System.Drawing.Size(165, 23);
            this.UsernameFilter.TabIndex = 20;
            this.UsernameFilter.SelectedIndexChanged += new System.EventHandler(this.UsernameFilter_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Filter:";
            // 
            // PassCopyLabel
            // 
            this.PassCopyLabel.AutoSize = true;
            this.PassCopyLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.PassCopyLabel.Location = new System.Drawing.Point(12, 436);
            this.PassCopyLabel.Name = "PassCopyLabel";
            this.PassCopyLabel.Size = new System.Drawing.Size(110, 15);
            this.PassCopyLabel.TabIndex = 22;
            this.PassCopyLabel.Text = "Password Copied ✓";
            this.PassCopyLabel.Visible = false;
            // 
            // UserCopyLabel
            // 
            this.UserCopyLabel.AutoSize = true;
            this.UserCopyLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.UserCopyLabel.Location = new System.Drawing.Point(139, 436);
            this.UserCopyLabel.Name = "UserCopyLabel";
            this.UserCopyLabel.Size = new System.Drawing.Size(113, 15);
            this.UserCopyLabel.TabIndex = 23;
            this.UserCopyLabel.Text = "Username Copied ✓";
            this.UserCopyLabel.Visible = false;
            // 
            // Main
            // 
            this.AcceptButton = this.EncryptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 457);
            this.Controls.Add(this.UserCopyLabel);
            this.Controls.Add(this.PassCopyLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UsernameFilter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(475, 360);
            this.Name = "Main";
            this.Text = "OffSync Password Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.TextBox Original;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox CredDescriptions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportPasswordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeMasterPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearPasswordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllPasswordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox CredDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox Usernames;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem clearSelectedCredentialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem lockToolStripMenuItem;
        private System.Windows.Forms.Timer lockTimer;
        private System.Windows.Forms.Button ViewPasswordButton;
        private System.Windows.Forms.ComboBox UsernameFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Label PassCopyLabel;
        private System.Windows.Forms.Label UserCopyLabel;
    }
}

