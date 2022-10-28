using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;

namespace OffSyncPasswordManager
{
    public partial class Main : Form
    {
        ConfirmationWindow confirm;
        ChangeKey changeKey;
        About about;
        List<string> Credentials;

        private static string keyFile = "encryptedKey.txt";
        private static string pwordsFile = "encryptedPasswords.txt";
        private static string exportedFile = "exportedPasswords.txt";

        public Main()
        {
            InitializeComponent();
            Credentials = new List<string>();
            Master.InitializeMasterKeyData();
            PopulateCredentials();
        }

        /// <summary>
        /// Clicking the "Add Credential" button. Encrypts and stores the info and password entered.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (Master.KeyDataNotEmpty())
            {
                if (Original.Text.Equals(""))
                {
                    Original.Text = GeneratePassword();
                }
                string[] encryptedCreds = AesEncryption.EncryptString(CredDesc.Text + "|" + Username.Text + "|" + Original.Text, Master.Key, Master.IV, Master.KeySalt, Master.AuthKeySalt, Master.AuthKey);

                AddCredential(encryptedCreds[0], encryptedCreds[4]);
                Original.Text = "";
                Username.Text = "";
                CredDesc.Text = "";

                CredDesc.Select();
            }
        }

        /// <summary>
        /// Clicking the "Copy Password" button. Decrypts and copies the password to clipboard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DecryptButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(DecryptPassword());
        }

        /// <summary>
        /// Returns the selected password in decrypted format.
        /// </summary>
        /// <returns></returns>
        private string DecryptPassword()
        {
            if (Master.KeyDataNotEmpty() && Usernames.SelectedItems.Count == 1)
            {
                string[] storedData = File.ReadAllLines(pwordsFile);
                string[] split = storedData[Usernames.SelectedIndex].Split('|');
                string encryptedCreds = split[0];
                string authKey = split[1];
                string decryptedCredsData = AesEncryption.DecryptToString(Convert.FromBase64String(encryptedCreds), Master.Key, Master.IV, Master.KeySalt, Master.AuthKeySalt, authKey);
                string[] credsSplit = decryptedCredsData.Split('|');
                return credsSplit[2];
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
                string[] credsSplit = decryptedCredsData.Split('|');
                return credsSplit;
            }
            return new string[0];
        }

        /// <summary>
        /// Read passwords and info from file and populate fields in-app.
        /// </summary>
        private void PopulateCredentials()
        {
            if (Master.KeyDataNotEmpty())
            {
                string[] storedData = File.ReadAllLines(pwordsFile);
                Credentials.Clear();
                Credentials.AddRange(storedData);
                foreach (string line in storedData)
                {
                    string[] split = line.Split('|');
                    string creds = AesEncryption.DecryptToString(Convert.FromBase64String(split[0]), Master.Key, Master.IV, Master.KeySalt, Master.AuthKeySalt, split[1]);
                    string[] credsSplit = creds.Split('|');
                    CredDescriptions.Items.Add(credsSplit[0]);
                    Usernames.Items.Add(credsSplit[1]);
                }
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
            CredDescriptions.Items.Add(desc);
            Usernames.Items.Add(user);

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
                        string[] creds = DecryptCredentials(line/*.Split('|')[0]*/);
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
            confirm = new ConfirmationWindow("Clear all passwords?", "Delete all password data?\nThis cannot be undone.");
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
            Original.Text = GeneratePassword();
        }

        private string GeneratePassword()
        {
            Random rand = new Random();
            string password = "";
            int lowLetters = 0;
            int highLetters = 0;
            int digits = 0;
            int specials = 0;

            for (int i = 0; i < 15; i++)
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
                else if (((code == 33) || (code >= 35 && code <= 43) || (code >= 45 && code <= 47)) && specials < 2)
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

        private void Usernames_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(DecryptPassword());
        }

        private void CredDescriptions_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(DecryptPassword());
        }

        private void clearSelectedCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = Usernames.SelectedIndex;
            Credentials.RemoveAt(index);
            Usernames.Items.RemoveAt(index);
            CredDescriptions.Items.RemoveAt(index);
            File.WriteAllLines(pwordsFile, Credentials);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("UpdateRepair.exe");
            Application.Exit();
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

                    CredDescriptions.Items.Add(decryptedCreds[0]);
                    Usernames.Items.Add(decryptedCreds[1]);
                }
            }

            string[] items = new string[Credentials.Count];
            Credentials.CopyTo(items, 0);
            File.WriteAllLines(pwordsFile, items);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (about == null)
            {
                about = new About();
            }
            about.Show();
        }

        private void changeMasterPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeKey = new ChangeKey(true);
            changeKey.FormClosed += KeyChanged;
            changeKey.Show();
        }
    }
}
