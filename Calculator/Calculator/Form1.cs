using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Calculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
        }

        #region Local Value. . .
        string FirstNumber;
        string LastNumber;
        bool CheckClick = false;
        #endregion

        #region Move Panel. . .

        bool Drag = false;
        Point Start_Point = new Point(0,0);
        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            Start_Point = new Point((int)e.X, (int)e.Y);
        }

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - Start_Point.X, p.Y - Start_Point.Y);
            }
        }

        private void MainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            Drag = false;
        }



        #endregion
        
        #region Button Number. . .
        private void CheckLabelNumber()
        {
            if (lblShowNumberResult.Text == "0")
                lblShowNumberResult.Text = null;
            if (CheckClick)
            {
                lblShowNumberResult.Text = null;
                CheckClick = false;
            }
        }
        private void btnNumber_1_Click(object sender, EventArgs e)
        {
            CheckLabelNumber();
            lblShowNumberResult.Text += "1";
        }

        private void btnNumber_2_Click(object sender, EventArgs e)
        {
            CheckLabelNumber();
            lblShowNumberResult.Text += "2";
        }
        private void btnNumber_3_Click(object sender, EventArgs e)
        {
            CheckLabelNumber();
            lblShowNumberResult.Text += "3";
        }

        private void btnNumber_4_Click(object sender, EventArgs e)
        {
            CheckLabelNumber();
            lblShowNumberResult.Text += "4";
        }

        private void btnNumber_5_Click(object sender, EventArgs e)
        {
            CheckLabelNumber();
            lblShowNumberResult.Text += "5";
        }

        private void btnNumber_6_Click(object sender, EventArgs e)
        {
            CheckLabelNumber();
            lblShowNumberResult.Text += "6";
        }

        private void btnNumber_7_Click(object sender, EventArgs e)
        {
            CheckLabelNumber();
            lblShowNumberResult.Text += "7";
        }

        private void btnNumber_8_Click(object sender, EventArgs e)
        {
            CheckLabelNumber();
            lblShowNumberResult.Text += "8";
        }

        private void btnNumber_9_Click(object sender, EventArgs e)
        {
            CheckLabelNumber();
            lblShowNumberResult.Text += "9";
        }

        private void btnNumber_0_Click(object sender, EventArgs e)
        {
            CheckLabelNumber();
            lblShowNumberResult.Text += "0";
        }


        #endregion

        #region Calculations. . .
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            FirstNumber = lblShowNumberResult.Text.ToString();
            lblShowBackNumber.Text = lblShowNumberResult.Text + " × " ;
            CheckClick = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            FirstNumber = lblShowNumberResult.Text.ToString();
            lblShowBackNumber.Text = lblShowNumberResult.Text + " - ";
            CheckClick = true;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            FirstNumber = lblShowNumberResult.Text.ToString();
            lblShowBackNumber.Text = lblShowNumberResult.Text + " + ";
            CheckClick = true;
        }
        private void btnPercentage_Click(object sender, EventArgs e)
        {
            FirstNumber = lblShowNumberResult.Text.ToString();
            lblShowBackNumber.Text = lblShowNumberResult.Text + " ÷ ";
            CheckClick = true;
        }
        private void brnSqrt_Click(object sender, EventArgs e)
        {
            FirstNumber = lblShowNumberResult.Text.ToString();
            double Set_Temp = Convert.ToDouble(lblShowNumberResult.Text);
            float Get_Temp = float.Parse(Math.Sqrt(Set_Temp).ToString());
            lblShowNumberResult.Text = Get_Temp.ToString();
            lblShowBackNumber.Text = "√(" + FirstNumber + ")";
            CheckClick=true;
        }
        private void btnResult_Click(object sender, EventArgs e)
        {
            
            lblShowBackNumber.Text += lblShowNumberResult.Text + " ="; 
            int First_num = Convert.ToInt32(FirstNumber);
            int Last_num = Convert.ToInt32(lblShowNumberResult.Text);
            
            foreach (var item in lblShowBackNumber.Text)
            {
                if (item == '+')
                {
                    lblShowNumberResult.Text = (First_num + Last_num).ToString();
                }
                if (item == '-')
                {
                    lblShowNumberResult.Text = (First_num - Last_num).ToString();
                }
                if (item == '×')
                {
                    lblShowNumberResult.Text = (First_num * Last_num).ToString();
                }
                if (item == '÷')
                {
                    lblShowNumberResult.Text = (First_num / Last_num).ToString();
                }
            }
        }

        #endregion

        #region Edit Case. . .
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblShowNumberResult.Text = "0";
            lblShowBackNumber.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lblShowNumberResult.Text = lblShowNumberResult.Text.Remove(lblShowNumberResult.Text.Length - 1);
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void btnReverse_Click(object sender, EventArgs e)
        {
            lblShowNumberResult.Text = lblShowNumberResult.Text.Insert(0, "-");

            
            
        }
    }
}
