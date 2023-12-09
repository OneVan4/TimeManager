using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TimeManager
{
   
    public partial class startForm : Form
    {

        bool gef = false;
        public startForm()
        {
            InitializeComponent();
            Thread th = new Thread(() =>
            {
                while (!gef)
                {
                    for (int i = 1; i <= 3; i++)
                    {
                        Random rand = new Random();
                        int getcolor = rand.Next(1, 3);
                        if (getcolor == 1)
                        { ToDoListButton.ForeColor = Color.Black; }
                        if (getcolor == 2) { ToDoListButton.ForeColor = Color.Gold; }
                       
                        Thread.Sleep(1000);
                    }
                }
                gef = false;
            })
            { IsBackground = false };
            th.Start();


            }

          

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void publForm1_Load(object sender, EventArgs e)
        {

        }

      

        private void ToDoListButton_Click(object sender, EventArgs e)
        {
            DailyGlobalListForm nextform=new DailyGlobalListForm();
            nextform.Show();
            Hide();
            gef= true;
            
        }

     

        

        private void closebutton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TimeManagmentButton_Click(object sender, EventArgs e)
        {
            TimeManagerForm next = new TimeManagerForm();
            next.Show();
            Hide();
        }

        private void collapsebutton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}