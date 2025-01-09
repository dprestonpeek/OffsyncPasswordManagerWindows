
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            EncryptButton = new System.Windows.Forms.Button();
            DecryptButton = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            CredDescriptions = new System.Windows.Forms.ListBox();
            label4 = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportPasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            changeMasterPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            clearPasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            clearAllPasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            clearSelectedCredentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            CredDesc = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            Usernames = new System.Windows.Forms.ListBox();
            GenerateButton = new System.Windows.Forms.Button();
            Username = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            Encrypted = new System.Windows.Forms.RichTextBox();
            ViewPasswordButton = new System.Windows.Forms.Button();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            lockTimer = new System.Windows.Forms.Timer(components);
            UsernameFilter = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            PassCopyLabel = new System.Windows.Forms.Label();
            UserCopyLabel = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // EncryptButton
            // 
            EncryptButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            EncryptButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            EncryptButton.Location = new System.Drawing.Point(389, 158);
            EncryptButton.Name = "EncryptButton";
            EncryptButton.Size = new System.Drawing.Size(42, 31);
            EncryptButton.TabIndex = 4;
            EncryptButton.Text = "Add";
            EncryptButton.UseVisualStyleBackColor = true;
            EncryptButton.Click += EncryptButton_Click;
            // 
            // DecryptButton
            // 
            DecryptButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            DecryptButton.Location = new System.Drawing.Point(338, 457);
            DecryptButton.Name = "DecryptButton";
            DecryptButton.Size = new System.Drawing.Size(109, 23);
            DecryptButton.TabIndex = 7;
            DecryptButton.Text = "Copy String";
            DecryptButton.UseVisualStyleBackColor = true;
            DecryptButton.Click += DecryptButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 75);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 15);
            label3.TabIndex = 8;
            label3.Text = "Encrypted Text";
            // 
            // CredDescriptions
            // 
            CredDescriptions.Dock = System.Windows.Forms.DockStyle.Fill;
            CredDescriptions.FormattingEnabled = true;
            CredDescriptions.ItemHeight = 15;
            CredDescriptions.Location = new System.Drawing.Point(0, 0);
            CredDescriptions.Name = "CredDescriptions";
            CredDescriptions.Size = new System.Drawing.Size(184, 199);
            CredDescriptions.TabIndex = 5;
            CredDescriptions.SelectedIndexChanged += CredDescriptions_SelectedIndexChanged;
            CredDescriptions.DoubleClick += CredDescriptions_DoubleClick;
            CredDescriptions.MouseUp += CredDescriptions_MouseUp;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 234);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(46, 15);
            label4.TabIndex = 11;
            label4.Text = "Strings:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(459, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { importToolStripMenuItem, exportPasswordsToolStripMenuItem, toolStripSeparator1, lockToolStripMenuItem, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            importToolStripMenuItem.Text = "Import Strings...";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // exportPasswordsToolStripMenuItem
            // 
            exportPasswordsToolStripMenuItem.Name = "exportPasswordsToolStripMenuItem";
            exportPasswordsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            exportPasswordsToolStripMenuItem.Text = "Export Strings...";
            exportPasswordsToolStripMenuItem.Click += exportPasswordsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // lockToolStripMenuItem
            // 
            lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            lockToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            lockToolStripMenuItem.Text = "Lock";
            lockToolStripMenuItem.Click += lockToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { changeMasterPasswordToolStripMenuItem, clearPasswordsToolStripMenuItem, toolStripSeparator2, optionsToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // changeMasterPasswordToolStripMenuItem
            // 
            changeMasterPasswordToolStripMenuItem.Name = "changeMasterPasswordToolStripMenuItem";
            changeMasterPasswordToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            changeMasterPasswordToolStripMenuItem.Text = "Change Master Password";
            changeMasterPasswordToolStripMenuItem.Click += changeMasterPasswordToolStripMenuItem_Click;
            // 
            // clearPasswordsToolStripMenuItem
            // 
            clearPasswordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { clearAllPasswordsToolStripMenuItem, clearSelectedCredentialsToolStripMenuItem });
            clearPasswordsToolStripMenuItem.Name = "clearPasswordsToolStripMenuItem";
            clearPasswordsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            clearPasswordsToolStripMenuItem.Text = "Clear Strings";
            // 
            // clearAllPasswordsToolStripMenuItem
            // 
            clearAllPasswordsToolStripMenuItem.Name = "clearAllPasswordsToolStripMenuItem";
            clearAllPasswordsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            clearAllPasswordsToolStripMenuItem.Text = "Clear All Strings...";
            clearAllPasswordsToolStripMenuItem.Click += clearAllPasswordsToolStripMenuItem_Click;
            // 
            // clearSelectedCredentialsToolStripMenuItem
            // 
            clearSelectedCredentialsToolStripMenuItem.Name = "clearSelectedCredentialsToolStripMenuItem";
            clearSelectedCredentialsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            clearSelectedCredentialsToolStripMenuItem.Text = "Clear Selected String";
            clearSelectedCredentialsToolStripMenuItem.Click += clearSelectedCredentialsToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            optionsToolStripMenuItem.Text = "Options";
            optionsToolStripMenuItem.Click += optionsToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutToolStripMenuItem, checkForUpdatesToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            aboutToolStripMenuItem.Text = "About...";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            checkForUpdatesToolStripMenuItem.Visible = false;
            checkForUpdatesToolStripMenuItem.Click += checkForUpdatesToolStripMenuItem_Click;
            // 
            // CredDesc
            // 
            CredDesc.Location = new System.Drawing.Point(8, 37);
            CredDesc.Name = "CredDesc";
            CredDesc.Size = new System.Drawing.Size(199, 23);
            CredDesc.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 15);
            label1.TabIndex = 14;
            label1.Text = "String ID:";
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            splitContainer1.Location = new System.Drawing.Point(12, 252);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(CredDescriptions);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(Usernames);
            splitContainer1.Size = new System.Drawing.Size(435, 199);
            splitContainer1.SplitterDistance = 184;
            splitContainer1.TabIndex = 15;
            // 
            // Usernames
            // 
            Usernames.Dock = System.Windows.Forms.DockStyle.Fill;
            Usernames.FormattingEnabled = true;
            Usernames.ItemHeight = 15;
            Usernames.Location = new System.Drawing.Point(0, 0);
            Usernames.Name = "Usernames";
            Usernames.Size = new System.Drawing.Size(247, 199);
            Usernames.TabIndex = 6;
            Usernames.SelectedIndexChanged += Usernames_SelectedIndexChanged;
            Usernames.DoubleClick += Usernames_DoubleClick;
            Usernames.MouseUp += Usernames_MouseUp;
            // 
            // GenerateButton
            // 
            GenerateButton.Enabled = false;
            GenerateButton.Location = new System.Drawing.Point(394, 11);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new System.Drawing.Size(21, 23);
            GenerateButton.TabIndex = 3;
            GenerateButton.Text = "Generate...";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Visible = false;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // Username
            // 
            Username.Location = new System.Drawing.Point(223, 37);
            Username.Name = "Username";
            Username.Size = new System.Drawing.Size(206, 23);
            Username.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(223, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(68, 15);
            label2.TabIndex = 18;
            label2.Text = "String Type:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.Controls.Add(Encrypted);
            groupBox1.Controls.Add(ViewPasswordButton);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(EncryptButton);
            groupBox1.Controls.Add(Username);
            groupBox1.Controls.Add(CredDesc);
            groupBox1.Controls.Add(GenerateButton);
            groupBox1.Location = new System.Drawing.Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(435, 195);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter New String";
            // 
            // Encrypted
            // 
            Encrypted.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            Encrypted.Location = new System.Drawing.Point(8, 93);
            Encrypted.Name = "Encrypted";
            Encrypted.Size = new System.Drawing.Size(375, 96);
            Encrypted.TabIndex = 3;
            Encrypted.Text = "";
            // 
            // ViewPasswordButton
            // 
            ViewPasswordButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ViewPasswordButton.Location = new System.Drawing.Point(389, 93);
            ViewPasswordButton.Name = "ViewPasswordButton";
            ViewPasswordButton.Size = new System.Drawing.Size(42, 23);
            ViewPasswordButton.TabIndex = 19;
            ViewPasswordButton.Text = "👁";
            ViewPasswordButton.UseVisualStyleBackColor = true;
            ViewPasswordButton.Click += ViewPasswordButton_Click;
            ViewPasswordButton.MouseDown += ViewPasswordButton_MouseDown;
            ViewPasswordButton.MouseUp += ViewPasswordButton_MouseUp;
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.InitialDirectory = "./";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.FileName = "exportedPasswords";
            saveFileDialog1.InitialDirectory = "./";
            // 
            // lockTimer
            // 
            lockTimer.Enabled = true;
            lockTimer.Tick += lockTimer_Tick;
            // 
            // UsernameFilter
            // 
            UsernameFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            UsernameFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            UsernameFilter.FormattingEnabled = true;
            UsernameFilter.Items.AddRange(new object[] { "[all]", "[keyword]" });
            UsernameFilter.Location = new System.Drawing.Point(282, 228);
            UsernameFilter.Name = "UsernameFilter";
            UsernameFilter.Size = new System.Drawing.Size(165, 23);
            UsernameFilter.TabIndex = 20;
            UsernameFilter.SelectedIndexChanged += UsernameFilter_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(216, 234);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(36, 15);
            label5.TabIndex = 21;
            label5.Text = "Filter:";
            // 
            // PassCopyLabel
            // 
            PassCopyLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            PassCopyLabel.AutoSize = true;
            PassCopyLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            PassCopyLabel.Location = new System.Drawing.Point(12, 461);
            PassCopyLabel.Name = "PassCopyLabel";
            PassCopyLabel.Size = new System.Drawing.Size(91, 15);
            PassCopyLabel.TabIndex = 22;
            PassCopyLabel.Text = "String Copied ✓";
            PassCopyLabel.Visible = false;
            // 
            // UserCopyLabel
            // 
            UserCopyLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            UserCopyLabel.AutoSize = true;
            UserCopyLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            UserCopyLabel.Location = new System.Drawing.Point(139, 461);
            UserCopyLabel.Name = "UserCopyLabel";
            UserCopyLabel.Size = new System.Drawing.Size(113, 15);
            UserCopyLabel.TabIndex = 23;
            UserCopyLabel.Text = "Username Copied ✓";
            UserCopyLabel.Visible = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(459, 482);
            Controls.Add(UserCopyLabel);
            Controls.Add(PassCopyLabel);
            Controls.Add(label5);
            Controls.Add(UsernameFilter);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(DecryptButton);
            Controls.Add(menuStrip1);
            Controls.Add(splitContainer1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new System.Drawing.Size(475, 360);
            Name = "Main";
            Text = "CryptoString - Encrypted String Manager";
            FormClosed += Main_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
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
        private System.Windows.Forms.RichTextBox Encrypted;
    }
}

