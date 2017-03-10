using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MillerAssignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Calculate Button event "click"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //Brings in the business class
            Business business = new Business();

            decimal cost;
            //User must enter a deimal value and this will check for that value the text box
            if (decimal.TryParse(WholesalePriceText.Text, out cost))
            {
                //Will calculate and return as a string, then puts that value into the restul label to display back to user
                RetailResultLabel.Text = business.GetRetailPrices(cost);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
