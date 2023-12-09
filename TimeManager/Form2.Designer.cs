namespace TimeManager
{
    partial class DailyGlobalListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyGlobalListForm));
            this.DailyListButton = new System.Windows.Forms.Button();
            this.GloblalListButton = new System.Windows.Forms.Button();
            this.menuBut1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.closebutton4 = new System.Windows.Forms.Button();
            this.collapsebutton4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DailyListButton
            // 
            this.DailyListButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DailyListButton.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DailyListButton.ForeColor = System.Drawing.Color.Violet;
            this.DailyListButton.Image = ((System.Drawing.Image)(resources.GetObject("DailyListButton.Image")));
            this.DailyListButton.Location = new System.Drawing.Point(-9, 0);
            this.DailyListButton.Name = "DailyListButton";
            this.DailyListButton.Size = new System.Drawing.Size(541, 551);
            this.DailyListButton.TabIndex = 0;
            this.DailyListButton.Text = "Daily List";
            this.DailyListButton.UseVisualStyleBackColor = false;
            this.DailyListButton.Click += new System.EventHandler(this.DailyListButton_Click);
            // 
            // GloblalListButton
            // 
            this.GloblalListButton.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GloblalListButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.GloblalListButton.Image = ((System.Drawing.Image)(resources.GetObject("GloblalListButton.Image")));
            this.GloblalListButton.Location = new System.Drawing.Point(498, 0);
            this.GloblalListButton.Name = "GloblalListButton";
            this.GloblalListButton.Size = new System.Drawing.Size(571, 551);
            this.GloblalListButton.TabIndex = 1;
            this.GloblalListButton.Text = "Global List";
            this.GloblalListButton.UseVisualStyleBackColor = true;
            this.GloblalListButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuBut1
            // 
            this.menuBut1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuBut1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuBut1.ForeColor = System.Drawing.Color.Red;
            this.menuBut1.Location = new System.Drawing.Point(0, 542);
            this.menuBut1.Name = "menuBut1";
            this.menuBut1.Size = new System.Drawing.Size(1069, 46);
            this.menuBut1.TabIndex = 3;
            this.menuBut1.Text = "Menu";
            this.menuBut1.UseVisualStyleBackColor = false;
            this.menuBut1.Click += new System.EventHandler(this.menuBut1_Click);
            // 
            // closebutton4
            // 
            this.closebutton4.BackColor = System.Drawing.Color.Black;
            this.closebutton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closebutton4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closebutton4.ForeColor = System.Drawing.Color.Red;
            this.closebutton4.Location = new System.Drawing.Point(998, 0);
            this.closebutton4.Name = "closebutton4";
            this.closebutton4.Size = new System.Drawing.Size(55, 35);
            this.closebutton4.TabIndex = 13;
            this.closebutton4.Text = "X";
            this.closebutton4.UseVisualStyleBackColor = false;
            this.closebutton4.Click += new System.EventHandler(this.closebutton4_Click);
            // 
            // collapsebutton4
            // 
            this.collapsebutton4.BackColor = System.Drawing.Color.Black;
            this.collapsebutton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.collapsebutton4.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.collapsebutton4.ForeColor = System.Drawing.Color.Red;
            this.collapsebutton4.Location = new System.Drawing.Point(937, 0);
            this.collapsebutton4.Name = "collapsebutton4";
            this.collapsebutton4.Size = new System.Drawing.Size(55, 35);
            this.collapsebutton4.TabIndex = 14;
            this.collapsebutton4.Text = "__";
            this.collapsebutton4.UseVisualStyleBackColor = false;
            this.collapsebutton4.Click += new System.EventHandler(this.collapsebutton4_Click);
            // 
            // DailyGlobalListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 583);
            this.Controls.Add(this.collapsebutton4);
            this.Controls.Add(this.closebutton4);
            this.Controls.Add(this.menuBut1);
            this.Controls.Add(this.GloblalListButton);
            this.Controls.Add(this.DailyListButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DailyGlobalListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Manager";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button DailyListButton;
        private Button GloblalListButton;
        private Button menuBut1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button closebutton4;
        private Button collapsebutton4;
    }
}