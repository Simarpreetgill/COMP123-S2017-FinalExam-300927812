﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name:Simarpreet Kaur
 * Date: August 17,2017
 * StudentID: 300927812
 * Description: Program class modified
 * Version: 0.1
 */

namespace COMP123_S2017_FinalExam_300927812
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PickHighestCardForm());

            Application.Run(new SplashForm());
        }
    
    }
}
