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
    public partial class frmFinalAccountResult : Form
    {
        #region local Value. . . 

        frmStart start;
        
        #endregion

        public frmFinalAccountResult()
        {
            InitializeComponent();
            txt_Source_Code.Text = frmMakeAccount.PersonSourceId;
        }

        #region Form Process. . .
        private void frmFinalAccountResult_Load(object sender, EventArgs e)
        {
            lbl_Successfuly.Text = frmMakeAccount.PersonName.ToUpper() + " " + lbl_Successfuly.Text;
        }

        #endregion

        #region OK Button. . .
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            start = new frmStart();
            start.Show();
            this.Close();
        }
        #endregion

    }
}
