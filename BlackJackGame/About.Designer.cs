namespace BlackJackGame
{
    partial class About
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
            this.aboutText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aboutText
            // 
            this.aboutText.AutoSize = true;
            this.aboutText.BackColor = System.Drawing.Color.Black;
            this.aboutText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.aboutText.Location = new System.Drawing.Point(10, 37);
            this.aboutText.Name = "aboutText";
            this.aboutText.Size = new System.Drawing.Size(271, 91);
            this.aboutText.TabIndex = 0;
            this.aboutText.Text = "About:\r\n\r\nBlackJack Game version 1.0\r\n\r\nWritten by Carmen Dominguez for Unit 3 C#" +
                " completion.\r\n\r\nCreated using Microsoft Visual C# 2008 Express Edition.\r\n";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJackGame.Properties.Resources.Casino_by_mortalitas;
            this.ClientSize = new System.Drawing.Size(478, 221);
            this.Controls.Add(this.aboutText);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aboutText;
    }
}