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
    public partial class frmMakeAccount : Form
    {
        ISaleItem item;
        public frmMakeAccount()
        {
            InitializeComponent();  
            item = new SaleItem();
        }

        #region Local Value. . . 

        bool MoveMakeAcPage;
        
        Point MakeAcPointer;
        
        frmStart start;
        
        frmFinalAccountResult result;
        
        SaveData save;
        
        public static string PersonName;

        public static string PersonSourceId;

        #endregion

        #region Move Panel. . . 
        private void pnl_Move_MakeAcPage_MouseDown(object sender, MouseEventArgs e)
        {
            MoveMakeAcPage = true;
            MakeAcPointer = new Point(e.X,e.Y);
        }

        private void pnl_Move_MakeAcPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveMakeAcPage)
            {
                Point screen = PointToScreen(e.Location);
                this.Location = new Point(screen.X - MakeAcPointer.X, screen.Y - MakeAcPointer.Y);
            }
        }

        private void pnl_Move_MakeAcPage_MouseUp(object sender, MouseEventArgs e)
        {
            MoveMakeAcPage = false;
        }



        #endregion
        
        #region Back to Start Page. . .
        private void btn_Back_Click(object sender, EventArgs e)
        {
            start = new frmStart();
            start.Show();
            this.Close();
        }

        #endregion
        
        #region Exit. . .
        private void btn_MakeAc_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Check Text Box. . .
        bool CheckTextBox()
        {
            if (txt_New_Name.Text.Length > 12)      
            {
                MessageBox.Show("Name characters is so long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_New_Family.Text.Length > 16)   
            {
                MessageBox.Show("Family characters is so long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_New_Username.Text.Length > 9)  
            {
                MessageBox.Show("Username characters is so long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_New_Password.Text.Length > 12)
            {
                MessageBox.Show("Password characters is so long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_New_RPassword.Text.Length > 12)
            {
                MessageBox.Show("Passwords Repeat characters is so long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_New_PhoneNumber.Text.Length > 12)
            {
                MessageBox.Show("Phone Number characters is so long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_New_Gmail.Text.Length > 30)
            {
                MessageBox.Show("Gmail characters is so long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_New_Region.Text.Length > 15)
            {
                MessageBox.Show("Region characters is so long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //------------------------------------------------------------------------------------------------------------------------------------------
            if (txt_New_Name.Text == "")
            {
                MessageBox.Show("Name cann't be Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_New_Family.Text == "")
            {
                MessageBox.Show("Family cann't be Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_New_Username.Text == "")
            {
                MessageBox.Show("Username cann't be Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_New_Password.Text == "")
            {
                MessageBox.Show("Password cann't be Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_New_RPassword.Text == "") 
            {
                MessageBox.Show("Password Repeat cann't be Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_New_Region.Text == "")
            {
                MessageBox.Show("Region cann't be Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!(txt_New_Password.Text.Contains(txt_New_RPassword.Text)))
            {
                MessageBox.Show("Please Make Sure Your Passwords Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        #endregion

        #region Next Button. . .
        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (CheckTextBox())
            {
                save = new SaveData();
                save.User = txt_New_Name.Text;
                PersonSourceId = save.OnGetSavePerson();

                bool isSuccess = item.InsertNewData(txt_New_Name.Text, txt_New_Family.Text, txt_New_Username.Text, txt_New_Password.Text, txt_New_PhoneNumber.Text, txt_New_Gmail.Text, txt_New_Region.Text, PersonSourceId);
                if (!isSuccess)
                    MessageBox.Show("Something Went Wrong!\nData Not Implement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = new frmFinalAccountResult();
                PersonName = txt_New_Name.Text;
                result.Show();
                this.Close();
            }
        }


        #endregion

        #region Chenge Text Button. . .
        private void txt_New_Name_Click(object sender, EventArgs e)
        {
            txt_New_Name.PlaceholderText = "";
        }
        private void txt_New_Family_Click(object sender, EventArgs e)
        {
            txt_New_Family.PlaceholderText = "";
        }
        private void txt_New_Username_Click(object sender, EventArgs e)
        {
            txt_New_Username.PlaceholderText = "";
        }
        private void txt_New_Password_Click(object sender, EventArgs e)
        {
            txt_New_Password.PlaceholderText = "";

        }
        private void txt_New_PhoneNumber_Click(object sender, EventArgs e)
        {
            txt_New_PhoneNumber.PlaceholderText = "";
        }
        private void txt_New_RPassword_Click(object sender, EventArgs e)
        {
            txt_New_RPassword.PlaceholderText = "";
        }
        private void txt_New_Gmail_Click(object sender, EventArgs e)
        {
            txt_New_Gmail.PlaceholderText = "";
        }
        private void txt_New_Region_Click(object sender, EventArgs e)
        {
            txt_New_Region.PlaceholderText = "";
        }
        private void txt_New_Name_Leave(object sender, EventArgs e)
        {
            if (txt_New_Name.Text == "")
                txt_New_Name.PlaceholderText = "Name";
        }
        private void txt_New_Family_Leave(object sender, EventArgs e)
        {
            if (txt_New_Family.Text == "")
                txt_New_Family.PlaceholderText = "Family";
        }
        private void txt_New_Username_Leave(object sender, EventArgs e)
        {
            if (txt_New_Username.Text == "")
                txt_New_Username.PlaceholderText = "Username";
        }
        private void txt_New_Password_Leave(object sender, EventArgs e)
        {
            if (txt_New_Password.Text == "")
                txt_New_Password.PlaceholderText = "Password";
        }
        private void txt_New_PhoneNumber_Leave(object sender, EventArgs e)
        {
            if (txt_New_PhoneNumber.Text == "")
                txt_New_PhoneNumber.PlaceholderText = "Phone";
        }
        private void txt_New_RPassword_Leave(object sender, EventArgs e)
        {
            if (txt_New_RPassword.Text == "")
                txt_New_RPassword.PlaceholderText = "Repeat Password";
        }
        private void txt_New_Gmail_Leave(object sender, EventArgs e)
        {
            if (txt_New_Gmail.Text == "")
                txt_New_Gmail.PlaceholderText = "Gmail";
        }
        private void txt_New_Region_Leave(object sender, EventArgs e)
        {
            if (txt_New_Region.Text == "")
                txt_New_Region.PlaceholderText = "Region";
        }
        #endregion
    }
}
