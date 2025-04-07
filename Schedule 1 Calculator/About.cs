using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Schedule_1_Calculator
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGit_Click(object sender, EventArgs e)
        {
            frmGit git = new frmGit();
            git.ShowDialog();
        }
    }
}
