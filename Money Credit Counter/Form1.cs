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
        Double Total_Pound = 0.00;
        int count_1p = 0;
        int count_2p = 0;
        int count_5p = 0;
        int count_10p = 0;
        int count_20p = 0;
        int count_50p = 0;
        int count_1pound = 0;
        int count_2pound = 0;
        int creditcost;





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
                Total_Pound += 0.01; // adds 1p to the total pound value 
                count_1p += 1; // adds 1 to the count of the coin
            }



        }

        private void btn_2p_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Credit_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_5p_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_10p_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_20p_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_50p_Click(object sender, EventArgs e)
        {
            
        }
        private void btn_1pound_Click(object sender, EventArgs e)
        {

        }
        private void btn_2pound_Click(object sender, EventArgs e)
        {

        }
        private void btn_reset_Click(object sender, EventArgs e) 
        {
           
        }
    }
}
