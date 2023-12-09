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
    public partial class SportForm9 : Form
    {
        Timer timer = new Timer();
        public SportForm9()
        {
            InitializeComponent();
        }
        int progressBAR2Val = 0;

        private void SportForm9_Load(object sender, EventArgs e)
        {
            int DaVa = 0;
            int MoVa = 0;
            using (StreamReader stream = new StreamReader("SportGoals.txt", Encoding.Default))
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
                progressBar6.Maximum = 60 * Mova;

            }
            int getval = 0;
            using (StreamReader stream = new StreamReader("SportPB(M)Value.txt", Encoding.Default))
            {
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    getval = Convert.ToInt32(line);
                }
            }
            progressBar6.Value = getval;
            if (progressBar6.Value == progressBar6.Maximum) label222.Text = "Congratulations!You've reached your " +
                    "monthly goal!";
        }

        private void GymStartButton_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }
        int counterD = 0, counterM = 0;

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Interval = 1000;
            timer.Add();
            SportTimeLabel.Text = timer.GetTime();
            progressBar5.Maximum = Dava * 60;
            progressBar6.Maximum = Mova * 60;
            counterD++;
            if (counterD == progressBar5.Maximum) { counterD = 0; progressBar5.Value = 0; label111.Text = "Done !Good Job!"; }
            if (progressBar6.Value != Mova * 60) { progressBar6.Value += 1; }
            if (counterM == progressBar6.Maximum || progressBar6.Value == progressBar6.Maximum)
            {
                label222.Text = "Congratulations!You've reached your monthly goal!";
                counterM = 0;
            }
            progressBar5.Value += 1;
        }
        int Dava; int Mova;

        private void Resetbutton3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("do you really want to reset your timer ?", "Warning!",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                progressBar6.Value = 0;
            }
            else { };
        }

        private void ExitButton10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Collapsebutton9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void menubut9_Click(object sender, EventArgs e)
        {
            startForm back = new startForm();
            back.Show();
            Close();
        }



        private void GymStopButton_Click(object sender, EventArgs e)
        {
            progressBAR2Val = progressBar6.Value;
            File.Delete("SportPB(M)Value.txt");
            using (StreamWriter stream = new StreamWriter("SportPB(M)Value.txt", true))
            {
                stream.WriteLine(progressBAR2Val.ToString());
            };
            timer3.Stop();

            int domik = 0;
            int To_ADD = timer.Get();
            string line;
            using (StreamReader stream = new StreamReader("SportMinVar.txt", Encoding.Default))
            {
                while ((line = stream.ReadLine()) != null)
                {
                    if (stream.ReadLine() != null) { domik = 0; }
                    else domik = Convert.ToInt32(line);
                }
            }
            domik = domik + To_ADD;
            File.Delete("SportMinVar.txt");
            using (StreamWriter stream2 = new StreamWriter("SportMinVar.txt", true))
            {
                stream2.WriteLine(domik.ToString());
            }


            timer.reset();
            SportTimeLabel.Text = timer.GetTime();
        }

    }
}
    

