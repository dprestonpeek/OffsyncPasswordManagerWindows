using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OffSyncPasswordManager
{
    public partial class ErrorWindow : Form
    {
        public ErrorWindow(string errorMessage)
        {
            InitializeComponent();
            ErrorMessage.Text = errorMessage;
        }

        private void ErrorOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
