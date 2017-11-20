//Timothy Mahan
//Lab 7
//Due 3/29/16
//Course Section 01
/*This program compares the data input by a user and compares it to a distance array, then the program
  matches the position in the distance array with a corresponding index position in the price array, this 
  price is then displayed in a message box, which is to inform the user how much it will cost to travel their
  input distance.*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Lab7 : Form
    {
        public Lab7()
        {
            InitializeComponent();
        }

        private void subBttn_Click(object sender, EventArgs e)
        {
            ushort [] distance = {0,100,300,500};//array to hold distance values
            ushort [] price = {25,40,55,70};//array to hold price values
            ushort miles = 0;//integer variable to hold distance a user will travel
            ushort index = 0;//integer variable to hold index number of arrays

            if (ushort.TryParse(distTxtBox.Text, out miles))//ensure data entered is valid
            {
                for (index = (ushort)(distance.Length-1); distance[index] > miles && index >= 0; index--)//search distance index to match user input
                {
                   
                }
                MessageBox.Show(price[index].ToString());//show price user will pay
            }
            else
            {
                MessageBox.Show("Please enter a whole number greater than or equal to 0"); //what displays if data is invalid
            }
        }
    }
}