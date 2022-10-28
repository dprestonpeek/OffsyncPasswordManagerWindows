using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace OffSyncPasswordManager
{
    public partial class Main : Form
    {
        ConfirmationWindow confirm;
        ChangeKey changeKey;
        List<string> Credentials;

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
                string[] encrypted = AesEncryption.EncryptString(Original.Text, Master.Key, Master.IV, Master.KeySalt, Master.AuthKeySalt, Master.AuthKey);

                AddCredential(encrypted[0] + "|" + encrypted[4]);
                Original.Text = "";
                Username.Text = "";
                CredDesc.Text = "";
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
            if (Master.KeyDataNotEmpty())
            {
                string[] storedData = File.ReadAllLines("encryptedPasswords.txt");
                string[] split = storedData[Usernames.SelectedIndex].Split('|');
                string encryptedPassword = split[2];
                string authKey = split[3];
                string decryptedData = AesEncryption.DecryptToString(Convert.FromBase64String(encryptedPassword), Master.Key, Master.IV, Master.KeySalt, Master.AuthKeySalt, authKey);
                return decryptedData;
            }
            return "";
        }

        /// <summary>
        /// Read passwords and info from file and populate fields in-app.
        /// </summary>
        private void PopulateCredentials()
        {
            if (Master.KeyDataNotEmpty())
            {
                string[] storedData = File.ReadAllLines("encryptedPasswords.txt");
                Credentials.Clear();
                Credentials.AddRange(storedData);
                foreach (string line in storedData)
                {
                    string[] split = line.Split('|');
                    CredDescriptions.Items.Add(split[0]);
                    Usernames.Items.Add(split[1]);
                }
            }
        }

        /// <summary>
        /// Encrypts and adds the password to credentials list.
        /// </summary>
        /// <param name="encryptedPasswordAndAuthKey"></param>
        private void AddCredential(string encryptedPasswordAndAuthKey)
        {
            string[] split = encryptedPasswordAndAuthKey.Split('|');
            string encryptedPassword = split[0];
            string authKey = split[1];
            Credentials.Add(CredDesc.Text + "|" + Username.Text + "|" + encryptedPassword + "|" + authKey);
            CredDescriptions.Items.Add(CredDesc.Text);
            Usernames.Items.Add(Username.Text);

            string[] items = new string[Credentials.Count];
            Credentials.CopyTo(items, 0);
            File.WriteAllLines("encryptedPasswords.txt", items);
        }

        private void confrimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Master.KeyMatches(OldKeyEntry.Text))
            {
                Master.Key = NewKeyEntry.Text;
                Master.EncryptAndSaveMasterKey();
                List<string> newCreds = new List<string>();
                foreach(string line in Credentials)
                {
                    string[] split = line.Split('|');
                    newCreds.Add(split[0] + "|" + split[1] + "|" + AesEncryption.EncryptString(split[2], Master.GenerateMasterKeyKey(), Master.IV, Master.KeySalt, Master.AuthKeySalt, Master.AuthKey));
                }
                Credentials = newCreds;
                PopulateCredentials();
            }
        }

        private void ChangeMasterKey()
        {
            if (changeKey != null)
            {
                changeKey.Dispose();
            }
            changeKey = new ChangeKey(true);
            changeKey.FormClosed += KeyChanged;
        }

        private void KeyChanged(object sender, FormClosedEventArgs e)
        {
            if (changeKey.MasterKeyDirty)
            {
                if (Master.KeyDataNotEmpty())
                {
                    string[] storedData = File.ReadAllLines("encryptedPasswords.txt");
                    Credentials.Clear();
                    Credentials.AddRange(storedData);
                    foreach (string line in storedData)
                    {
                        string[] split = line.Split('|');
                        CredDescriptions.Items.Add(split[0]);
                        Usernames.Items.Add(split[1]);
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
                File.WriteAllLines("encryptedPasswords.txt", new string[0]);
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
            File.WriteAllLines("encryptedPasswords.txt", Credentials);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
