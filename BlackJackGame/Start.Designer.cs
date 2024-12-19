namespace BlackJackGame
{
    partial class Start
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
            this.StartBtn = new System.Windows.Forms.Button();
            this.WelcomeMessLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(222, 416);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start!";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // WelcomeMessLbl
            // 
            this.WelcomeMessLbl.AutoSize = true;
            this.WelcomeMessLbl.BackColor = System.Drawing.Color.Black;
            this.WelcomeMessLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.WelcomeMessLbl.ForeColor = System.Drawing.Color.Silver;
            this.WelcomeMessLbl.Location = new System.Drawing.Point(0, 0);
            this.WelcomeMessLbl.Name = "WelcomeMessLbl";
            this.WelcomeMessLbl.Size = new System.Drawing.Size(349, 68);
            this.WelcomeMessLbl.TabIndex = 1;
            this.WelcomeMessLbl.Text = "Welcome to BlackJack!\r\nThe aim of the game is to score more than the Dealer.\r\nIf " +
                "you get 21 you\'ll have a BlackJack!\r\nDon\'t get more than 21 and you\'ll be good.\r" +
                "\n";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJackGame.Properties.Resources.Casino_by_mortalitas1;
            this.ClientSize = new System.Drawing.Size(512, 481);
            this.Controls.Add(this.WelcomeMessLbl);
            this.Controls.Add(this.StartBtn);
            this.Name = "Start";
            this.Text = "BlackJack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label WelcomeMessLbl;

    }
}