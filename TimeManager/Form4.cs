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


    public partial class GlobalListForm : Form
    {

        
        public GlobalListForm()
        {
            InitializeComponent();
        }

        private void menubut2_Click(object sender, EventArgs e)
        {
            startForm back = new startForm();
            Close();
            back.Show();
         
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removebut2_Click(object sender, EventArgs e)
        {
            int amount;
            using (StreamReader stream = new StreamReader("globaldone.txt", Encoding.Default))
            {
                string line;
                line = stream.ReadLine();
                amount = Convert.ToInt32(line);
            }
            var text = File.ReadAllText("GlobalTasks.txt", Encoding.Default);
            File.Delete("globaldone.txt");
            File.Delete("GlobalTasks.txt");
            List<string> newarr = new List<string>();
            for (int i = checkedListBox2.Items.Count - 1; i >= 0; i--)
            {
                if (checkedListBox2.GetItemChecked(i))
                {
                    amount++;
                    checkedListBox2.Items.Remove(checkedListBox2.Items[i]);
                }
                else
                {
                    newarr.Add(checkedListBox2.Items[i].ToString());
                }
            }
            foreach (string line in newarr)
            {
                using (StreamWriter stream = new StreamWriter("GlobalTasks.txt", true))
                {
                    stream.WriteLine(line);
                }
            }
            using (StreamWriter stream = new StreamWriter("globaldone.txt", true))
            {
                stream.WriteLine(amount.ToString());
            }

        }


        private void GlobalTODOLabel_Click(object sender, EventArgs e)
        { bool create = false;
            Random rand = new Random();
            int a = rand.Next(1, 300);
            if (a < 250)
            {
                GlobalTODOLabel.ForeColor = Color.MidnightBlue;
                try
                {
                    string line;
                    using (StreamReader stream = new StreamReader("globaldone.txt", Encoding.Default))
                    {
                        line = stream.ReadLine();
                    }
                    GlobalTODOLabel.Text = "for all time u've done " + line + " tasks !";
                }

                catch (Exception ex)
                {
                    create = true;
                    MessageBox.Show(ex.ToString(), "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (create) { using (File.Create("globaldone.txt")) ; }
            }
            if (a >= 250)
            {
                GlobalTODOLabel.Text = " What's up ? ";
            }
        }

        private void addGlobalTaskButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(GlobalToDOaddTextbox.Text)) { return; }

            checkedListBox2.Items.Add(GlobalToDOaddTextbox.Text);
           using (FileStream file = new FileStream("GlobalTasks.txt", FileMode.Append))
            {
                using (StreamWriter stream = new StreamWriter(file))
                {
                    stream.WriteLine(GlobalToDOaddTextbox.Text);
                }
            }
        
        GlobalToDOaddTextbox.Text = "";
        }

        private void GlobalToDOaddTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void highlightbutton1_Click(object sender, EventArgs e)
        {
            File.Delete("GlobalTasks.txt");
            List<string> newlist = new List<string>();
            for (int i = 0; i <= checkedListBox2.Items.Count - 1; i++)
            {
                if (checkedListBox2.GetItemChecked(i))
                { newlist = newlist.Prepend(checkedListBox2.Items[i].ToString()).ToList(); }
                else newlist.Add(checkedListBox2.Items[i].ToString());

            }
            checkedListBox2.Items.Clear();
            foreach (string line in newlist)
            {
                checkedListBox2.Items.Add(line);
                using (StreamWriter stream = new StreamWriter("GlobalTasks.txt", true))
                {
                    stream.WriteLine(line);
                }
            }

        
        }

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void GlobalListForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("GlobalTasks.txt"))
            {
                using (StreamReader stream = new StreamReader("GlobalTasks.txt", Encoding.Default)) {
                    string line;
                    while ((line=stream.ReadLine()) != null)
                    {
                        checkedListBox2.Items.Add(line);
                    }
                }
            }
            else { using (File.Create("GlobalTasks.txt")) ; }
        }

        private void collapseBut2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closebutton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

