using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeManager
{
    public partial class DailyGlobalListForm : Form
    {
        public DailyGlobalListForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GlobalListForm next = new GlobalListForm();
            Close();
            next.Show();
            
        }

        private void DailyListButton_Click(object sender, EventArgs e)
        {
            DailyListForm next = new DailyListForm();
            Close();
            next.Show();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menuBut1_Click(object sender, EventArgs e)
        {
            startForm previous =new startForm();
            Close();
            previous.Show();
      
        }

        private void closebutton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void collapsebutton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
