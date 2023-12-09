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
     
    public partial class EducationForm : Form
    {
       



        Timer timer = new Timer();
        public EducationForm()
        { 
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        int counterD = 0, counterM = 0; 
        private void timer1_Tick(object sender, EventArgs e)
        {
           timer1.Interval = 1000;
            timer.Add();
            EducationTimeLabel.Text = timer.GetTime();
            progressBar1.Maximum = Dava*60;
            progressBar2.Maximum = Mova*60;
            counterD++;
            if(counterD == progressBar1.Maximum) { counterD = 0; progressBar1.Value = 0; Label134.Text = "Done !Good Job!"; }
            if (progressBar2.Value != Mova * 60) { progressBar2.Value += 1; }
            if (counterM == progressBar2.Maximum||progressBar2.Value==progressBar2.Maximum) { label713.Text = "Congratulations!You've reached your monthly goal!";
                counterM = 0;  }
            progressBar1.Value += 1; 
            
        }
        int Dava = 0; int Mova = 0;
        private void EducationStartButton_Click(object sender, EventArgs e)
        {
            temp = true;
            timer1.Start();
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        bool temp = true;
        int progressBAR2Val = 0;
        private void EducationStopButton_Click(object sender, EventArgs e)
        {   progressBAR2Val=progressBar2.Value;
            File.Delete("EducationPB(M)Value.txt");
            using (StreamWriter stream = new StreamWriter("EducationPB(M)Value.txt", true))
            {
                stream.WriteLine(progressBAR2Val.ToString());
            } ;
           timer1.Stop();
            temp = false;
            int domik =0 ;
            int To_ADD = timer.Get();
            string line;
            using (StreamReader stream = new StreamReader("EducationMinVar.txt", Encoding.Default))
            {
                while ((line = stream.ReadLine()) != null)
                {
                    if (stream.ReadLine() != null) { domik = 0; }
                    else domik = Convert.ToInt32(line);
                }
            }
                domik = domik + To_ADD;
                File.Delete("EducationMinVar.txt");
                using (StreamWriter stream2 = new StreamWriter("EducationMinVar.txt", true))
                {
                    stream2.WriteLine(domik.ToString());
                } ;
            


            timer.reset();
            EducationTimeLabel.Text =timer.GetTime();
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menubut5_Click(object sender, EventArgs e)
        {
            startForm back = new startForm();
            Close();
            back.Show();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(DialogResult.Yes== MessageBox.Show("do you really want to reset your timer ?","Warning!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                progressBar2.Value = 0;
            }
            else { };
        }

        private void EducationForm_Load(object sender, EventArgs e)
        {
           
               int DaVa = 0;
            int MoVa = 0;
            using (StreamReader stream = new StreamReader("EducationGoals.txt", Encoding.Default))
            {
                int i = 0;
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    i++;
                    if (i == 1)
                    {
                        DaVa = Convert.ToInt32(line);
                    }
                    if (i == 2)
                    {
                        MoVa = Convert.ToInt32(line);
                    }
                }
                Dava = DaVa;
                Mova = MoVa;
                progressBar2.Maximum = 60 * Mova;

            }
            int getval = 0;
            using (StreamReader stream = new StreamReader("EducationPB(M)Value.txt", Encoding.Default))
            {
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    getval = Convert.ToInt32(line);
                }
            }
            progressBar2.Value = getval;
            if (progressBar2.Value == progressBar2.Maximum) label713.Text = "Congratulations!You've reached your " +
                    "monthly goal!";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
            }
    }
}
