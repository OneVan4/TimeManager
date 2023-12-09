using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Media;
namespace TimeManager
{
    public partial class DailyListForm : Form
    {
        SoundPlayer SP = new SoundPlayer(Properties.Resources.catsound);
        public DailyListForm()
        {
            InitializeComponent();
            pictureBox1.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {    SP.Stop();
            bool create = false;
            Random rand =  new Random();
            int a = rand.Next(1,300);
            if (a < 250) {
                pictureBox1.Visible = false;
                NearFutureLabel.ForeColor = Color.Red;
                addDailyTaskButton.Enabled = true;
                removebut1.Enabled = true;
                highlightbutton2.Enabled = true;
                menubut2.Enabled = true;
                try
                {        
                    string line;
                    using (StreamReader stream = new StreamReader("dailydone.txt", Encoding.Default))
                    {
                        line = stream.ReadLine();
                    }
                    NearFutureLabel.Text = "for all time u've done " + line + " tasks !";
                }
                
                catch (Exception ex) {
                    create = true;
                    MessageBox.Show(ex.ToString(), "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                if (create) { using (File.Create("dailydone.txt")) ; }
            }
            if (a >= 250) {
                NearFutureLabel.ForeColor = Color.Gold;
                NearFutureLabel.Text = "         Catch a cat !  ";
                pictureBox1.Visible = true;
                addDailyTaskButton.Enabled = false;
                menubut2.Enabled = false;
                removebut1.Enabled = false;
                highlightbutton2.Enabled = false;
                timer1.Start();
            }
            
            
        }

        private void addDailyTaskButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NearFUTUREaddTextbox.Text)) { return; }
            else
            {
                checkedListBox1.Items.Add(NearFUTUREaddTextbox.Text);
                
            }
            using (FileStream file = new FileStream("NearFutureList.txt", FileMode.Append)) {
                using (StreamWriter stream = new StreamWriter(file))
                {
                    stream.WriteLine(NearFUTUREaddTextbox.Text);
                } ;
            }
            NearFUTUREaddTextbox.Text = "";
        }

        private void menubut2_Click(object sender, EventArgs e)
        {
            SP.Stop();
            startForm back = new startForm();
            Close();
            back.Show();
          
        }

        private void removebut1_Click(object sender, EventArgs e)
        {
            int amount;
            using (StreamReader stream = new StreamReader("dailydone.txt", Encoding.Default))
            { string line;
                 line= stream.ReadLine();
                amount = Convert.ToInt32(line);
            }
            File.Delete("dailydone.txt");
            File.Delete("NearFutureList.txt");
            List<string> newarr=new List<string>();
            for (int i = checkedListBox1.Items.Count - 1; i >= 0; i--)
            {

                if (checkedListBox1.GetItemChecked(i))
                {
                    amount++;
                    checkedListBox1.Items.Remove(checkedListBox1.Items[i]);
                }
                else { newarr.Add(checkedListBox1.Items[i].ToString()); }
            }
            using (StreamWriter stream = new StreamWriter("NearFutureList.txt", true))
            {
                foreach (string line in newarr)
                {
                    stream.WriteLine(line);
                }
            }
            using (StreamWriter stream =new StreamWriter("dailydone.txt", true))
            {
                stream.WriteLine(amount.ToString());
            }
            
        }

        private void DailyListForm_Load(object sender, EventArgs e)
        {    if (File.Exists("NearFutureList.txt"))
            {
                using (StreamReader stream = new StreamReader("NearFutureList.txt", Encoding.Default))
                {
                    string line;
                    while ((line = stream.ReadLine()) != null)
                    {
                        checkedListBox1.Items.Add(line);
                    }
                }
            }
        else { using (File.Create("NearFutureList.txt")) ; }
            
        }

        private void highlightbutton2_Click(object sender, EventArgs e)
        {
          
            File.Delete("NearFutureList.txt");
            List<string> newlist = new List<string>();
            for(int i = 0; i<=checkedListBox1.Items.Count-1; i++)
            {   if(checkedListBox1.GetItemChecked(i))
                { newlist=newlist.Prepend(checkedListBox1.Items[i].ToString()).ToList(); }
               else newlist.Add(checkedListBox1.Items[i].ToString());
                
            }
            checkedListBox1.Items.Clear();
            foreach(string line in newlist)
            {    checkedListBox1.Items.Add(line); 
                using (StreamWriter stream = new StreamWriter("NearFutureList.txt", true))
                {
                    stream.WriteLine(line);
                }
            }

        }

        private void collapsebutton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closebutton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             pictureBox1.Hide();
            addDailyTaskButton.Enabled = true;
            removebut1.Enabled = true;
            highlightbutton2.Enabled = true;
            menubut2.Enabled = true;
            timer1.Stop();
            NearFutureLabel.Text = "         Have the best day !  "; 
            SP.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 450; 
            Random rand = new Random();
            int x = rand.Next(1, 800);
            int y = rand.Next(100,500 );
            int dx = rand.Next(-5, 10);
           int  dy = rand.Next(-5, 8);
            pictureBox1.Left = x += dx;
            pictureBox1.Top = y += dy;
            
        }
    }
}
