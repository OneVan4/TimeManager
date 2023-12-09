namespace TimeManager
{
    partial class EducationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EducationStopButton = new System.Windows.Forms.Button();
            this.EducationTimeLabel = new System.Windows.Forms.Label();
            this.EducationStartButton = new System.Windows.Forms.Button();
            this.GoalLabel1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.MonthGoalLabel1 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.ExitButton6 = new System.Windows.Forms.Button();
            this.Collapsebutton6 = new System.Windows.Forms.Button();
            this.menubut6 = new System.Windows.Forms.Button();
            this.Label134 = new System.Windows.Forms.Label();
            this.label713 = new System.Windows.Forms.Label();
            this.Resetbutton1 = new System.Windows.Forms.Button();
            this.EducationTimeLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EducationStopButton
            // 
            this.EducationStopButton.Location = new System.Drawing.Point(847, 255);
            this.EducationStopButton.Name = "EducationStopButton";
            this.EducationStopButton.Size = new System.Drawing.Size(94, 29);
            this.EducationStopButton.TabIndex = 0;
            this.EducationStopButton.Text = "Stop";
            this.EducationStopButton.UseVisualStyleBackColor = true;
            this.EducationStopButton.Click += new System.EventHandler(this.EducationStopButton_Click);
            // 
            // EducationTimeLabel
            // 
            this.EducationTimeLabel.AutoSize = true;
            this.EducationTimeLabel.Location = new System.Drawing.Point(786, 184);
            this.EducationTimeLabel.Name = "EducationTimeLabel";
            this.EducationTimeLabel.Size = new System.Drawing.Size(63, 20);
            this.EducationTimeLabel.TabIndex = 1;
            this.EducationTimeLabel.Text = "00:00:00";
            this.EducationTimeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // EducationStartButton
            // 
            this.EducationStartButton.Location = new System.Drawing.Point(693, 255);
            this.EducationStartButton.Name = "EducationStartButton";
            this.EducationStartButton.Size = new System.Drawing.Size(94, 29);
            this.EducationStartButton.TabIndex = 2;
            this.EducationStartButton.Text = "Start";
            this.EducationStartButton.UseVisualStyleBackColor = true;
            this.EducationStartButton.Click += new System.EventHandler(this.EducationStartButton_Click);
            // 
            // GoalLabel1
            // 
            this.GoalLabel1.AutoSize = true;
            this.GoalLabel1.Location = new System.Drawing.Point(85, 84);
            this.GoalLabel1.Name = "GoalLabel1";
            this.GoalLabel1.Size = new System.Drawing.Size(78, 20);
            this.GoalLabel1.TabIndex = 3;
            this.GoalLabel1.Text = "Daily Goal";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(51, 119);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(125, 29);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // MonthGoalLabel1
            // 
            this.MonthGoalLabel1.AutoSize = true;
            this.MonthGoalLabel1.Location = new System.Drawing.Point(85, 195);
            this.MonthGoalLabel1.Name = "MonthGoalLabel1";
            this.MonthGoalLabel1.Size = new System.Drawing.Size(98, 20);
            this.MonthGoalLabel1.TabIndex = 5;
            this.MonthGoalLabel1.Text = "Monthly Goal";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(51, 231);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(125, 29);
            this.progressBar2.TabIndex = 6;
            this.progressBar2.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // ExitButton6
            // 
            this.ExitButton6.BackColor = System.Drawing.Color.DarkGray;
            this.ExitButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitButton6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton6.ForeColor = System.Drawing.Color.Red;
            this.ExitButton6.Location = new System.Drawing.Point(998, 0);
            this.ExitButton6.Name = "ExitButton6";
            this.ExitButton6.Size = new System.Drawing.Size(54, 35);
            this.ExitButton6.TabIndex = 14;
            this.ExitButton6.Text = "X";
            this.ExitButton6.UseVisualStyleBackColor = false;
            this.ExitButton6.Click += new System.EventHandler(this.button1_Click);
            // 
            // Collapsebutton6
            // 
            this.Collapsebutton6.BackColor = System.Drawing.Color.DarkGray;
            this.Collapsebutton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Collapsebutton6.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Collapsebutton6.ForeColor = System.Drawing.Color.Red;
            this.Collapsebutton6.Location = new System.Drawing.Point(937, 0);
            this.Collapsebutton6.Name = "Collapsebutton6";
            this.Collapsebutton6.Size = new System.Drawing.Size(54, 35);
            this.Collapsebutton6.TabIndex = 15;
            this.Collapsebutton6.Text = "__";
            this.Collapsebutton6.UseVisualStyleBackColor = false;
            this.Collapsebutton6.Click += new System.EventHandler(this.button2_Click);
            // 
            // menubut6
            // 
            this.menubut6.BackColor = System.Drawing.SystemColors.Desktop;
            this.menubut6.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menubut6.ForeColor = System.Drawing.Color.Red;
            this.menubut6.Location = new System.Drawing.Point(843, 506);
            this.menubut6.Name = "menubut6";
            this.menubut6.Size = new System.Drawing.Size(209, 48);
            this.menubut6.TabIndex = 16;
            this.menubut6.Text = "Menu";
            this.menubut6.UseVisualStyleBackColor = false;
            this.menubut6.Click += new System.EventHandler(this.menubut5_Click);
            // 
            // Label134
            // 
            this.Label134.AutoSize = true;
            this.Label134.Location = new System.Drawing.Point(261, 121);
            this.Label134.Name = "Label134";
            this.Label134.Size = new System.Drawing.Size(0, 20);
            this.Label134.TabIndex = 17;
            // 
            // label713
            // 
            this.label713.AutoSize = true;
            this.label713.Location = new System.Drawing.Point(261, 240);
            this.label713.Name = "label713";
            this.label713.Size = new System.Drawing.Size(0, 20);
            this.label713.TabIndex = 18;
            // 
            // Resetbutton1
            // 
            this.Resetbutton1.Location = new System.Drawing.Point(85, 282);
            this.Resetbutton1.Name = "Resetbutton1";
            this.Resetbutton1.Size = new System.Drawing.Size(94, 29);
            this.Resetbutton1.TabIndex = 19;
            this.Resetbutton1.Text = "Reset";
            this.Resetbutton1.UseVisualStyleBackColor = true;
            this.Resetbutton1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // EducationTimeLabel2
            // 
            this.EducationTimeLabel2.AutoSize = true;
            this.EducationTimeLabel2.Location = new System.Drawing.Point(423, 27);
            this.EducationTimeLabel2.Name = "EducationTimeLabel2";
            this.EducationTimeLabel2.Size = new System.Drawing.Size(116, 20);
            this.EducationTimeLabel2.TabIndex = 20;
            this.EducationTimeLabel2.Text = "Education Time!";
            this.EducationTimeLabel2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // EducationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 630);
            this.Controls.Add(this.EducationTimeLabel2);
            this.Controls.Add(this.Resetbutton1);
            this.Controls.Add(this.label713);
            this.Controls.Add(this.Label134);
            this.Controls.Add(this.menubut6);
            this.Controls.Add(this.Collapsebutton6);
            this.Controls.Add(this.ExitButton6);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.MonthGoalLabel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.GoalLabel1);
            this.Controls.Add(this.EducationStartButton);
            this.Controls.Add(this.EducationTimeLabel);
            this.Controls.Add(this.EducationStopButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EducationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.EducationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button EducationStopButton;
        private Label EducationTimeLabel;
        private Button EducationStartButton;
        private Label GoalLabel1;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
        private Label MonthGoalLabel1;
        private ProgressBar progressBar2;
        private Button ExitButton6;
        private Button Collapsebutton6;
        private Button menubut6;
        private Label Label134;
        private Label label713;
        private Button Resetbutton1;
        private Label EducationTimeLabel2;
    }
}