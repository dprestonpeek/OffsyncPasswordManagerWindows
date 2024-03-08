using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OffSyncPasswordManager
{
    public partial class EnterMasterKey : Form
    {
        Main main;
        ChangeKey changeKey;
        ErrorWindow error;
        public bool prevent = true;
        public EnterMasterKey()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                Master.Key = MasterKeyEntry.Text;
                if (Master.KeyCorrect())
                {
                    prevent = false;
                    ShowMainForm();
                }
                else
                {
                    prevent = true;
                }
            }
            catch(Exception ex)
            {
                Master.Key = "";
                prevent = true;
                error = new ErrorWindow(ex.Message);
                error.ShowDialog();
            }
            MasterKeyEntry.Text = "";
        }

        private void KeyChanged(object sender, FormClosedEventArgs e)
        {
            if (changeKey.enteredKey)
            {
                Master.Key = changeKey.NewMasterKey;
                prevent = false;
                ShowMainForm();
            }
            else
            {
                Application.Exit();
            }
        }

        private void ShowMainForm()
        {
            main = new Main();
            main.Show();
            main.FormClosed += CloseForm;
            Hide();
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Close();
            if (main == null)
            {
                Application.Exit();
            }
            else
            {
                main.Dispose();
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!Master.KeyExists())
            {
                ShowChangeKeyWindow();
            }
            timer1.Enabled = false;
        }

        private void ShowChangeKeyWindow()
        {
            changeKey = new ChangeKey(false);
            changeKey.Show();
            changeKey.FormClosed += KeyChanged;
            Hide();
        }
    }
}
