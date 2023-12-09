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
    public partial class WorkTimeForm : Form
    {
        Timer timer = new Timer();
        public WorkTimeForm()
        {
            InitializeComponent();
        }
        int progressBAR2Val = 0;
        private void WorkStartButton_Click(object sender, EventArgs e)
        {

            timer2.Start();
        }

        int counterD = 0, counterM = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
            timer.Add();
            WorkTimeLabel.Text = timer.GetTime();
            progressBar3.Maximum = Dava * 60;
            progressBar4.Maximum = Mova * 60;
            counterD++;
            if (counterD == progressBar3.Maximum) { counterD = 0; progressBar3.Value = 0; label111.Text = "Done !Good Job!"; }
            if (progressBar4.Value != Mova * 60) { progressBar4.Value += 1; }
            if (counterM == progressBar4.Maximum || progressBar4.Value == progressBar4.Maximum)
            {
                label222.Text = "Congratulations!You've reached your monthly goal!";
                counterM = 0;
            }
            progressBar3.Value += 1;
        }
        int Dava ;
        int Mova ;

        private void WorkStopButton_Click(object sender, EventArgs e)
        {
            progressBAR2Val = progressBar4.Value;
            File.Delete("WorkPB(M)Value.txt");
            using (StreamWriter stream = new StreamWriter("WorkPB(M)Value.txt", true))
            {
                stream.WriteLine(progressBAR2Val.ToString());
            };
            timer2.Stop();
            
            int domik = 0;
            int To_ADD = timer.Get();
            string line;
            using (StreamReader stream = new StreamReader("WorkMinVar.txt", Encoding.Default))
            {
                while ((line = stream.ReadLine()) != null)
                {
                    if (stream.ReadLine() != null) { domik = 0; }
                    else domik = Convert.ToInt32(line);
                }
            }
            domik = domik + To_ADD;
            File.Delete("WorkMinVar.txt");
            using (StreamWriter stream2 = new StreamWriter("WorkMinVar.txt", true))
            {
                stream2.WriteLine(domik.ToString());
            };



            timer.reset();
            WorkTimeLabel.Text = timer.GetTime();
        }

        private void Resetbutton2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("do you really want to reset your timer ?", "Warning!",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                progressBar4.Value = 0;
            }
            else { };
        }

        private void ExitButton8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Collapsebutton8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void menubut8_Click(object sender, EventArgs e)
        {
            startForm back = new startForm();
            Close();
            back.Show();
        }

        private void WorkTimeForm_Load(object sender, EventArgs e)
        {
            int DaVa = 0;
            int MoVa = 0;
            using (StreamReader stream = new StreamReader("WorkGoals.txt", Encoding.Default))
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
                progressBar4.Maximum = 60 * Mova;

            }
            int getval = 0;
            using (StreamReader stream = new StreamReader("WorkPB(M)Value.txt", Encoding.Default))
            {
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    getval = Convert.ToInt32(line);
                }
            }
            progressBar4.Value = getval;
            if (progressBar4.Value == progressBar4.Maximum) label222.Text = "Congratulations!You've reached your " +
                    "monthly goal!";
        }

        


    }
}
