﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    static class Program
    {
        [DllImport("User32.dll")]
        public static extern bool SetProcessDPIAware();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Set the DPI awareness for the application
            SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new frm_musicplayer());
            }
            catch (Exception e)
            {
                Clipboard.SetText(e.ToString());
                MessageBox.Show("Error : " + e.Message, "Error Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
