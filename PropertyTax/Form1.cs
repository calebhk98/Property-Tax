using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyTax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void propertyValue_TextChanged( object sender, EventArgs e)
        {
			//Vars
            double tax = 0;
            double propertyTax = 0;
           if (double.TryParse(propertyValue.Text, out propertyTax))
            {
                errorLabel.Visible = false;//hides any error
                tax = Math.Round(propertyTax /100 * 0.64, 2);//Math
               

                taxAmount.Text = "$" + tax.ToString();//Shows on screen
                


            }//Combines the try catch with parse
            else if (propertyValue.Text == "")
            {
                errorLabel.Visible = false;
                taxAmount.Text = "$0.00";

            }//This hides any error, and only shows $0.00 if there is no value
            else
            {
                errorLabel.Visible = true;
            }//If something is wrong, wil show an error
        }
    }
}
