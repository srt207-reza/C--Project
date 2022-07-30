using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MySoftWare;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySoftWare
{
    public partial class frmStart : Form
    { 
        public frmStart()
        {
            InitializeComponent();
        }

        #region Local Value. . .

        bool MoveStartPage;
        
        Point pointer;
                
        frmSplash_Screen splashS;

        frmRecoveryAccount frmRecovery;
        
        frmMakeAccount frmMake;

        public static string RecentUser;
        
        #endregion

        #region Exit. . .
        private void btn_Start_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #endregion

        #region UserName. . .
        private void txt_UserName_Click(object sender, EventArgs e)
        {
            txt_UserName.PlaceholderText = "";
        }
        private void txt_UserName_Leave(object sender, EventArgs e)
        {
            txt_UserName.PlaceholderText = "Please enter username";
        }

        #endregion

        #region Password. . . 
        private void txt_Password_Click(object sender, EventArgs e)
        {
            txt_Password.PlaceholderText = "";
            
        }
        private void txt_Password_Leave(object sender, EventArgs e)
        {
            txt_Password.PlaceholderText = "Please enter your password";
        }

        #endregion

        #region Move Page. . .
        private void pnl_Move_StartPage_MouseDown(object sender, MouseEventArgs e)
        {
            MoveStartPage = true;
            pointer = new Point(e.X, e.Y);
        }
        private void pnl_Move_StartPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveStartPage)
            {
                Point screen = PointToScreen(e.Location);
                this.Location = new Point(screen.X - pointer.X, screen.Y - pointer.Y);
            }
        }
        private void pnl_Move_StartPage_MouseUp(object sender, MouseEventArgs e)
        {
            MoveStartPage = false;
        }

        #endregion

        #region Check Log. . .
        public bool OnCheck()
        {
            if (txt_UserName.Text == "")
            {
                MessageBox.Show("Please enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txt_Password.Text == "")
            {
                MessageBox.Show("Please enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txt_UserName.Text.Length <= 2)
            {
                MessageBox.Show("UserName must be longer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txt_Password.Text.Length <= 4)
            {
                MessageBox.Show("Password must be longer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        #endregion

        #region Login. . . 
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (OnCheck())
            {
                using (DB_SalePersonEntities db = new DB_SalePersonEntities())
                {
                    var GetDB = db.Tbl_PeopleData.Select(p => new { p.UserName, p.Password ,p.Name }).ToList();
                    bool isSucces = GetDB.Any(p => p.UserName.Contains(txt_UserName.Text) && p.Password.Contains(txt_Password.Text));
                    if (isSucces && Start_CheckBox.Checked)
                    {
                        splashS = new frmSplash_Screen();
                        splashS.Show();
                        this.Hide();
                    }
                    else if (isSucces)
                    {
                        splashS = new frmSplash_Screen();
                        splashS.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Something Went Wrong!\n   Please Try again. . .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion
        
        #region Make New Account. . . 
        private void lbl_Make_New_Ac_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMake = new frmMakeAccount();
            frmMake.Show();
            this.Hide();
        }


        #endregion

        #region Forgot Password. . .
        private void lbl_Forgot_Password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecovery = new frmRecoveryAccount();
            frmRecovery.Show();
            this.Hide();
        }
        #endregion

    }
}
