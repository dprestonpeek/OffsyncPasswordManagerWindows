using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OffSyncPasswordManager
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            SessionTimeoutValue.Value = int.Parse(Main.Instance.Settings[0].Split('=')[1]);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Main.Instance.Settings[0] = "timeout=" + SessionTimeoutValue.Value.ToString();
            Main.Instance.Settings[1] = "defFilter=" + Main.Instance.keywordFilter;
            Main.Instance.SaveSettings();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
