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
        public ErrorWindow()
        {
            InitializeComponent();
        }

        private void ErrorOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
