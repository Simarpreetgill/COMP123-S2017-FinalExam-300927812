﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_FinalExam_300927812
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            PickHighestCardForm pickHighestCardForm = new PickHighestCardForm();
            pickHighestCardForm.Show();
            this.Hide();

            SplashFormTimer.Enabled = false;


        }
    }
  
    

}
