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
    
    public partial class TimeManagerForm : Form
    {
        public TimeManagerForm()
        {
            InitializeComponent();
        }

        private void menubut5_Click(object sender, EventArgs e)
        {
           startForm form =new startForm();
            Close();
            form.Show();
         

        }
        
        private void TimeManagerForm_Load(object sender, EventArgs e)
        {
            int dv = 0;
            using (StreamReader sr = new StreamReader("dayvalue.txt", Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    dv = Convert.ToInt32(line);
                }
            }

           
            string second = dateTimePicker1.Text,first1="";
            using (StreamReader sr = new StreamReader("WhatDay.txt", Encoding.Default))
            {
                string first;
                while ((first=sr.ReadLine()) != null)
                    
                first1 = first;
            }
           
            if (first1 != second)
            {
                File.Delete("WhatDay.txt");
                using (StreamWriter sw = new StreamWriter("WhatDay.txt", true))
                { sw.WriteLine(dateTimePicker1.Text); }
                dv++;
                File.Delete("dayvalue.txt");
                using (StreamWriter sw = new StreamWriter("dayvalue.txt", true))
                {
                    sw.WriteLine(dv.ToString());
                }
               
            }
            DayLabel.Text = "Day № " + dv.ToString();

            if (dv > 30)
            {
                int EMV=1, WMV=1, SMV=1;
                

                using (StreamReader sr = new StreamReader("EducationMinVar.txt", Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        EMV = Convert.ToInt32(line);
                    }
                }

                using (StreamReader sr = new StreamReader("WorkMinVar.txt", Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        WMV = Convert.ToInt32(line);
                    }
                }
                using (StreamReader sr = new StreamReader("SportMinVar.txt", Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        SMV = Convert.ToInt32(line);
                    }
                }
                int EPV=1, WPV=1, SPV=1, i = 0 ;

                using (StreamReader sr = new StreamReader("EducationGoals.txt", Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        i++;
                        if (i == 2) { EPV = Convert.ToInt32(line); }
                    }
                }
                i = 0;
                using (StreamReader sr = new StreamReader("WorkGoals.txt", Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        i++;
                        if (i == 2) { WPV = Convert.ToInt32(line); }
                    }
                }
                i = 0;
                using (StreamReader sr = new StreamReader("SportGoals.txt", Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        i++;
                        if (i == 2) { SPV = Convert.ToInt32(line); }
                    }
                }
                i = 0;
                double EP = (EMV / EPV) * 100;
                double WP = (WMV / WPV) * 100;
                double SP= (SMV / SPV) * 100;


                //здесь должна быть выгрузка статистики !

                string path = "stats from "+dateTimePicker1.Text+".txt";
                string Title = "There are your stats from " + dateTimePicker1.Text + "!\n"
                    + "Here's what you've invested your time in for the last 30 days :\n";
                string EducationInfo = "You've spent " + EMV.ToString() + " minutes for education, what is " + EP.ToString() + " % of your monthly goal.";
                string WorkInfo = "You've spent " + WMV.ToString() + " minutes for work, what is " + WP.ToString() + " % of your monthly goal.";
                string SportInfo = "You've spent " + SMV.ToString() + " minutes for sport, what is " + SP.ToString() + " % of your monthly goal.";


                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(Title);
                    sw.WriteLine(EducationInfo);
                    sw.WriteLine(WorkInfo);
                    sw.WriteLine(SportInfo);
                }


                File.Delete("dayvalue.txt");
                using (StreamWriter sw = new StreamWriter("dayvalue.txt", true))
                {
                    int d = 1;
                    sw.WriteLine(d.ToString());
                }
                File.Delete("EducationMinVar.txt");
                using (StreamWriter sw = new StreamWriter("EducationMinVar.txt", true))
                {
                    sw.WriteLine(i.ToString());
                }
                File.Delete("WorkMinVar.txt");
                using (StreamWriter sw = new StreamWriter("WorkMinVar.txt", true))
                {
                    sw.WriteLine(i.ToString());
                }
                File.Delete("SportMinVar.txt");
                using (StreamWriter sw = new StreamWriter("SportMinVar.txt", true))
                {
                    sw.WriteLine(i.ToString());
                }


                File.Delete("EducationPB(M)Value.txt");
                using (StreamWriter sw = new StreamWriter("EducationPB(M)Value.txt", true))
                {
                    sw.WriteLine(i.ToString());
                }
                File.Delete("WorkPB(M)Value.txt");
                using (StreamWriter sw = new StreamWriter("WorkPB(M)Value.txt", true))
                {
                    sw.WriteLine(i.ToString());
                }
                File.Delete("SportPB(M)Value.txt");
                using (StreamWriter sw = new StreamWriter("SportPB(M)Value.txt", true))
                {
                    sw.WriteLine(i.ToString());
                }


            }
        }


        public void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void closebutton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void collapseBut5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void EducationButton_Click(object sender, EventArgs e)
        {
            EducationForm Next =new EducationForm();
            Close();
            Next.Show();
            
        }

        private void WWUDlabel_Click(object sender, EventArgs e)
        {

        }

        private void SetGoalsbutton_Click(object sender, EventArgs e)
        {
            SetGoalsForm  next =new SetGoalsForm();
            Close();
            next.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SportButton_Click(object sender, EventArgs e)
        {
            SportForm9 next =new SportForm9();
            Close();
            next.Show();
            
        }

        private void Workbutton_Click(object sender, EventArgs e)
        {
            WorkTimeForm next = new WorkTimeForm();
            Close();
            next.Show();
            
        }

        private void StatsButton_Click(object sender, EventArgs e)
        {
            StatsForm10 next =new StatsForm10();
            Close();
            next.Show();
        }
    }
}
