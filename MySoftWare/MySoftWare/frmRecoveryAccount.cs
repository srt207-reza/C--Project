using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.Entity;

namespace MySoftWare
{
    public partial class frmRecoveryAccount : Form
    {
        public frmRecoveryAccount()
        {
            InitializeComponent();
            Gmail_CheckBox.Checked = true;
            pnl_TempGmail.Show();
            pnl_TempSourceId.Hide();
        }

        #region Exit. . .
        private void btn_Recovery_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Local Value. . .
        
        bool MoveRecoveryPage;

        public static string DataCode = null;

        public static string Pass = null;

        Point pointer;

        frmFinalRecovery recovery;

        #endregion

        #region Move Page. . .
        private void pnl_Move_RecoveryPage_MouseDown(object sender, MouseEventArgs e)
        {
            MoveRecoveryPage = true;
            pointer = new Point(e.X, e.Y);
        }

        private void pnl_Move_RecoveryPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveRecoveryPage)
            {
                Point screen = PointToScreen(e.Location);
                this.Location = new Point(screen.X - pointer.X,screen.Y - pointer.Y);
            }
        }

        private void pnl_Move_RecoveryPage_MouseUp(object sender, MouseEventArgs e)
        {
            MoveRecoveryPage = false;
        }

        #endregion

        #region Checker. . .
        private void Gmail_CheckBox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (Gmail_CheckBox.Checked)
            {
                SourceId_CheckBox.Checked = false;
                txt_Recovery_Gmail.Text = "";
                pnl_TempGmail.Show();
                pnl_TempSourceId.Hide();
            }
        }
        private void SourceId_CheckBox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (SourceId_CheckBox.Checked)
            {
                Gmail_CheckBox.Checked = false;
                txt_Recovery_SourceId.Text = "";
                pnl_TempSourceId.Show();
                pnl_TempGmail.Hide();
            }
        }
        #endregion

        #region Verification. . .
        private void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                using (DB_SalePersonEntities dB = new DB_SalePersonEntities())
                {
                    if (dB.Tbl_PeopleData.Any(p => p.UserName.Contains(txt_Recovery_UserName.Text)))
                    {
                        if (Gmail_CheckBox.Checked)
                        {
                            SaveData data = new SaveData();
                            recovery = new frmFinalRecovery();
                            DataCode = data.OnGetRandomCode();
                            Pass = dB.Tbl_PeopleData.Where(p => p.UserName.Contains(txt_Recovery_UserName.Text)).Select(p => p.Password).FirstOrDefault();
                            string body = $"Your Verification Code is :<b> {DataCode}</b>" +
                                $"<br /><br />if you did not request this code,it is possible that someone" +
                                $"else is trying to access your account !<br />Do Not forward or give this code to anyone." +
                                $"<br />This code will expire in <b>24</b> hours.";

                            MailMessage message = new MailMessage();
                            SmtpClient client = new SmtpClient("smtp.gmail.com");

                            message.From = new MailAddress("rezataghizadeh207@gmail.com");
                            message.To.Add(txt_Recovery_Gmail.Text);

                            message.Subject = "Verification Code. . .";
                            message.IsBodyHtml = true;
                            message.Body = body;

                            client.Port = 587;
                            client.EnableSsl = true;
                            client.UseDefaultCredentials = true;
                            client.Credentials = new System.Net.NetworkCredential("rezataghizadeh207@gmail.com", "sxirgmtxawmoqprs");

                            client.Send(message);
                            recovery.Show();
                            this.Close();
                        }
                        else if (SourceId_CheckBox.Checked)
                        {
                            if (dB.Tbl_PeopleData.Any(n => n.SourceId.Contains(txt_Recovery_SourceId.Text)))
                            {
                                Pass = dB.Tbl_PeopleData.Where(n => n.SourceId.Contains(txt_Recovery_SourceId.Text)).Select(p => p.Password).FirstOrDefault();
                                MessageBox.Show($"Your Password is : {Pass}","Recovery Account",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                recovery = new frmFinalRecovery();
                                recovery.Show();
                                this.Close();
                            }
                            else
                                MessageBox.Show("Wrong Code. . .","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Wrong Infomation. . .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("User Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion



    }
}
