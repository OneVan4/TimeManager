namespace TimeManager
{
    partial class StatsForm10
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
            this.Collapsebutton10 = new System.Windows.Forms.Button();
            this.ExitButton10 = new System.Windows.Forms.Button();
            this.Menubutton10 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Collapsebutton10
            // 
            this.Collapsebutton10.BackColor = System.Drawing.Color.DarkGray;
            this.Collapsebutton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Collapsebutton10.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Collapsebutton10.ForeColor = System.Drawing.Color.Red;
            this.Collapsebutton10.Location = new System.Drawing.Point(945, 2);
            this.Collapsebutton10.Name = "Collapsebutton10";
            this.Collapsebutton10.Size = new System.Drawing.Size(54, 35);
            this.Collapsebutton10.TabIndex = 46;
            this.Collapsebutton10.Text = "__";
            this.Collapsebutton10.UseVisualStyleBackColor = false;
            this.Collapsebutton10.Click += new System.EventHandler(this.Collapsebutton10_Click);
            // 
            // ExitButton10
            // 
            this.ExitButton10.BackColor = System.Drawing.Color.DarkGray;
            this.ExitButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitButton10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton10.ForeColor = System.Drawing.Color.Red;
            this.ExitButton10.Location = new System.Drawing.Point(1015, 0);
            this.ExitButton10.Name = "ExitButton10";
            this.ExitButton10.Size = new System.Drawing.Size(54, 35);
            this.ExitButton10.TabIndex = 45;
            this.ExitButton10.Text = "X";
            this.ExitButton10.UseVisualStyleBackColor = false;
            this.ExitButton10.Click += new System.EventHandler(this.ExitButton10_Click);
            // 
            // Menubutton10
            // 
            this.Menubutton10.BackColor = System.Drawing.SystemColors.Desktop;
            this.Menubutton10.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Menubutton10.ForeColor = System.Drawing.Color.Red;
            this.Menubutton10.Location = new System.Drawing.Point(860, 584);
            this.Menubutton10.Name = "Menubutton10";
            this.Menubutton10.Size = new System.Drawing.Size(209, 48);
            this.Menubutton10.TabIndex = 47;
            this.Menubutton10.Text = "Menu";
            this.Menubutton10.UseVisualStyleBackColor = false;
            this.Menubutton10.Click += new System.EventHandler(this.Menubutton10_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(135, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(753, 404);
            this.listBox1.TabIndex = 48;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // StatsForm10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 630);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Menubutton10);
            this.Controls.Add(this.Collapsebutton10);
            this.Controls.Add(this.ExitButton10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatsForm10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form10";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Collapsebutton10;
        private Button ExitButton10;
        private Button Menubutton10;
        private ListBox listBox1;
    }
}