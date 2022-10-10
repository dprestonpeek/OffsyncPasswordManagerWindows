using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OffSyncPasswordManager
{
    public partial class ConfirmationWindow : Form
    {
        public bool Confirmed = false;
        public ConfirmationWindow(string title, string text)
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Confirmed = true;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Confirmed = false;
            Close();
        }
    }
}
