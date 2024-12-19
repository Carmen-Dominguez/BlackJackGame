using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlackJackGame
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            BlackJack start = new BlackJack();
            start.Show();
            start.Hand();
        }
    }
}
