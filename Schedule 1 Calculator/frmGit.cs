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
    public partial class frmGit : Form
    {
        public frmGit()
        {
            InitializeComponent();
        }

        private void frmGit_Load(object sender, EventArgs e)
        {
            wbGit.Navigate("https://github.com/qwertymakesstuff");
        }

    }
}
