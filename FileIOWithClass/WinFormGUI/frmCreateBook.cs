using System;
using System.Windows.Forms;

namespace WinFormGUI
{
    public partial class frmCreateBook : Form
    {
        public frmCreateBook()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
