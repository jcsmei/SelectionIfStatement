using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SelectionIfStatement
{
    public partial class SelectionIfStatement : Form
    {
        public SelectionIfStatement()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            txtOutput.BackColor = Color.White;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSingleAlt_Click(object sender, EventArgs e)
        {
            string strUser = Interaction.InputBox(
                "Do you want to turn the box orange? Y for Yes, other letters for No.");
            if (strUser.ToUpper() == "Y")
            {
                txtOutput.BackColor = Color.Green;
            }

        }

        private void btnDualAlt_Click(object sender, EventArgs e)
        {
            string strUser = Interaction.InputBox("Type G for green, other letters for orange");
            if (strUser.ToUpper() == "G")
            {
                txtOutput.BackColor = Color.Green;
            }
            else
            {
                txtOutput.BackColor = Color.Orange;
            }
        }

        private void btnMultiAlt_Click(object sender, EventArgs e)
        {
            string strUser = Interaction.InputBox(
                "Type G for green, O for orange, V for Violet, R for Red," + "Y for Yellow, other letters for white.");
            if (strUser.ToUpper() == "G")
            {
                txtOutput.BackColor = Color.Green;
            }
            else if (strUser.ToUpper() == "O")
            {
                txtOutput.BackColor = Color.Orange;
            }
            else if (strUser.ToUpper() == "V")
            {
                txtOutput.BackColor = Color.Violet;
            }
            else if (strUser.ToUpper() == "R")
            {
                txtOutput.BackColor = Color.Red;
            }
            else if (strUser.ToUpper() == "Y")
            {
                txtOutput.BackColor = Color.Yellow;
            }
            else
            {
                txtOutput.BackColor = Color.White;
            }
        }

        private void btnCoupon_Click(object sender, EventArgs e)
        {
            string strUser = Interaction.InputBox("Do you have a coupon? Y for Yes and othe letters for No.");
            if (strUser.ToUpper() == "Y")
            {
                txtOutput.Text = "You get 10% discount with coupon. $180 please.";
            }
            else
            {
                txtOutput.Text = "$200 please.";
            }
        }

        private void btnTryParse_Click(object sender, EventArgs e)
        {
            byte bytX = 0;
            string strInput = Interaction.InputBox("Type something and see what the function Byte.TryParse do.");
            if (byte.TryParse(strInput, out bytX))
            {
                txtOutput.Text = "Byte.TryParse function returns " + byte.TryParse(strInput, out bytX) +
                    " becasue \"" + strInput + "\" can be converted into a Byte number. " + "At the same time. " +
                    bytX + " is assigned to the variable bytX.";
            }
            else
            {
                txtOutput.Text = "Byte.Tryparse function returns " + byte.TryParse(strInput, out bytX) +
                    " becasue \"" + strInput + "\" cannot be converted into a Byte number. " + "At the same time, " +
                    bytX + " is assigned to the variable bytX.";
            }
        }

        private void btnDriverLic_Click(object sender, EventArgs e)
        {
            byte bytAge = 0;
            string strAge = Interaction.InputBox("How old are you?" + Constants.vbNewLine + "If you are 18 tomorrow, you should answer 17.");
            if (byte.TryParse(strAge, out bytAge) == false)
            {
                txtOutput.Text = "Please enter a reasonable integer number for age." + strAge + " is not correct. Try Again.";
                return;
            }
            if (bytAge >= 18)
            {
                txtOutput.Text = "You may apply for a driver license.";
            }
            else if (bytAge >= 16)
            {
                txtOutput.Text = "You may apply for a driving permit, and drive under supervision.";
            }
            else
            {
                txtOutput.Text = "You are too young to drive.";
            }
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            string strUser = Interaction.InputBox(
                "Type S for senior, C for child, other letter for anyone else,");
            if (strUser.ToUpper() == "S")
            {
                txtOutput.Text = "Five dollars for a senior.";
            }
            else if (strUser.ToUpper() == "C")
            {
                txtOutput.Text = "Free for Children.";
            }
            else
            {
                txtOutput.Text = "Pay $10.00 please.";
            }
        }

        private void btnVending_Click(object sender, EventArgs e)
        {
            string strUser = Interaction.InputBox(
                "Tyep 10 for Pepsi; 15 for Coca-Cola; 18 for Snapple; 22 for Ginger Ale; 30 for Gatorade");
            if (strUser == "10")
            {
                txtOutput.Text = "You get a Pepsi.";
            }
            else if (strUser == "15")
            {
                txtOutput.Text = "You get a Cola-Cola";
            }
            else if (strUser == "18")
            {
                txtOutput.Text = "You get a Snapple";
            }
            else if (strUser == "22")
            {
                txtOutput.Text = "You get a Ginger Ale";

            }
            else if (strUser == "130")
            {
                txtOutput.Text = "You get a Gatorade";
            }
            else
            {
                txtOutput.Text = strUser + " is a wrong choice. Try Again.";
            }

        }
    }
}
   
