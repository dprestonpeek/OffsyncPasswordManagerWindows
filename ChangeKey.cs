using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OffSyncPasswordManager
{
    public partial class ChangeKey : Form
    {
        public bool enteredKey = false;

        public bool MasterKeyDirty = false;
        public string NewMasterKey = "";

        private bool oldKeyExists = true;

        public ChangeKey(bool oldKeyExists)
        {
            InitializeComponent();
            this.oldKeyExists = oldKeyExists;

            PreviousKey.Enabled = oldKeyExists;
            PreviousKeyLabel.Enabled = oldKeyExists;
        }

        private void ChangeKeyButton_Click(object sender, EventArgs e)
        {
            if ((PreviousKey.Text.Equals(Master.Key) || !oldKeyExists) && (NewKey1.Text != "" && NewKey2.Text != ""))
            {
                if (NewKey1.Text.Equals(NewKey2.Text))
                {
                    MasterKeyDirty = true;
                    NewMasterKey = NewKey2.Text;
                    enteredKey = true;
                    Close();
                }
            }
        }

        private void ChangeKey_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
