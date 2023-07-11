using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OffSyncPasswordManager
{
    public partial class KeywordFilter : Form
    {
        bool keywordSet = false;
        public KeywordFilter()
        {
            InitializeComponent();
        }

        private void SetFilter_Click(object sender, EventArgs e)
        {
            Main.Instance.keywordFilter = Keyword.Text;
            keywordSet = true;
            Close();
        }

        private void KeywordFilter_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!keywordSet)
            {
                Main.Instance.keywordFilter = "[cancel]";
            }
        }
    }
}
