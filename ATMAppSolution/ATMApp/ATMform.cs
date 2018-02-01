using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMApp
{


    public partial class ATMform : Form
    {
        private int pass = 1234;
        private double amount = 1000;
        Boolean withdrawlFlag = false;

        public ATMform(int pass, double amount)
        {
            this.pass = 1234;
            this.amount = 1000;
        }

        public ATMform()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            int userVal = int.Parse(passwordTextBox.Text);
            if (userVal == pass)
            {
                passwordLabel.ForeColor = Color.Blue;
                passwordLabel.Text = "Please make an action";
                passwordTextBox.Visible = false;
                confirmButton.Visible = false;
                depositeButton.Visible = true;
                withdrawlButton.Visible = true;

            }
            else
            {
                passwordLabel.Text = "Wrong Password! Please Try Again";
                passwordLabel.ForeColor = Color.DarkRed;
            }

        }

        public double GetAmount()
        {
            return amount;
        }

        public void SetAmount(double x)
        {
            if (withdrawlFlag == false)
                this.amount += x;
            if(withdrawlFlag == true)
                this.amount -= x;

        }

        private void depositeButton_Click(object sender, EventArgs e)
        {
            depositeTextBox.Visible = true;
            confirmDepositeButton.Visible = true;
            withdrawlButton.Visible = false;
            confirmDepositeButton.Text = "Confirm amount of Deposite";

        }

        private void confirmDepositeButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            if (withdrawlFlag == false)
            {
                string message = "The amount you want to deposite is: " + depositeTextBox.Text + "$\n" + "Are you sure?";
                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                string message = "The amount you want to withdrawl is: " + depositeTextBox.Text + "$\n" + "Are you sure?";
                result = MessageBox.Show(message, caption, buttons);
            }

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                int depositeVal = int.Parse(depositeTextBox.Text);
                SetAmount(depositeVal);
                this.DialogResult = System.Windows.Forms.DialogResult.No;
                double myAmount = GetAmount();
                myAmountLabel.Text = "Your Total Balance is: " + myAmount.ToString() + "$";
                myAmountLabel.Visible = true;
                confirmDepositeButton.Visible = false;
                depositeTextBox.Visible = false;
                depositeButton.Visible = true;
                withdrawlButton.Visible = true;
                withdrawlFlag = false;
            }

            if (result == System.Windows.Forms.DialogResult.No)
            {
                depositeTextBox.Visible = true;
                confirmDepositeButton.Visible = true;
            }
            
        }

        private void withdrawlButton_Click(object sender, EventArgs e)
        {
            withdrawlFlag = true;
            depositeTextBox.Visible = true;
            confirmDepositeButton.Visible = true;
            depositeButton.Visible = false;
            confirmDepositeButton.Text = "Confirm amount to Withdrawl";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            israelPictureBox.Visible = true;
            britainPictureBox.Visible = true;
            languageLabel.Visible = true;
        }

        private void britainPictureBox_Click(object sender, EventArgs e)
        {
            israelPictureBox.Visible = false;
            britainPictureBox.Visible = false;
            languageLabel.Visible = false;
        }

        private void israelPictureBox_Click(object sender, EventArgs e)
        {
            israelPictureBox.Visible = false;
            britainPictureBox.Visible = false;
            languageLabel.Visible = false;
            headerLabel.Text = "ברוכים הבאים";
            passwordLabel.Text = "נא הכנס סיסמה";
            confirmButton.Text = "אישור";
            withdrawlButton.Text = "משיכה";
            depositeButton.Text = "הפקדה";

            

        }
    }
}
