using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDialogs;

namespace Money_Credit_Counter
{
    public partial class Form1 : Form
    {

        int Total_pence = 0;
        decimal Total_Pound = 0.00m;
        int count_1p = 0;
        int count_2p = 0;
        int count_5p = 0;
        int count_10p = 0;
        int count_20p = 0;
        int count_50p = 0;
        int count_1pound = 0;
        int count_2pound = 0;
        int creditcost;
        int credit;





        public Form1()
        {
            InitializeComponent();

            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            if (creditcost == 0) // If statement checking if the credit per cost has been entered
            {
                MessageBox.Show("Please enter the amount of credit"); // If not, shows this message
            }
            else // Otherwise
            {

                Total_pence += 1; // adds 1p to the total pence value
                Total_Pound += 0.01m; // adds 1p to the total pound value 
                count_1p += 1; // adds 1 to the count of the coin
            }
            lbl_1p.Text = count_1p.ToString(); // displays the count on the label for the coin
            txt_Totalpence.Text = Total_pence.ToString(); // displays the total in pence
            txt_Totalpound.Text = Total_Pound.ToString(); // displays the total in pounds

            credit = Total_pence / creditcost;
            txt_numofcredit.Text = credit.ToString();

        }

        private void btn_2p_Click(object sender, EventArgs e)
        {
            if (creditcost == 0) // If statement checking if the credit per cost has been entered
            {
                MessageBox.Show("Please enter the amount of credit"); // If not, shows this message
            }
            else // Otherwise
            {

                Total_pence += 2; // adds 2p to the total pence value
                Total_Pound += 0.02m; // adds 2p to the total pound value 
                count_2p += 1; // adds 1 to the count of the coin
            }
            lbl_2p.Text = count_2p.ToString(); // displays the count on the label for the coin
            txt_Totalpence.Text = Total_pence.ToString(); // displays the total in pence
            txt_Totalpound.Text = Total_Pound.ToString(); // displays the total in pounds

            credit = Total_pence / creditcost;
            txt_numofcredit.Text = credit.ToString();
        }

        private void btn_Credit_Click(object sender, EventArgs e)
        {
            int.TryParse(My_Dialogs.InputBox("Please enter the credit: "), out creditcost); // Opens a inputbox from the My_Dialogs class asking for the Cost per credit
            lbl_Costcredit.Text = creditcost.ToString(); //Sets the label to the inputted cost per credit

        }

        private void btn_5p_Click(object sender, EventArgs e)
        {
            if (creditcost == 0) // If statement checking if the credit per cost has been entered
            {
                MessageBox.Show("Please enter the amount of credit"); // If not, shows this message
            }
            else // Otherwise
            {

                Total_pence += 5; // adds 5p to the total pence value
                Total_Pound += 0.05m; // adds 5p to the total pound value 
                count_5p += 1; // adds 1 to the count of the coin
            }
            lbl_5p.Text = count_5p.ToString(); // displays the count on the label for the coin
            txt_Totalpence.Text = Total_pence.ToString(); // displays the total in pence
            txt_Totalpound.Text = Total_Pound.ToString(); // displays the total in pounds

            credit = Total_pence / creditcost;
            txt_numofcredit.Text = credit.ToString();
        }

        private void btn_10p_Click(object sender, EventArgs e)
        {
            if (creditcost == 0) // If statement checking if the credit per cost has been entered
            {
                MessageBox.Show("Please enter the amount of credit"); // If not, shows this message
            }
            else // Otherwise
            {

                Total_pence += 10; // adds 10p to the total pence value
                Total_Pound += 0.10m; // adds 10p to the total pound value 
                count_10p += 1; // adds 1 to the count of the coin
            }
            lbl_10p.Text = count_10p.ToString(); // displays the count on the label for the coin
            txt_Totalpence.Text = Total_pence.ToString(); // displays the total in pence
            txt_Totalpound.Text = Total_Pound.ToString(); // displays the total in pounds

            credit = Total_pence / creditcost;
            txt_numofcredit.Text = credit.ToString();
        }

        private void btn_20p_Click(object sender, EventArgs e)
        {
            if (creditcost == 0) // If statement checking if the credit per cost has been entered
            {
                MessageBox.Show("Please enter the amount of credit"); // If not, shows this message
            }
            else // Otherwise
            {

                Total_pence += 20; // adds 20p to the total pence value
                Total_Pound += 0.20m; // adds 20p to the total pound value 
                count_20p += 1; // adds 1 to the count of the coin
            }
            lbl_20p.Text = count_20p.ToString(); // displays the count on the label for the coin
            txt_Totalpence.Text = Total_pence.ToString(); // displays the total in pence
            txt_Totalpound.Text = Total_Pound.ToString(); // displays the total in pounds

            credit = Total_pence / creditcost;
            txt_numofcredit.Text = credit.ToString();
        }

        private void btn_50p_Click(object sender, EventArgs e)
        {
            if (creditcost == 0) // If statement checking if the credit per cost has been entered
            {
                MessageBox.Show("Please enter the amount of credit"); // If not, shows this message
            }
            else // Otherwise
            {

                Total_pence += 50; // adds 50p to the total pence value
                Total_Pound += 0.50m; // adds 50p to the total pound value 
                count_50p += 1; // adds 1 to the count of the coin
            }
            lbl_50p.Text = count_50p.ToString(); // displays the count on the label for the coin
            txt_Totalpence.Text = Total_pence.ToString(); // displays the total in pence
            txt_Totalpound.Text = Total_Pound.ToString(); // displays the total in pounds

            credit = Total_pence / creditcost;
            txt_numofcredit.Text = credit.ToString();
        }
        private void btn_1pound_Click(object sender, EventArgs e)
        {
            if (creditcost == 0) // If statement checking if the credit per cost has been entered
            {
                MessageBox.Show("Please enter the amount of credit"); // If not, shows this message
            }
            else // Otherwise
            {

                Total_pence += 100; // adds 100p to the total pence value
                Total_Pound += 1.00m; // adds £1 to the total pound value 
                count_1pound += 1; // adds 1 to the count of the coin
            }
            lbl_1pound.Text = count_1pound.ToString(); // displays the count on the label for the coin
            txt_Totalpence.Text = Total_pence.ToString(); // displays the total in pence
            txt_Totalpound.Text = Total_Pound.ToString(); // displays the total in pounds

            credit = Total_pence / creditcost;
            txt_numofcredit.Text = credit.ToString();

        
            
        }
        private void btn_2pound_Click(object sender, EventArgs e)
        {
            if (creditcost == 0) // If statement checking if the credit per cost has been entered
            {
                MessageBox.Show("Please enter the amount of credit"); // If not, shows this message
            }
            else // Otherwise
            {

                Total_pence += 200; // adds 200p to the total pence value
                Total_Pound += 2.00m; // adds £2 to the total pound value 
                count_2pound += 1; // adds 1 to the count of the coin
            }
            lbl_2pound.Text = count_2pound.ToString(); // displays the count on the label for the coin
            txt_Totalpence.Text = Total_pence.ToString(); // displays the total in pence
            txt_Totalpound.Text = Total_Pound.ToString(); // displays the total in pounds

            credit = Total_pence / creditcost;
            txt_numofcredit.Text = credit.ToString();

        }
        private void btn_reset_Click(object sender, EventArgs e) // Instead of resetting all the variables and textboxes to 0
        {
            Form1 NewForm = new Form1(); //Creates a copy of the blank form
            NewForm.Show(); // Shows the newly created form
            this.Dispose(false); // Deletes the old form

        }
    }
}
