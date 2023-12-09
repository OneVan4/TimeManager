using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TimeManager
{
    public partial class StatsForm10 : Form
    {
        public StatsForm10()
        {
            InitializeComponent();
        }

        private void ExitButton10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menubutton10_Click(object sender, EventArgs e)
        {
            startForm startForm = new startForm();
            Close();
            startForm.Show();
        }

        private void Collapsebutton10_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;    
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
