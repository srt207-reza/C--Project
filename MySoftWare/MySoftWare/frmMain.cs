using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MySoftWare
{
    public partial class MainForm : Form
    {
        ISaleItem item;
        //[DllImport("Gdi32.dll", EntryPoint = "MyRectangle")]

        //private static extern IntPtr MyRectangle
        //(
        //       int nLeftRect,
        //       int nTopRect,
        //       int nRightRect,
        //       int nBottomRect,
        //       int nWidthEllipse,
        //       int nHeightEllipse
        //);
        public MainForm()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(MyRectangle(0,0,Width,Height,25,25));
            item = new SaleItem();
            TempClick click = btn_DashBord_Click;
            click.Invoke(this, EventArgs.Empty);
            dgv_Product.AutoGenerateColumns = false;
            dgv_Product.DataSource = item.SelectAllProduct();
            dgv_Product.DefaultCellStyle.ForeColor = Color.Magenta;
        }

        #region Local Values. . .

        bool boolTempMovePage;

        bool isCheckBoxNotification;
        
        Point vector;
        
        public delegate void TempClick(object sender, EventArgs e);
        
        #endregion

        #region Start Panels. . .
        private void MainForm_Load(object sender, EventArgs e)
        {
            Label[] labels = { lbl_Dashbord_Items_Name1, lbl_Dashbord_Items_Name2, lbl_Dashbord_Items_Name3, lbl_Dashbord_Items_Name4, lbl_Dashbord_Items_Name5, lbl_Dashbord_Items_Name6 };
            Random random = new Random();
            int temp;
            DataTable dt = item.SelectAllItem();
            for (int i = 0; i < 6; i++)
            {
                temp = random.Next(0, 27);
                labels[i].Text = dt.Rows[temp][0].ToString();
            }
            Setting_CheckBox_Dark.Checked = true;
            Setting_CheckBox_En.Checked = true;
            Setting_CheckBox_Feedback.Checked = true;
            Setting_CheckBox_Support.Checked = true;
            Setting_CheckBox_Reminder.Checked = true;
        }

        #endregion

        #region Application Exit. . .
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.BackColor = Color.FromArgb(232, 17, 35);
        }
        private void btn_Exit_MouseMove(object sender, MouseEventArgs e)
        {
            Exit.BackColor = Color.FromArgb(232, 17, 35);
            Thread.Sleep(40);
        }
        private void btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.BackColor = Color.FromArgb(24, 30, 50);
        }


        #endregion

        #region Application Minimize. . . 
        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            Minimize.BackColor = Color.FromArgb(61, 61, 61);
        }
        private void Minimize_MouseMove(object sender, MouseEventArgs e)
        {
            Minimize.BackColor = Color.FromArgb(61, 61, 61);
            Thread.Sleep(40); 
        }
        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.BackColor = Color.FromArgb(24, 30, 50);
        }



        #endregion

        #region Move Page. . .
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            boolTempMovePage = true;
            vector = new Point(e.X, e.Y);
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (boolTempMovePage)
            {
                Point screen = PointToScreen(e.Location);
                this.Location = new Point(screen.X - vector.X, screen.Y - vector.Y);
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            boolTempMovePage = false;
        }



        #endregion

        #region Change Panel. . .
        void ChangePanel(int pnlNumber)
        {
            Panel[] panels = { pnl_Dashbord, pnl_Profile,pnl_Product,pnl_Customers,pnl_Analytics,pnl_Report,pnl_Setting };

            for (int i = 0; i < panels.Length; i++)
                if (pnlNumber != i)
                    panels[i].Hide();
                else
                    panels[i].Show();
        }
        #endregion

        #region Panel Color. . .

        void ChangeColor(int tempChange)
        {
            Color[] InputColors = { Color.FromArgb(0, 132, 255), Color.Red, Color.Magenta, Color.Yellow, Color.HotPink, Color.Lime, Color.Orange };
            Button[] buttons = {btn_DashBord, btn_Profile, btn_Product, btn_Customers, btn_Analytics, btn_Report, btn_Setting};

            switch (tempChange)
            {
                case 0:
                    //Logo.ImageLocation = @"D:\Programming\Study\Icon\My Icon\SASS Logo\icons8-sass-500 (1)";
                    Logo.Image = Properties.Resources.Blue;
                    //ShortLogo.ImageLocation = @"D:\Programming\Study\Icon\My Icon\SASS Logo\icons8-sass-avatar-500";
                    ShortLogo.Image = Properties.Resources.ShortBlue;
                    lbl_UpgradePicture.LinkColor = InputColors[0];
                    lbl_Logo_Name.ForeColor = InputColors[0];
                    for (int i = 0; i < buttons.Length; i++)
                        buttons[i].ForeColor = InputColors[0];
                    btn_DashBord.Image = Properties.Resources.DashbordBlue;
                    btn_Profile.Image = Properties.Resources.ProfileBlue;
                    btn_Product.Image = Properties.Resources.ProductBlue;
                    btn_Customers.Image = Properties.Resources.CustomersBlue;
                    btn_Analytics.Image = Properties.Resources.AnalyticsBlue;
                    btn_Report.Image = Properties.Resources.ReportBlue;
                    btn_Setting.Image = Properties.Resources.SettingBlue;
                    break;
                case 1:
                    Logo.Image = Properties.Resources.Red;
                    ShortLogo.Image = Properties.Resources.ShortRed;
                    lbl_UpgradePicture.LinkColor = InputColors[1];
                    lbl_Logo_Name.ForeColor = InputColors[1];
                    for (int i = 0; i < buttons.Length; i++)
                        buttons[i].ForeColor = InputColors[1];
                    btn_DashBord.Image= Properties.Resources.DashbordRed;
                    btn_Profile.Image = Properties.Resources.ProfileRed;
                    btn_Product.Image = Properties.Resources.ProductRed;
                    btn_Customers.Image = Properties.Resources.CustomersRed;
                    btn_Analytics.Image = Properties.Resources.AnalyticsRed;
                    btn_Report.Image = Properties.Resources.ReportRed;
                    btn_Setting.Image = Properties.Resources.SettingRed;
                    break ;
                case 2:
                    Logo.Image = Properties.Resources.Purple;
                    ShortLogo.Image = Properties.Resources.ShortPurple;
                    lbl_UpgradePicture.LinkColor = InputColors[2];
                    lbl_Logo_Name.ForeColor = InputColors[2];
                    for (int i = 0; i < buttons.Length; i++)
                        buttons[i].ForeColor = InputColors[2];
                    btn_DashBord.Image = Properties.Resources.DashbordPurple;
                    btn_Profile.Image = Properties.Resources.ProfilePurple;
                    btn_Product.Image= Properties.Resources.ProductPurple;
                    btn_Customers.Image= Properties.Resources.CustomersPurple;
                    btn_Analytics.Image= Properties.Resources.AnalyticsPurple;
                    btn_Report.Image= Properties.Resources.ReportPurple;
                    btn_Setting.Image= Properties.Resources.SettingPurple;
                    break;
                case 3:
                    Logo.Image = Properties.Resources.Yellow;
                    ShortLogo.Image = Properties.Resources.ShortYellow;
                    lbl_UpgradePicture.LinkColor = InputColors[3];
                    lbl_Logo_Name.ForeColor = InputColors[3];
                    for (int i = 0; i < buttons.Length; i++)
                        buttons[i].ForeColor = InputColors[3];
                    btn_DashBord.Image = Properties.Resources.DashbordYellow;
                    btn_Profile.Image = Properties.Resources.ProfileYellow;
                    btn_Product.Image = Properties.Resources.ProductYellow;
                    btn_Customers.Image = Properties.Resources.CustomersYellow;
                    btn_Analytics.Image = Properties.Resources.AnalyticsYellow;
                    btn_Report.Image = Properties.Resources.ReportYellow;
                    btn_Setting.Image = Properties.Resources.SettingYellow;
                    break;
                case 4:
                    Logo.Image = Properties.Resources.Pink;
                    ShortLogo.Image = Properties.Resources.ShortPink;
                    lbl_UpgradePicture.LinkColor = InputColors[4];
                    lbl_Logo_Name.ForeColor = InputColors[4];
                    for (int i = 0; i < buttons.Length; i++)
                        buttons[i].ForeColor = InputColors[4];
                    btn_DashBord.Image = Properties.Resources.DashbordPink;
                    btn_Profile.Image = Properties.Resources.ProfilePink;
                    btn_Product.Image = Properties.Resources.ProductPink;
                    btn_Customers.Image = Properties.Resources.CustomersPink;
                    btn_Analytics.Image = Properties.Resources.AnalyticsPink;
                    btn_Report.Image = Properties.Resources.ReportPink;
                    btn_Setting.Image = Properties.Resources.SettingPink;
                    break;
                case 5:
                    Logo.Image = Properties.Resources.Green;
                    ShortLogo.Image = Properties.Resources.ShortGreen;
                    lbl_UpgradePicture.LinkColor = InputColors[5];
                    lbl_Logo_Name.ForeColor = InputColors[5];
                    for (int i = 0; i < buttons.Length; i++)
                        buttons[i].ForeColor = InputColors[5];
                    btn_DashBord.Image = Properties.Resources.DashbordGreen;
                    btn_Profile.Image = Properties.Resources.ProfileGreen;
                    btn_Product.Image = Properties.Resources.ProductGreen;
                    btn_Customers.Image = Properties.Resources.CustomersGreen;
                    btn_Analytics.Image = Properties.Resources.AnalyticsGreen;
                    btn_Report.Image = Properties.Resources.ReportGreen;
                    btn_Setting.Image = Properties.Resources.SettingGreen;
                    break;
                case 6:
                    Logo.Image = Properties.Resources.Orange;
                    ShortLogo.Image = Properties.Resources.ShortOrange;
                    lbl_UpgradePicture.LinkColor = InputColors[6];
                    lbl_Logo_Name.ForeColor = InputColors[6];
                    for (int i = 0; i < buttons.Length; i++)
                        buttons[i].ForeColor = InputColors[6];
                    btn_DashBord.Image = Properties.Resources.DashbordOrange;
                    btn_Profile.Image = Properties.Resources.ProfileOrange;
                    btn_Product.Image = Properties.Resources.ProductOrange;
                    btn_Customers.Image = Properties.Resources.CustomersOrange;
                    btn_Analytics.Image = Properties.Resources.AnalyticsOrange;
                    btn_Report.Image = Properties.Resources.ReportOrange;
                    btn_Setting.Image = Properties.Resources.SettingOrange;
                    break;
            }
        }

        #endregion

        #region Dashbord Panel. . . 
        public void NavgButton(int btnTemp)
        {
            Button[] buttons = { btn_DashBord, btn_Profile, btn_Product, btn_Customers, btn_Analytics, btn_Report, btn_Setting };
            for (int i = 0; i < 7; i++)
                if (i == btnTemp)
                {
                    navg.Height = buttons[i].Height;
                    navg.Top = buttons[i].Top;
                    navg.Left = buttons[i].Left;
                }

        }
        private void btn_DashBord_Click(object sender, EventArgs e)
        {
            ChangeColor(0);
            NavgButton(0);
            btn_DashBord.BackColor = Color.FromArgb(46, 51, 73);
            ChangePanel(0);
        }
        private void txt_Dashbord_Search_Click(object sender, EventArgs e)
        {
            Dashbord_txt_Search.Clear();
        }
        private void txt_Dashbord_Search_Leave(object sender, EventArgs e)
        {
            Dashbord_txt_Search.Text = "Search for mor infomation. . .";
        }
        private void btn_Dahbord_Search_Clean_Click(object sender, EventArgs e)
        {
            Dashbord_txt_Search.Text = null;
        }
        private void btn_Dahbord_Search_Clean_Leave(object sender, EventArgs e)
        {
            Dashbord_txt_Search.Text = "Search for mor infomation. . .";
        }
        private void btn_DashBord_Leave(object sender, EventArgs e)
        {
            btn_DashBord.BackColor = Color.FromArgb(24, 30, 54);
        }


        #endregion

        #region Profile Panel. . .
        private void btn_Profile_Click(object sender, EventArgs e)
        {
            ChangeColor(1);
            NavgButton(1);
            btn_Profile.BackColor = Color.FromArgb(46, 51, 73);
            ChangePanel(1);
        }
        private void btn_Profile_Leave(object sender, EventArgs e)
        {
            btn_Profile.BackColor = Color.FromArgb(24, 30, 54);
        }

        #endregion

        #region Product Panel. . .
        private void btn_Product_Click(object sender, EventArgs e)
        {
            ChangeColor(2);
            NavgButton(2);
            btn_Product.BackColor = Color.FromArgb(46, 51, 73);
            ChangePanel(2);
        }
        private void btn_Product_Leave(object sender, EventArgs e)
        {
            btn_Product.BackColor = Color.FromArgb(24, 30, 54);
        }

        #endregion

        #region Customers Panel. . .
        private void btn_Customers_Click(object sender, EventArgs e)
        {
            ChangeColor(3);
            NavgButton(3);
            btn_Customers.BackColor = Color.FromArgb(46, 51, 73);
            ChangePanel(3);
        }
        private void btn_Customers_Leave(object sender, EventArgs e)
        {
            btn_Customers.BackColor = Color.FromArgb(24, 30, 54);
        }

        #endregion

        #region Analytics Panel. . . 
        private void btn_Analytics_Click(object sender, EventArgs e)
        {
            ChangeColor(4);
            NavgButton(4);
            btn_Analytics.BackColor = Color.FromArgb(46, 51, 73);
            ChangePanel(4);
        }
        private void btn_Analytics_Leave(object sender, EventArgs e)
        {
            btn_Analytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        #endregion

        #region Report Panel. . . 
        private void btn_Report_Click(object sender, EventArgs e)
        {
            ChangeColor(5);
            NavgButton(5);
            btn_Report.BackColor = Color.FromArgb(46, 51, 73);
            ChangePanel(5);
        }
        private void btn_Report_Leave(object sender, EventArgs e)
        {
            btn_Report.BackColor = Color.FromArgb(24, 30, 54);
        }

        #endregion

        #region Setting Panel. . . 
        private void btn_Setting_Click(object sender, EventArgs e)
        {
            ChangeColor(6);
            NavgButton(6);
            btn_Setting.BackColor = Color.FromArgb(46, 51, 73);
            ChangePanel(6);
        }
        private void btn_Setting_Leave(object sender, EventArgs e)
        {
            btn_Setting.BackColor = Color.FromArgb(24, 30, 54);
        }

        #endregion

        #region Choose Profile Picture. . .
        private void lbl_UpgradePicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //OpenFileDialog openFile = new OpenFileDialog();
            //openFile.ShowDialog();
            OpenImageAs.ShowDialog();
            string filePath = OpenImageAs.FileName;
            DialogResult = DialogResult.OK;
            Logo.Image = Image.FromFile(filePath);
        }
        private void lbl_Profile_UpdatePicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenImageAs.ShowDialog();
            string filePath = OpenImageAs.FileName;
            Profile_Picture.Image = Image.FromFile(filePath);
        }


        #endregion

        #region Theme. . .
        private void Setting_CheckBox_Light_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (Setting_CheckBox_Light.Checked)
                ChangeThemes(0);
        }
        private void Setting_CheckBox_Dark_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (Setting_CheckBox_Dark.Checked)
                ChangeThemes(1);
        }
        #endregion

        #region Change Theme. . .
        void ChangeThemes(int tempChange)
        {
            Panel[] panels = {LeftPanel,TopPanel };
            Button[] buttons = {btn_DashBord,btn_Profile,btn_Product,btn_Customers,btn_Analytics,btn_Report,btn_Setting };
            switch (tempChange)
            {
                case 0:
                    foreach (Panel panel in panels)
                        panel.BackColor = Color.FromArgb(170, 172, 187);
                    foreach (Button button in buttons)
                        button.BackColor = Color.FromArgb(170, 172, 187);
                    break;
                case 1:
                    foreach (Panel panel in panels)
                        panel.BackColor = Color.FromArgb(24, 30, 50);
                    foreach (Button button in buttons)
                        button.BackColor = Color.FromArgb(24, 30, 50);
                    break;
                default:
                    break;
            }

        }
        #endregion

        #region Notification. . .
        private void Setting_CheckBox_PauseAll_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {

            if (Setting_CheckBox_PauseAll.Checked)
            {
                isCheckBoxNotification = true;
                PauseAllNotification(isCheckBoxNotification);
            }
            else
                PauseAllNotification(isCheckBoxNotification);
                
        }
        void PauseAllNotification(bool isTempChange)
        {
            if (isTempChange)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to turn Off ?!", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Setting_CheckBox_Feedback.Checked = false;
                    Setting_CheckBox_Reminder.Checked = false;
                    Setting_CheckBox_Product.Checked = false;
                    Setting_CheckBox_News.Checked = false;
                    Setting_CheckBox_Support.Checked = false;
                    isCheckBoxNotification = false;
                }
            }
        }
        private void Setting_CheckBox_Feedback_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (Setting_CheckBox_Feedback.Checked)
                Setting_CheckBox_PauseAll.Checked = false;
        }
        private void Setting_CheckBox_Reminder_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (Setting_CheckBox_Reminder.Checked)
                Setting_CheckBox_PauseAll.Checked = false;
        }
        private void Setting_CheckBox_Product_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (Setting_CheckBox_Product.Checked)
                Setting_CheckBox_PauseAll.Checked = false;
        }
        private void Setting_CheckBox_News_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (Setting_CheckBox_News.Checked)
                Setting_CheckBox_PauseAll.Checked = false;
        }
        private void Setting_CheckBox_Support_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (Setting_CheckBox_Support.Checked)
                Setting_CheckBox_PauseAll.Checked = false;
        }
        #endregion


    }
}
