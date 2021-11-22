//Bryce Haw
//Pizza GUI
//Unable to pass tip back to main form

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUIPizza
{
    public partial class frmMain : Form
    {
        string order;
        double  subtotal, total, userTip;

        private void frmMain_Load(object sender, EventArgs e)
        {
            subtotal = getOrder();
            txtSubtotal.Text = Convert.ToString(Math.Round(subtotal, 2, MidpointRounding.AwayFromZero));
            txtTax.Text = Convert.ToString(Math.Round((subtotal * salesTax), 2, MidpointRounding.AwayFromZero));
            txtTotal.Text = Convert.ToString(Math.Round((subtotal * salesTax) + subtotal, 2, MidpointRounding.AwayFromZero));
        }

        double salesTax = 0.06875;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            order = "";

            order += radThinCrust.Checked ? "Thin Crust" : "";
            order += radTraditional.Checked ? "Traditional" : "";
            order += radDeepDish.Checked ? "Deep Dish" : "";
            order += radStuffedCrust.Checked ? "Stuffed Crust" : "";

            order += chkExtraCheese.Checked ? " Extra Cheese" : "";
            order += chkPepperoni.Checked ? " Pepperoni" : "";
            order += chkSausage.Checked ? " Sausage" : "";
            order += chkBlackOlives.Checked ? " Black Olives" : "";
            order += chkMushrooms.Checked ? " Mushrooms" : "";
            order += chkPineapple.Checked ? " Pineapple" : "";
            order += chkBacon.Checked ? " Bacon" : "";
            order += chkChicken.Checked ? " Chicken" : "";
            order += chkOnion.Checked ? " Onions" : "";
            order += chkBellPeppers.Checked ? " Bell Peppers" : "";

            order += radDineIn.Checked ? " Dine In" : "";
            order += radTakeOut.Checked ? " Take Out" : "";
            order += radDelivery.Checked ? " Delivery" : "";

            order += chkWater.Checked ? " Water" : "";
            order += chkPepsi.Checked ? " Pepsi" : "";
            order += chkSprite.Checked ? " Sprite" : "";
            order += chkCoffee.Checked ? " Coffee" : "";

            order += " " + mTxtBoxPhoneNumber.Text;

            txtOrder.Text = order;

            subtotal = getOrder();
            userTip = getTip();

            txtSubtotal.Text = Convert.ToString(Math.Round(subtotal,2,MidpointRounding.AwayFromZero));
            txtTax.Text = Convert.ToString(Math.Round((subtotal*salesTax), 2,MidpointRounding.AwayFromZero));
            txtTotal.Text = Convert.ToString( Math.Round((subtotal*salesTax)+subtotal,2,MidpointRounding.AwayFromZero) );
        }

        private void radDelivery_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("radDelivery Check Changed");

            if (radDelivery.Checked)
            {
                DialogResult result = MessageBox.Show(
                    "We deliver to addresses within " +
                    "the city limits\n of St. Cloud, Sauk Rapids, and Sartell" +
                    "\n\nAre you within the delivery area?", 
                    "Delivery Area",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if(result == DialogResult.No)
                {
                    radTakeOut.Checked = true;
                }

            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuCalculator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"calc.exe");
        }

        private void menuHelp_Click(object sender, EventArgs e)
        {
            formHelp myFormHelp = new formHelp();
            myFormHelp.Show();
        }

        private void timerBlink1_Tick(object sender, EventArgs e)
        {
            picBoxSign.Visible = false;
            timerBlink2.Enabled = true;
            timerBlink1.Enabled = false;
        }

        private void timerBlink2_Tick(object sender, EventArgs e)
        {
            picBoxSign.Visible = true;
            timerBlink1.Enabled = true;
            timerBlink2.Enabled = false;
        }

        private void btnAddTip_Click(object sender, EventArgs e)
        {
            userTip = 0.00;
            DialogResult result = MessageBox.Show(
                    "Would you like to add a tip?",
                    "Tip",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                double myTip;
                //varibales to set to add tip
                subtotal = getOrder();
                total = (subtotal * salesTax)+subtotal;

                tip userTip = new tip(subtotal, total);
                userTip.ShowDialog();
                if(userTip.chk15 == true)
                {
                    myTip = 0.15;
                    setTip(myTip);
                }
                else if(userTip.chk20 == true)
                {
                    myTip = 0.20;
                    setTip(myTip);
                }
            }
        }
        public double getOrder()
        {
            //get subtotal
            subtotal = 0.00;

            subtotal += radThinCrust.Checked ? 12.99 : 0.00;
            subtotal += radTraditional.Checked ? 9.99 : 0.00;
            subtotal += radDeepDish.Checked ? 14.99 : 0.00;
            subtotal += radStuffedCrust.Checked ? 17.99 : 0.00;

            subtotal += chkExtraCheese.Checked ? 0.50 : 0.00;
            subtotal += chkPepperoni.Checked ? 0.50 : 0.00;
            subtotal += chkSausage.Checked ? 1.99 : 0.00;
            subtotal += chkBlackOlives.Checked ? 0.50 : 0.00;
            subtotal += chkMushrooms.Checked ? 0.50 : 0.00;
            subtotal += chkPineapple.Checked ? 0.50 : 0.00;
            subtotal += chkBacon.Checked ? 1.99 : 0.00;
            subtotal += chkChicken.Checked ? 1.99 : 0.00;
            subtotal += chkOnion.Checked ? 0.50 : 0.00;
            subtotal += chkBellPeppers.Checked ? 0.50 : 0.00;

            subtotal += radDineIn.Checked ? 0.00 : 0.00;
            subtotal += radTakeOut.Checked ? 0.00 : 0.00;
            subtotal += radDelivery.Checked ? 3.99 : 0.00;

            subtotal += chkWater.Checked ? 0.00 : 0.00;
            subtotal += chkPepsi.Checked ? 1.99 : 0.00;
            subtotal += chkSprite.Checked ? 1.99 : 0.00;
            subtotal += chkCoffee.Checked ? 2.99 : 0.00;

            return subtotal;
        }
        public void setTip(double myTip)
        {
            userTip = myTip;
        }
        public double getTip()
        {
            return userTip;
        }
    }
}
