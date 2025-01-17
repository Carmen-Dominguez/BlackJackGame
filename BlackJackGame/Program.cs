﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BlackJackGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Start());
            }
            catch (System.IO.FileNotFoundException e)
            {
                MessageBox.Show("An unexpected error occured\nWe apologise for the inconvenience" + e);
                Application.Exit();
            }
        }
    }
}
