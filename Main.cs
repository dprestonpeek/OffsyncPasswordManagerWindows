using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Drawing;

namespace OffSyncPasswordManager
{
    public partial class Main : Form
    {
        public static Main Instance;

        ConfirmationWindow confirm;
        ChangeKey changeKey;
        About about;
        ErrorWindow error;
        List<string> Credentials;
        List<string> FilteredCreds;
        List<string> UniqueUsernames;
        public string[] Settings;

        private static string keyFile = "encryptedKey.txt";
        private static string pwordsFile = "encryptedStrings.txt";
        private static string exportedFile = "exportedStrings.txt";
        private static string settingsFile = "settings.txt";

        public string keywordFilter = "";
        private string loadedKeyword = "";
        private string prevKeyword = "";
        private bool initKeyword = false;
        private bool disableKeywordTrigger = false;

        private int defLockTime = 60;
        private int lockTime = 0;
        private bool locked = false;
        private bool shouldLock { get { return lockTime > defLockTime * 10; } set { shouldLock = value; } }
        private bool editing = false;
        private bool filtering = false;
        private bool wait = false;
        private bool getPassword = false;

        public bool userCopied = false;
        public bool passCopied = false;
        private int copiedCred = -1;
        private int clearTimer = 0;
        private int clearTime = 50;

        //Used for mouse scroll actions
        [DllImport("user32.dll")]
        private static extern IntPtr WindowFromPoint(System.Drawing.Point pt);
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);


        public Main()
        {
            InitializeComponent();
            Instance = this;
            Credentials = new List<string>();
            FilteredCreds = new List<string>();
            UniqueUsernames = new List<string>();
            Master.InitializeMasterKeyData();
            InitializeCredentials();
            InitializeFilter();
            InitializeSettings();

            Usernames.MouseWheel += Usernames_MouseWheel;
            CredDescriptions.MouseWheel += CredDescriptions_MouseWheel;
        }

        private void CredDescriptions_MouseWheel(object sender, MouseEventArgs e)
        {
            //if (e.Delta > 0)
            //{
            //    Usernames.TopIndex = CredDescriptions.TopIndex - 1;
            //}
            //else
            //{
            //    int visibleItems = CredDescriptions.ClientSize.Height / CredDescriptions.ItemHeight;
            //    Usernames.TopIndex = CredDescriptions.TopIndex + 1;
            //}
        }

        private void Usernames_MouseWheel(object sender, MouseEventArgs e)
        {
            //if (e.Delta > 0)
            //{
            //    CredDescriptions.TopIndex = Usernames.TopIndex - 1;
            //}
            //else
            //{
            //    CredDescriptions.TopIndex = Usernames.TopIndex + 1;
            //}
        }

        /// <summary>
        /// Clicking the "Add Credential" button. Encrypts and stores the info and password entered.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                int index = CredDescriptions.SelectedIndex;
                string[] encryptedCreds = AesEncryption.EncryptString(CredDesc.Text + "|" + Username.Text + "|" + /*Original.Text*/Encrypted.Text, Master.Key, Master.IV, Master.KeySalt, Master.AuthKeySalt, Master.AuthKey);
                if (filtering)
                {
                    string cred = FilteredCreds[index];
                    int credIndex = Credentials.IndexOf(cred);
                    string cleartext = DecryptPassword();
                    Credentials.Remove(cred);
                    InsertCredential(credIndex, encryptedCreds[0], encryptedCreds[4]);
                    disableKeywordTrigger = true;
                    FilterCredentials();
                    disableKeywordTrigger = false;
                }
                else
                {
                    Credentials.RemoveAt(index);
                    CredDescriptions.Items.RemoveAt(index);
                    Usernames.Items.RemoveAt(index);
                    InsertCredential(index, encryptedCreds[0], encryptedCreds[4]);
                }
                StopEditing();
            }
            else
            {
                if (Master.KeyDataNotEmpty())
                {
                    //if (Original.Text.Equals(""))
                    //{
                    //    Original.Text = GeneratePassword();
                    //}
                    if (Encrypted.Text.Equals(""))
                    {
                        Encrypted.Text = GeneratePassword();
                    }
                    string[] encryptedCreds = AesEncryption.EncryptString(CredDesc.Text + "|" + Username.Text + "|" + /*Original.Text*/Encrypted.Text, Master.Key, Master.IV, Master.KeySalt, Master.AuthKeySalt, Master.AuthKey);

                    AddCredential(encryptedCreds[0], encryptedCreds[4]);
                    //Original.Text = "";
                    Encrypted.Text = "";
                    Username.Text = "";
                    CredDesc.Text = "";

                    CredDesc.Select();
                }
            }
        }

        /// <summary>
        /// Clicking the "Copy Password" button. Decrypts and copies the password to clipboard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (shouldLock)
            {
                if (!locked)
                {
                    locked = true;
                    LockOffSync();
                    lockTime = 0;
                }
            }
            else
            {
                CopyCredentials();
            }
        }

        /// <summary>
        /// Returns the selected password in decrypted format.
        /// </summary>
        /// <returns></returns>
        private string DecryptPassword()
        {
            return DecryptPassword(Usernames.SelectedIndex);
        }
        private string DecryptPassword(int index)
        {
            if (Master.KeyDataNotEmpty() && Usernames.SelectedItems.Count == 1)
            {
                string[] storedData = File.ReadAllLines(pwordsFile);
                string[] split = storedData[index].Split('|');
                if (FilteredCreds.Count > 0)
                {
                    split = FilteredCreds[index].Split('|');
                }
                string encryptedCreds = split[0];
                string authKey = split[1];
                string decryptedCredsData = AesEncryption.DecryptToString(Convert.FromBase64String(encryptedCreds), Master.Key, Master.IV, Master.KeySalt, Master.AuthKeySalt, authKey);
                string[] credsSplit = decryptedCredsData.Split('|');
                return credsSplit[2];
            }
            return "";
        }

        public string GetUsername()
        {
            return Usernames.SelectedItem.ToString();
        }

        /// <summary>
        /// Copies the selected account username to clipboard if the app is not locked
        /// </summary>
        public void CopyCredentials()
        {
            if (!locked)
            {
                //if (Usernames.SelectedIndex == copiedCred && passCopied && !userCopied)
                //{
                //    Clipboard.SetText(GetUsername());
                //    userCopied = true;
                //}
                //else
                {
                    //if (userCopied)
                    //{
                    //    passCopied = false;
                    //    userCopied = false;
                    //}
                    Clipboard.SetText(GetPassword());
                    copiedCred = Usernames.SelectedIndex;
                    passCopied = true;
                }
                //getPassword = true;
                //wait = true;
            }
        }

        /// <summary>
        /// Copies the selected account password to clipboard if the app is not locked
        /// </summary>
        private void CopyPassword()
        {
            if (!locked)
            {
                Clipboard.SetText(GetPassword());
            }
        }

        public string GetPassword()
        {
            if (!locked)
            {
                return DecryptPassword();
            }
            return "";
        }

        private string[] DecryptCredentials(string encryptedInfo)
        {
            if (Master.KeyDataNotEmpty())
            {
                string[] split = encryptedInfo.Split('|');
                string encryptedCreds = split[0];
                string authKey = split[1];
                string decryptedCredsData = AesEncryption.DecryptToString(Convert.FromBase64String(encryptedCreds), Master.Key, Master.IV, Master.KeySalt, Master.AuthKeySalt, authKey);
                if (decryptedCredsData != null)
                {
                    string[] credsSplit = decryptedCredsData.Split('|');
                    return credsSplit;
                }
            }
            return new string[0];
        }

        private void InitializeSettings()
        {
            try
            {
                Settings = new string[2];

                if (File.Exists(settingsFile))
                {
                    string[] settings = File.ReadAllLines(settingsFile);
                    for (int i = 0; i < settings.Length; i++)
                    {
                        Settings[i] = settings[i];
                    }
                }
                else
                {
                    Settings[0] = "timeout=60";
                    Settings[1] = "defFilter=All";
                    SaveSettings();
                }

                defLockTime = int.Parse(Settings[0].Split('=')[1]);
                string filter = Settings[1].Split('=')[1];
                if (UsernameFilter.Items.Contains(filter))
                {
                    UsernameFilter.SelectedItem = filter;
                    keywordFilter = filter;
                    loadedKeyword = filter;
                    FilterCredentials();
                    Settings[1] = "defFilter=" + keywordFilter;
                }
                else
                {
                    disableKeywordTrigger = true;
                    UsernameFilter.SelectedItem = "[keyword]";
                    keywordFilter = filter;
                    FilterCredentials();
                    Settings[1] = "defFilter=" + keywordFilter;
                }
            }
            catch (Exception ex)
            {

            }
            initKeyword = true;
            disableKeywordTrigger = false;
        }

        public void SaveSettings()
        {
            File.WriteAllLines(settingsFile, Settings);
            InitializeSettings();
        }

        /// <summary>
        /// Read passwords and info from file and populate fields in-app.
        /// </summary>
        private void InitializeCredentials()
        {
            if (Master.KeyDataNotEmpty())
            {
                string[] storedData = File.ReadAllLines(pwordsFile);
                Credentials.Clear();
                Credentials.AddRange(storedData);
                PopulateCredentials(Credentials);
            }
        }

        private void InitializeFilter()
        {
            UsernameFilter.Items.AddRange(UniqueUsernames.ToArray());
            UsernameFilter.SelectedIndex = 0;
            UsernameFilter.SelectedItem = "[all]";
        }

        private void PopulateCredentials(List<string> credentials)
        {
            CredDescriptions.Items.Clear();
            Usernames.Items.Clear();
            foreach (string line in credentials)
            {
                string[] split = line.Split('|');
                string creds = AesEncryption.DecryptToString(Convert.FromBase64String(split[0]), Master.Key, Master.IV, Master.KeySalt, Master.AuthKeySalt, split[1]);
                string[] credsSplit = creds.Split('|');
                CredDescriptions.Items.Add(credsSplit[0]);
                Usernames.Items.Add(credsSplit[1]);
                if (!UniqueUsernames.Contains(credsSplit[1]))
                {
                    UniqueUsernames.Add(credsSplit[1]);
                }
            }
        }

        private void FilterCredentials()
        {
            bool checkDescs = false;
            filtering = false;
            PopulateCredentials(Credentials);
            if ((string)UsernameFilter.SelectedItem != "[all]")
            {
                filtering = true;
                if ((string)UsernameFilter.SelectedItem == "[keyword]")
                {
                    checkDescs = true;
                    if (!disableKeywordTrigger)
                    {
                        KeywordFilter keyFilt = new KeywordFilter();
                        keyFilt.Keyword.Text = loadedKeyword;
                        keyFilt.ShowDialog();
                        if (keywordFilter == "[cancel]")
                        {
                            keywordFilter = prevKeyword;
                            UsernameFilter.SelectedItem = prevKeyword;
                            return;
                        }
                        if (keywordFilter != "")
                        {
                            Settings[1] = "defFilter=" + keywordFilter;
                        }
                    }
                    else
                    {
                        if (keywordFilter != "")
                        {
                            Settings[1] = "defFilter=" + keywordFilter;
                        }
                    }
                }

                List<string> creds = new List<string>();
                for (int i = 0; i < Usernames.Items.Count; i++)
                {
                    if (checkDescs)
                    {
                        string[] filters = keywordFilter.Split(',');
                        string desc = (string)CredDescriptions.Items[i];
                        foreach (string filter in filters)
                        {
                            if (desc.ToUpper().Contains(filter.ToUpper()) && !creds.Contains(Credentials[i]))
                            {
                                creds.Add(Credentials[i]);
                            }
                        }

                        string name = (string)Usernames.Items[i];
                        foreach (string filter in filters)
                        {
                            if (name.ToUpper().Contains(filter.ToUpper()) && !creds.Contains(Credentials[i]))
                            {
                                creds.Add(Credentials[i]);
                            }
                        }
                    }
                    else
                    {
                        string name = (string)Usernames.Items[i];
                        if (name == ((string)UsernameFilter.SelectedItem))
                        {
                            creds.Add(Credentials[i]);
                        }
                    }
                }
                FilteredCreds = creds;
                PopulateCredentials(creds);
            }
            else
            {
                FilteredCreds.Clear();
                UsernameFilter.SelectedItem = "[all]";
            }
        }

        /// <summary>
        /// Encrypts and adds the password to credentials list.
        /// </summary>
        /// <param name="encryptedPasswordAndAuthKey"></param>
        private void AddCredential(string encryptedCreds, string authKey)
        {
            AddCredential(encryptedCreds, CredDesc.Text, Username.Text, authKey);
        }

        private void AddCredential(string encryptedCreds, string desc, string user, string authKey)
        {
            Credentials.Add(encryptedCreds + "|" + authKey);
            if (!UniqueUsernames.Contains(user))
            {
                UniqueUsernames.Add(user);
                UsernameFilter.Items.Add(user);
            }
            PopulateCredentials(Credentials);
            if (filtering)
            {
                disableKeywordTrigger = true;
                FilterCredentials();
                disableKeywordTrigger = false;
            }

            string[] items = new string[Credentials.Count];
            Credentials.CopyTo(items, 0);
            File.WriteAllLines(pwordsFile, items);
        }

        private void InsertCredential(int index, string encryptedCreds, string authKey)
        {
            string desc = CredDesc.Text;
            string user = Username.Text;
            Credentials.Insert(index, encryptedCreds + "|" + authKey);
            if (filtering)
            {
                disableKeywordTrigger = true;
                FilterCredentials();
                disableKeywordTrigger = false;
            }
            else
            {
                CredDescriptions.Items.Insert(index, desc);
                Usernames.Items.Insert(index, user);
            }

            string[] items = new string[Credentials.Count];
            Credentials.CopyTo(items, 0);
            File.WriteAllLines(pwordsFile, items);
        }

        private void KeyChanged(object sender, FormClosedEventArgs e)
        {
            changeKey.FormClosed -= KeyChanged;
            if (changeKey.MasterKeyDirty)
            {
                if (Master.KeyDataNotEmpty())
                {
                    string[] storedData = File.ReadAllLines(pwordsFile);
                    List<string> clearTextPasswords = new List<string>();

                    foreach (string line in storedData)
                    {
                        string[] creds = DecryptCredentials(line);
                        clearTextPasswords.Add(creds[0] + "|" + creds[1] + "|" + creds[2]);
                    }
                    Credentials.Clear();
                    CredDescriptions.Items.Clear();
                    Usernames.Items.Clear();
                    Master.ChangeMasterKey(changeKey.NewMasterKey);

                    foreach (string line in clearTextPasswords)
                    {
                        string[] creds = line.Split('|');
                        string[] encryptedCreds = AesEncryption.EncryptString(creds[0] + "|" + creds[1] + "|" + creds[2], Master.Key, Master.IV, Master.KeySalt, Master.AuthKeySalt, Master.AuthKey);

                        AddCredential(encryptedCreds[0], creds[0], creds[1], encryptedCreds[4]);
                    }
                }
            }
        }

        private void CredDescriptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usernames.SelectedIndex = CredDescriptions.SelectedIndex;
        }

        private void Usernames_SelectedIndexChanged(object sender, EventArgs e)
        {
            CredDescriptions.SelectedIndex = Usernames.SelectedIndex;
        }

        private void clearAllPasswordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmClearAllPasswords();
        }

        private void ConfirmClearAllPasswords()
        {
            if (confirm != null)
            {
                confirm.Dispose();
            }
            confirm = new ConfirmationWindow("Clear all strings?", "Delete all string data?\nThis cannot be undone.");
            confirm.FormClosed += ClearPasswordsConfirmationClosed;
            confirm.Show();
        }

        private void ClearPasswordsConfirmationClosed(object sender, FormClosedEventArgs e)
        {
            if (confirm.Confirmed)
            {
                Credentials.Clear();
                CredDescriptions.Items.Clear();
                Usernames.Items.Clear();
                File.WriteAllLines(pwordsFile, new string[0]);
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            //Original.Text = GeneratePassword();
            Encrypted.Text = GeneratePassword();
        }

        private string GeneratePassword()
        {
            Random rand = new Random();
            string password = "";
            int lowLetters = 0;
            int highLetters = 0;
            int digits = 0;
            int specials = 0;

            for (int i = 0; i < 16; i++)
            {
                char code = (char)rand.Next(33, 126);
                char next = code;

                if (code >= 48 && code <= 57 && digits < 6)
                {
                    password += next;
                    digits++;
                }
                else if (code >= 64 && code <= 90 && highLetters < 4)
                {
                    password += next;
                    highLetters++;
                }
                else if (code >= 97 && code <= 122 && lowLetters < 4)
                {
                    password += next;
                    lowLetters++;
                }
                else if (code == 124)
                {
                    code = (char)125;
                }
                else if (((code == 33) || (code >= 35 && code <= 43) || (code >= 45 && code <= 47)) && specials < 3)
                {
                    password += next;
                    specials++;
                }
                else
                {
                    i--;
                }
            }
            return password;
        }

        private void Usernames_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                RightClickCreds(true);
            }
            else
            {
                StopEditing();
            }
        }

        private void Usernames_DoubleClick(object sender, EventArgs e)
        {
            if (shouldLock)
            {
                if (!locked)
                {
                    locked = true;
                    LockOffSync();
                    lockTime = 0;
                }
            }
            else
            {
                CopyCredentials();
            }
        }

        private void CredDescriptions_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                RightClickCreds(false);
            }
            else
            {
                StopEditing();
            }
        }

        private void CredDescriptions_DoubleClick(object sender, EventArgs e)
        {
            //passCopied = false;
            //userCopied = false;
            if (shouldLock)
            {
                if (!locked)
                {
                    locked = true;
                    LockOffSync();
                    lockTime = 0;
                }
            }
            else
            {
                CopyCredentials();
            }
        }

        private void RightClickCreds(bool usernameClicked)
        {
            if (locked)
                return;
            if (CredDescriptions.SelectedItem != null)
            {
                StartEditing();
                int index = -1;
                if (usernameClicked)
                {
                    index = Usernames.SelectedIndex;
                }
                else
                {
                    index = CredDescriptions.SelectedIndex;
                }

                if (usernameClicked)
                {
                    CredDescriptions.SelectedIndex = index;
                }
                else
                {
                    Usernames.SelectedIndex = index;
                }

                CredDesc.Text = CredDescriptions.SelectedItem.ToString();
                Username.Text = Usernames.SelectedItem.ToString();
                //Original.Text = GetPassword();
                Encrypted.Text = GetPassword();
            }
        }

        private void StartEditing()
        {
            editing = true;
            EncryptButton.Text = "Save";
        }

        private void StopEditing()
        {
            editing = false;
            EncryptButton.Text = "Add";
            CredDesc.Text = "";
            Username.Text = "";
            //Original.Text = "";
            Encrypted.Text = "";
        }

        private void clearSelectedCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = Usernames.SelectedIndex;
            if (filtering)
            {
                string cred = FilteredCreds[index];
                Credentials.Remove(cred);
                disableKeywordTrigger = true;
                FilterCredentials();
                disableKeywordTrigger = false;
            }
            else
            {
                Credentials.RemoveAt(index);
                Usernames.Items.RemoveAt(index);
                CredDescriptions.Items.RemoveAt(index);
            }
            File.WriteAllLines(pwordsFile, Credentials);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Application.Exit();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSettings();
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("OffSyncUpdateRepair.exe");
            Application.Exit();
        }

        private void Quit()
        {
            confirm.Dispose();
            changeKey.Dispose();
            about.Dispose();
        }

        private void exportPasswordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileOk += ExportPasswords;
            saveFileDialog1.ShowDialog();
        }

        private void ExportPasswords(object sender, CancelEventArgs e)
        {
            File.WriteAllLines(saveFileDialog1.FileName, Credentials);
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileOk += ImportPasswords;
            openFileDialog1.ShowDialog();
        }

        private void ImportPasswords(object sender, CancelEventArgs e)
        {
            string[] importedPasswords = File.ReadAllLines(openFileDialog1.FileName);
            foreach (string line in importedPasswords)
            {
                if (!Credentials.Contains(line))
                {
                    Credentials.Add(line);
                    string[] decryptedCreds = DecryptCredentials(line);
                    if (decryptedCreds.Length > 0)
                    {
                        CredDescriptions.Items.Add(decryptedCreds[0]);
                        Usernames.Items.Add(decryptedCreds[1]);
                    }
                    else
                    {
                        error = new ErrorWindow("Cannot import strings that were exported using a different master key.");
                        error.ShowDialog();
                        return;
                    }
                }
            }

            string[] items = new string[Credentials.Count];
            Credentials.CopyTo(items, 0);
            File.WriteAllLines(pwordsFile, items);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about = new About();
            about.Show();
        }

        private void changeMasterPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeKey = new ChangeKey(true);
            changeKey.FormClosed += KeyChanged;
            changeKey.Show();
        }

        private void lockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LockOffSync();
        }

        private void LockOffSync()
        {
            EnterMasterKey lockentry = new EnterMasterKey();
            lockentry.Show();
            Hide();
        }

        private async void lockTimer_Tick(object sender, EventArgs e)
        {
            if ((ActiveForm != this && ActiveForm != ChangeKey.ActiveForm && ActiveForm != ConfirmationWindow.ActiveForm
                && ActiveForm != About.ActiveForm && ActiveForm != KeywordFilter.ActiveForm) || ActiveForm == null)
            {
                if (!locked)
                {
                    lockTime++;
                }
            }
            else
            {
                if (shouldLock)
                {
                    if (!locked)
                    {
                        locked = true;
                        LockOffSync();
                        lockTime = 0;
                    }
                }
            }
            if (userCopied || passCopied)
            {
                if (clearTimer < clearTime)
                {
                    clearTimer++;
                }
                else
                {
                    clearTimer = 0;
                    userCopied = false;
                    passCopied = false;
                    PassCopyLabel.Visible = false;
                    UserCopyLabel.Visible = false;
                }
            }
            UserCopyLabel.Visible = userCopied;
            PassCopyLabel.Visible = passCopied;
        }

        private void ViewPasswordButton_MouseDown(object sender, MouseEventArgs e)
        {
            //Original.UseSystemPasswordChar = false;
        }

        private void ViewPasswordButton_MouseUp(object sender, MouseEventArgs e)
        {
            //Original.UseSystemPasswordChar = true;
        }

        private void UsernameFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initKeyword)
            {
                UpdateUsernameFilter();
            }
        }

        private void UpdateUsernameFilter()
        {
            prevKeyword = keywordFilter;
            keywordFilter = UsernameFilter.SelectedItem.ToString();
            FilterCredentials();
            if (Settings != null)
            {
                Settings[1] = "defFilter=" + keywordFilter;
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settingsWindow = new Settings();
            settingsWindow.ShowDialog();
        }

        private void ViewPasswordButton_Click(object sender, EventArgs e)
        {
            Encrypted.Visible = !Encrypted.Visible;
        }
    }
}
