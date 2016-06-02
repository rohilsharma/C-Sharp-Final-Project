using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnlineQuiz
{
    public partial class splashScreen : Form
    {
        Form F;
        public splashScreen()
        {
            InitializeComponent();
            timerSplashScreen.Start();
        }

        private void timerSplashScreen_Tick(object sender, EventArgs e)
        {
            pbSplashScreen.Value = pbSplashScreen.Value + 10;
            if (pbSplashScreen.Value == pbSplashScreen.Maximum)
            {
                timerSplashScreen.Stop();
                F = new frmLogin();
                F.Show();
                this.Hide();
            }
        }
    }
}
