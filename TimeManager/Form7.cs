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
    public partial class SetGoalsForm : Form
        
{
        public SetGoalsForm()
        {
            InitializeComponent();

        }

        private void Closebutton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CollapseButton7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MenuButton7_Click(object sender, EventArgs e)
        {
            startForm back = new startForm();
            Close();
            back.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Mlable_Click(object sender, EventArgs e)
        {

        }

        private void EducationSetButton_Click(object sender, EventArgs e)
        {
            File.Delete("EducationGoals.txt");
            File.Delete("SportGoals.txt");
            File.Delete("WorkGoals.txt");
            int ED = 0, EM = 0;
            if (EducationtextBoxD.Text == "") { ED = 0; }
            else
            {
                try { ED = Convert.ToInt32(EducationtextBoxD.Text); }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString()
 , "WARNING! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
            }
            if (EducationTextBoxM.Text == "") { EM = 0; }
            else
            {
                try { EM = Convert.ToInt32(EducationTextBoxM.Text); }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString()
 , "WARNING! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
            }

            int SD = 0, SM = 0;
            if (EducationtextBoxD.Text == "") { SD = 0; }
            else
            {
                try { SD = Convert.ToInt32(SportTextBoxD.Text); }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString()
 , "WARNING! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
            }
            if (EducationTextBoxM.Text == "") { SM = 0; }
            else
            {
                try { SM = Convert.ToInt32(SportTextBoxM.Text); }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString()
 , "WARNING! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
            }

            int WD = 0, WM = 0;
            if (EducationtextBoxD.Text == "") { WD = 0; }
            else
            {
                try { WD = Convert.ToInt32(WorkDtextBox.Text); }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString()
 , "WARNING! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
            }
            if (EducationTextBoxM.Text == "") { WM = 0; }
            else
            {
                try { WM = Convert.ToInt32(WorkMTextBox.Text); }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString()
 , "WARNING! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
            }
            using (StreamWriter stream = new StreamWriter("EducationGoals.txt", true))
            {
                stream.WriteLine(ED.ToString());
                stream.WriteLine(EM.ToString());
            }
            
            using (StreamWriter stream = new StreamWriter("SportGoals.txt", true))
            {
                stream.WriteLine(SD.ToString());
                stream.WriteLine(SM.ToString());
            }
            
            using (StreamWriter stream = new StreamWriter("WorkGoals.txt", true))
            {
                stream.WriteLine(WD.ToString());
                stream.WriteLine(WM.ToString());
            }
            MessageBox.Show("Your data has been saved !", "Success",
MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


        }

        private void EducationtextBoxD_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetGoalsForm_Load(object sender, EventArgs e)
        {

            using (StreamReader stream = new StreamReader("EducationGoals.txt", Encoding.Default))
            {
                int i = 0;
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    i++;
                    if (i == 1)
                    {
                        EducationtextBoxD.Text = line;
                    }
                    if (i == 2) { EducationTextBoxM.Text = line; }
                }
                i = 0;
                using (StreamReader stream1 = new StreamReader("SportGoals.txt", Encoding.Default))
                { while ((line = stream1.ReadLine()) != null) {
                        i++;
                        if (i == 1)
                        {
                            SportTextBoxD.Text = line;
                        }
                        if (i == 2) { SportTextBoxM.Text = line; }

                    } }
                i = 0;
                using (StreamReader stream2 = new StreamReader("WorkGoals.txt", Encoding.Default))
                {
                    while ((line = stream2.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1)
                        {
                            WorkDtextBox.Text = line;
                        }
                        if (i == 2) { WorkMTextBox.Text = line; }

                    }
                }
                i = 0;
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        { double gothours=0;
            try
            {
                gothours = Convert.ToDouble(HourstextBox.Text);
            }
            catch(Exception ex ) {
                MessageBox.Show("You have to enter the number !", "Error",
MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            double HMM = gothours * 60;
            HowMuchMinutesLabel.Text = HMM.ToString();
  

        }

        private void HourstextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HowMuchMinutesLabel_Click(object sender, EventArgs e)
        {

        }
    }

}

