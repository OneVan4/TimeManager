namespace TimeManager
{
    partial class startForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startForm));
            this.ToDoListButton = new System.Windows.Forms.Button();
            this.TimeManagmentButton = new System.Windows.Forms.Button();
            this.closebutton2 = new System.Windows.Forms.Button();
            this.collapsebutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToDoListButton
            // 
            this.ToDoListButton.BackColor = System.Drawing.Color.SpringGreen;
            this.ToDoListButton.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ToDoListButton.ForeColor = System.Drawing.Color.Black;
            this.ToDoListButton.Location = new System.Drawing.Point(0, -2);
            this.ToDoListButton.Name = "ToDoListButton";
            this.ToDoListButton.Size = new System.Drawing.Size(538, 585);
            this.ToDoListButton.TabIndex = 0;
            this.ToDoListButton.Text = "To Do ";
            this.ToDoListButton.UseVisualStyleBackColor = false;
            this.ToDoListButton.Click += new System.EventHandler(this.ToDoListButton_Click);
            // 
            // TimeManagmentButton
            // 
            this.TimeManagmentButton.BackColor = System.Drawing.Color.Black;
            this.TimeManagmentButton.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeManagmentButton.ForeColor = System.Drawing.Color.Red;
            this.TimeManagmentButton.Location = new System.Drawing.Point(532, -2);
            this.TimeManagmentButton.Name = "TimeManagmentButton";
            this.TimeManagmentButton.Size = new System.Drawing.Size(518, 585);
            this.TimeManagmentButton.TabIndex = 2;
            this.TimeManagmentButton.Text = "Time Managment";
            this.TimeManagmentButton.UseVisualStyleBackColor = false;
            this.TimeManagmentButton.Click += new System.EventHandler(this.TimeManagmentButton_Click);
            // 
            // closebutton2
            // 
            this.closebutton2.BackColor = System.Drawing.Color.DarkGray;
            this.closebutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closebutton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closebutton2.ForeColor = System.Drawing.Color.Red;
            this.closebutton2.Location = new System.Drawing.Point(995, -2);
            this.closebutton2.Name = "closebutton2";
            this.closebutton2.Size = new System.Drawing.Size(55, 35);
            this.closebutton2.TabIndex = 12;
            this.closebutton2.Text = "X";
            this.closebutton2.UseVisualStyleBackColor = false;
            this.closebutton2.Click += new System.EventHandler(this.closebutton2_Click);
            // 
            // collapsebutton1
            // 
            this.collapsebutton1.BackColor = System.Drawing.Color.DarkGray;
            this.collapsebutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.collapsebutton1.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.collapsebutton1.ForeColor = System.Drawing.Color.Red;
            this.collapsebutton1.Location = new System.Drawing.Point(934, -2);
            this.collapsebutton1.Name = "collapsebutton1";
            this.collapsebutton1.Size = new System.Drawing.Size(55, 35);
            this.collapsebutton1.TabIndex = 13;
            this.collapsebutton1.Text = "__";
            this.collapsebutton1.UseVisualStyleBackColor = false;
            this.collapsebutton1.Click += new System.EventHandler(this.collapsebutton1_Click);
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1048, 579);
            this.Controls.Add(this.collapsebutton1);
            this.Controls.Add(this.closebutton2);
            this.Controls.Add(this.TimeManagmentButton);
            this.Controls.Add(this.ToDoListButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "startForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Manager";
            this.Load += new System.EventHandler(this.publForm1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button ToDoListButton;
        private Button TimeManagmentButton;
        private Button closebutton2;
        private Button collapsebutton1;
    }
}