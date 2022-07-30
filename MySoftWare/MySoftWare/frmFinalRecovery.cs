using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySoftWare
{
    public partial class frmFinalRecovery : Form
    {
        public frmFinalRecovery()
        {
            InitializeComponent();
            pnl_ShowFinalPass.Hide();
        }

        #region Local Value. . .

        bool MoveFinalPage;

        frmStart start;

        Point pointer;

        #endregion

        #region Move Page. . .
        private void pnl_Move_Final_RecoveryPage_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFinalPage = true;
            pointer = new Point(e.X, e.Y);
        }
        private void pnl_Move_Final_RecoveryPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveFinalPage)
            {
                Point Screen = PointToScreen(e.Location);
                this.Location = new Point(Screen.X - pointer.X, Screen.Y - pointer.Y);
            }
        }
        private void pnl_Move_Final_RecoveryPage_MouseUp(object sender, MouseEventArgs e)
        {
            MoveFinalPage &= false;
        }




        #endregion

        #region Recovery
        private void btn_Final_Send_Click(object sender, EventArgs e)
        {
            if (frmRecoveryAccount.DataCode == txt_Final_Recovery_Code.Text)
            {
                pnl_ShowFinalPass.Show();
                pnl_FinalCode.Hide();
                lbl_Final_ShowPassword.Text = frmRecoveryAccount.Pass;
                start.Show();
                this.Close();
            }
        }
        #endregion

        #region Exit. . .
        private void btn_Final_Recovery_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion


    }
}
