namespace TimeManager
{
    partial class DailyListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyListForm));
            this.NearFUTUREaddTextbox = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.NearFutureLabel = new System.Windows.Forms.Label();
            this.addDailyTaskButton = new System.Windows.Forms.Button();
            this.menubut2 = new System.Windows.Forms.Button();
            this.removebut1 = new System.Windows.Forms.Button();
            this.highlightbutton2 = new System.Windows.Forms.Button();
            this.closebutton3 = new System.Windows.Forms.Button();
            this.collapsebutton3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NearFUTUREaddTextbox
            // 
            this.NearFUTUREaddTextbox.BackColor = System.Drawing.SystemColors.Info;
            this.NearFUTUREaddTextbox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NearFUTUREaddTextbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NearFUTUREaddTextbox.Location = new System.Drawing.Point(33, 527);
            this.NearFUTUREaddTextbox.Name = "NearFUTUREaddTextbox";
            this.NearFUTUREaddTextbox.Size = new System.Drawing.Size(495, 34);
            this.NearFUTUREaddTextbox.TabIndex = 0;
            this.NearFUTUREaddTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Info;
            this.checkedListBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(33, 78);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(994, 439);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // NearFutureLabel
            // 
            this.NearFutureLabel.AutoSize = true;
            this.NearFutureLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.NearFutureLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NearFutureLabel.ForeColor = System.Drawing.Color.Red;
            this.NearFutureLabel.Location = new System.Drawing.Point(255, 9);
            this.NearFutureLabel.Name = "NearFutureLabel";
            this.NearFutureLabel.Size = new System.Drawing.Size(550, 47);
            this.NearFutureLabel.TabIndex = 2;
            this.NearFutureLabel.Text = "To-Do list for the near future";
            this.NearFutureLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // addDailyTaskButton
            // 
            this.addDailyTaskButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.addDailyTaskButton.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addDailyTaskButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addDailyTaskButton.Location = new System.Drawing.Point(565, 523);
            this.addDailyTaskButton.Name = "addDailyTaskButton";
            this.addDailyTaskButton.Size = new System.Drawing.Size(209, 48);
            this.addDailyTaskButton.TabIndex = 3;
            this.addDailyTaskButton.Text = "Add Task";
            this.addDailyTaskButton.UseVisualStyleBackColor = false;
            this.addDailyTaskButton.Click += new System.EventHandler(this.addDailyTaskButton_Click);
            // 
            // menubut2
            // 
            this.menubut2.BackColor = System.Drawing.SystemColors.Desktop;
            this.menubut2.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menubut2.ForeColor = System.Drawing.Color.Red;
            this.menubut2.Location = new System.Drawing.Point(808, 523);
            this.menubut2.Name = "menubut2";
            this.menubut2.Size = new System.Drawing.Size(209, 48);
            this.menubut2.TabIndex = 4;
            this.menubut2.Text = "Menu";
            this.menubut2.UseVisualStyleBackColor = false;
            this.menubut2.Click += new System.EventHandler(this.menubut2_Click);
            // 
            // removebut1
            // 
            this.removebut1.BackColor = System.Drawing.Color.Red;
            this.removebut1.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removebut1.ForeColor = System.Drawing.Color.Black;
            this.removebut1.Location = new System.Drawing.Point(852, 451);
            this.removebut1.Name = "removebut1";
            this.removebut1.Size = new System.Drawing.Size(175, 66);
            this.removebut1.TabIndex = 5;
            this.removebut1.Text = "Remove";
            this.removebut1.UseVisualStyleBackColor = false;
            this.removebut1.Click += new System.EventHandler(this.removebut1_Click);
            // 
            // highlightbutton2
            // 
            this.highlightbutton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.highlightbutton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.highlightbutton2.Location = new System.Drawing.Point(852, 380);
            this.highlightbutton2.Name = "highlightbutton2";
            this.highlightbutton2.Size = new System.Drawing.Size(175, 65);
            this.highlightbutton2.TabIndex = 11;
            this.highlightbutton2.Text = "Hghlight";
            this.highlightbutton2.UseVisualStyleBackColor = false;
            this.highlightbutton2.Click += new System.EventHandler(this.highlightbutton2_Click);
            // 
            // closebutton3
            // 
            this.closebutton3.BackColor = System.Drawing.Color.DarkGray;
            this.closebutton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closebutton3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closebutton3.ForeColor = System.Drawing.Color.Red;
            this.closebutton3.Location = new System.Drawing.Point(998, -1);
            this.closebutton3.Name = "closebutton3";
            this.closebutton3.Size = new System.Drawing.Size(55, 35);
            this.closebutton3.TabIndex = 13;
            this.closebutton3.Text = "X";
            this.closebutton3.UseVisualStyleBackColor = false;
            this.closebutton3.Click += new System.EventHandler(this.closebutton3_Click);
            // 
            // collapsebutton3
            // 
            this.collapsebutton3.BackColor = System.Drawing.Color.DarkGray;
            this.collapsebutton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.collapsebutton3.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.collapsebutton3.ForeColor = System.Drawing.Color.Red;
            this.collapsebutton3.Location = new System.Drawing.Point(937, -1);
            this.collapsebutton3.Name = "collapsebutton3";
            this.collapsebutton3.Size = new System.Drawing.Size(55, 35);
            this.collapsebutton3.TabIndex = 14;
            this.collapsebutton3.Text = "__";
            this.collapsebutton3.UseVisualStyleBackColor = false;
            this.collapsebutton3.Click += new System.EventHandler(this.collapsebutton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(546, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 118);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DailyListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1052, 583);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.collapsebutton3);
            this.Controls.Add(this.closebutton3);
            this.Controls.Add(this.highlightbutton2);
            this.Controls.Add(this.removebut1);
            this.Controls.Add(this.menubut2);
            this.Controls.Add(this.addDailyTaskButton);
            this.Controls.Add(this.NearFutureLabel);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.NearFUTUREaddTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DailyListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Manager";
            this.Load += new System.EventHandler(this.DailyListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NearFUTUREaddTextbox;
        private CheckedListBox checkedListBox1;
        private Label NearFutureLabel;
        private Button addDailyTaskButton;
        private Button menubut2;
        private Button removebut1;
        private Button highlightbutton2;
        private Button closebutton3;
        private Button collapsebutton3;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}