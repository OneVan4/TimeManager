namespace TimeManager
{
    partial class GlobalListForm
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
            this.addGlobalTaskButton = new System.Windows.Forms.Button();
            this.GlobalTODOLabel = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.GlobalToDOaddTextbox = new System.Windows.Forms.TextBox();
            this.menubut3 = new System.Windows.Forms.Button();
            this.removebut2 = new System.Windows.Forms.Button();
            this.highlightbutton1 = new System.Windows.Forms.Button();
            this.closebutton2 = new System.Windows.Forms.Button();
            this.collapseBut2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addGlobalTaskButton
            // 
            this.addGlobalTaskButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.addGlobalTaskButton.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addGlobalTaskButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addGlobalTaskButton.Location = new System.Drawing.Point(561, 524);
            this.addGlobalTaskButton.Name = "addGlobalTaskButton";
            this.addGlobalTaskButton.Size = new System.Drawing.Size(209, 48);
            this.addGlobalTaskButton.TabIndex = 7;
            this.addGlobalTaskButton.Text = "Add Task";
            this.addGlobalTaskButton.UseVisualStyleBackColor = false;
            this.addGlobalTaskButton.Click += new System.EventHandler(this.addGlobalTaskButton_Click);
            // 
            // GlobalTODOLabel
            // 
            this.GlobalTODOLabel.AutoSize = true;
            this.GlobalTODOLabel.BackColor = System.Drawing.Color.Transparent;
            this.GlobalTODOLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GlobalTODOLabel.ForeColor = System.Drawing.Color.Red;
            this.GlobalTODOLabel.Location = new System.Drawing.Point(325, 9);
            this.GlobalTODOLabel.Name = "GlobalTODOLabel";
            this.GlobalTODOLabel.Size = new System.Drawing.Size(362, 47);
            this.GlobalTODOLabel.TabIndex = 6;
            this.GlobalTODOLabel.Text = "Global TO-DO List";
            this.GlobalTODOLabel.Click += new System.EventHandler(this.GlobalTODOLabel_Click);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.SystemColors.Info;
            this.checkedListBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(29, 79);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(994, 439);
            this.checkedListBox2.TabIndex = 5;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // GlobalToDOaddTextbox
            // 
            this.GlobalToDOaddTextbox.BackColor = System.Drawing.SystemColors.Info;
            this.GlobalToDOaddTextbox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GlobalToDOaddTextbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GlobalToDOaddTextbox.Location = new System.Drawing.Point(29, 528);
            this.GlobalToDOaddTextbox.Name = "GlobalToDOaddTextbox";
            this.GlobalToDOaddTextbox.Size = new System.Drawing.Size(495, 34);
            this.GlobalToDOaddTextbox.TabIndex = 4;
            this.GlobalToDOaddTextbox.TextChanged += new System.EventHandler(this.GlobalToDOaddTextbox_TextChanged);
            // 
            // menubut3
            // 
            this.menubut3.BackColor = System.Drawing.SystemColors.Desktop;
            this.menubut3.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menubut3.ForeColor = System.Drawing.Color.Red;
            this.menubut3.Location = new System.Drawing.Point(814, 524);
            this.menubut3.Name = "menubut3";
            this.menubut3.Size = new System.Drawing.Size(209, 48);
            this.menubut3.TabIndex = 8;
            this.menubut3.Text = "Menu";
            this.menubut3.UseVisualStyleBackColor = false;
            this.menubut3.Click += new System.EventHandler(this.menubut2_Click);
            // 
            // removebut2
            // 
            this.removebut2.BackColor = System.Drawing.Color.Red;
            this.removebut2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removebut2.ForeColor = System.Drawing.Color.Black;
            this.removebut2.Location = new System.Drawing.Point(848, 452);
            this.removebut2.Name = "removebut2";
            this.removebut2.Size = new System.Drawing.Size(175, 66);
            this.removebut2.TabIndex = 9;
            this.removebut2.Text = "Remove";
            this.removebut2.UseVisualStyleBackColor = false;
            this.removebut2.Click += new System.EventHandler(this.removebut2_Click);
            // 
            // highlightbutton1
            // 
            this.highlightbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.highlightbutton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.highlightbutton1.Location = new System.Drawing.Point(848, 381);
            this.highlightbutton1.Name = "highlightbutton1";
            this.highlightbutton1.Size = new System.Drawing.Size(175, 65);
            this.highlightbutton1.TabIndex = 10;
            this.highlightbutton1.Text = "Hghlight";
            this.highlightbutton1.UseVisualStyleBackColor = false;
            this.highlightbutton1.Click += new System.EventHandler(this.highlightbutton1_Click);
            // 
            // closebutton2
            // 
            this.closebutton2.BackColor = System.Drawing.Color.DarkGray;
            this.closebutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closebutton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closebutton2.ForeColor = System.Drawing.Color.Red;
            this.closebutton2.Location = new System.Drawing.Point(997, 0);
            this.closebutton2.Name = "closebutton2";
            this.closebutton2.Size = new System.Drawing.Size(55, 35);
            this.closebutton2.TabIndex = 11;
            this.closebutton2.Text = "X";
            this.closebutton2.UseVisualStyleBackColor = false;
            this.closebutton2.Click += new System.EventHandler(this.closebutton2_Click);
            // 
            // collapseBut2
            // 
            this.collapseBut2.BackColor = System.Drawing.Color.DarkGray;
            this.collapseBut2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.collapseBut2.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.collapseBut2.ForeColor = System.Drawing.Color.Red;
            this.collapseBut2.Location = new System.Drawing.Point(936, 0);
            this.collapseBut2.Name = "collapseBut2";
            this.collapseBut2.Size = new System.Drawing.Size(55, 35);
            this.collapseBut2.TabIndex = 12;
            this.collapseBut2.Text = "__";
            this.collapseBut2.UseVisualStyleBackColor = false;
            this.collapseBut2.Click += new System.EventHandler(this.collapseBut2_Click);
            // 
            // GlobalListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1052, 583);
            this.Controls.Add(this.collapseBut2);
            this.Controls.Add(this.closebutton2);
            this.Controls.Add(this.highlightbutton1);
            this.Controls.Add(this.removebut2);
            this.Controls.Add(this.menubut3);
            this.Controls.Add(this.addGlobalTaskButton);
            this.Controls.Add(this.GlobalTODOLabel);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.GlobalToDOaddTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GlobalListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Manager";
            this.Load += new System.EventHandler(this.GlobalListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addGlobalTaskButton;
        private Label GlobalTODOLabel;
        private CheckedListBox checkedListBox2;
        private TextBox GlobalToDOaddTextbox;
        private Button menubut3;
        private Button removebut2;
        private Button highlightbutton1;
        private Button closebutton2;
        private Button collapseBut2;
    }
}