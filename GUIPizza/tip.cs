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
    public partial class tip : Form
    {
        double subtotal, total, tip20, tip15;
        public tip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chk20Tip.Checked)
            {
                txtTotal.Text = Convert.ToString(subtotal + tip20);
            }
            else if (chk15Tip.Checked)
            {

                txtTotal.Text = Convert.ToString(subtotal + tip15);
            }
        }

        public tip(double subtotal, double total)
        {
            InitializeComponent();
            this.subtotal = subtotal;
            this.total = total;
        }

        private void tip_Load(object sender, EventArgs e)
        {
            tip15 = Math.Round((subtotal * .15), 2, MidpointRounding.AwayFromZero);
            tip20 = Math.Round((subtotal * .2),2,MidpointRounding.AwayFromZero);
            txtSubtotal.Text = Convert.ToString(subtotal);
            txtTotal.Text = Convert.ToString(total);

            txt15Tip.Text = Convert.ToString(tip15);
            txt20Tip.Text = Convert.ToString(tip20);
        }
        public Boolean chk15
        {
            get { return chk15Tip.Checked; }
        }
        public Boolean chk20
        {
            get { return chk20Tip.Checked; }
        }
        private void btnAddTip_Click(object sender, EventArgs e)
        {
            if (chk15Tip.Checked)
            {
                this.Close();
            }
            else if (chk20Tip.Checked)
            {
                this.Close();
            }
        }
    }
}
