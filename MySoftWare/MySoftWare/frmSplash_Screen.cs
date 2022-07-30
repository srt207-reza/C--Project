using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MySoftWare
{
    public partial class frmSplash_Screen : Form
    {
        public frmSplash_Screen()
        {
            InitializeComponent();
            Splash_Screen_ProgressBar.Value = 0;
        }

        #region Local Values. . .

        MainForm main;

        bool MoveSplashScreen;

        Point pointer;

        #endregion

        #region Timer. . . 
        private void Splash_Screen_Timer_Tick(object sender, EventArgs e)
        {
            Splash_Screen_Timer.Enabled = true;
            Splash_Screen_ProgressBar.Text = Splash_Screen_ProgressBar.Value.ToString() + "%";
            Splash_Screen_ProgressBar.Increment(7);
            //Splash_Screen_ProgressBar.Value += 2;
            Thread.Sleep(300);
            lbl_Loading.Text += " ." ;
            if (lbl_Loading.Text.Length == 13)
                lbl_Loading.Text = lbl_Loading.Text.Remove(7);
            
            if (Splash_Screen_ProgressBar.Value == 100)
            {
                Splash_Screen_Timer.Enabled = false;
                main = new MainForm();
                main.Show();
                this.Close();
            }
        }

        #endregion

        #region Move Panle. . .
        private void pnl_Move_SplashScreen_MouseDown(object sender, MouseEventArgs e)
        {
            MoveSplashScreen = true;
            pointer = new Point(e.X, e.Y);
        }
        private void pnl_Move_SplashScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveSplashScreen)
            {
                Point screen = PointToScreen(e.Location);
                this.Location = new Point(screen.X - pointer.X, screen.Y - pointer.Y);
            }
        }
        private void pnl_Move_SplashScreen_MouseUp(object sender, MouseEventArgs e)
        {
            MoveSplashScreen = false;
        }


        #endregion

        #region Exit. . . 
        private void btn_Splash_Screen_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

    }
}
