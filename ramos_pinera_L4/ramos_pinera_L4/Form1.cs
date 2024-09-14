using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ramos_pinera_L4
{
    public partial class Form1 : Form
    {
        double memberDiscount = 50;
        double takeOutFee = 10;
        double ptsForMember = .03;

        //tagahold ng tota
        double total = 0;

        //global var ng prices
        double item1 = 0;
        double item2 = 0;
        double item3 = 0;
        double item4 = 0;
        double item5 = 0;
        double item6 = 0;
        double item7 = 0;
        double item8 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void chkItem1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItem1.Checked)
            {
                numItem1.Enabled = true;
            }
            else
            {
                numItem1.Enabled = false;
                numItem1.Value = 0;
            }
        }

        private void chkItem2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItem2.Checked)
            {
                numItem2.Enabled = true;
            }
            else
            {
                numItem2.Enabled = false;
                numItem2.Value = 0;
            }
        }

        private void chkItem3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItem3.Checked)
            {
                numItem3.Enabled = true;
            }
            else
            {
                numItem3.Enabled = false;
                numItem3.Value = 0;
            }
        }

        private void chkItem4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItem4.Checked)
            {
                numItem4.Enabled = true;
            }
            else
            {
                numItem4.Enabled = false;
                numItem4.Value = 0;
            }
        }

        private void chkItem5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItem5.Checked)
            {
                numItem5.Enabled = true;
            }
            else
            {
                numItem5.Enabled = false;
                numItem5.Value = 0;
            }
        }

        private void chkItem6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItem6.Checked)
            {
                numItem6.Enabled = true;
            }
            else
            {
                numItem6.Enabled = false;
                numItem6.Value = 0;
            }
        }

        private void chkItem7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItem7.Checked)
            {
                numItem7.Enabled = true;
            }
            else
            {
                numItem7.Enabled = false;
                numItem7.Value = 0;
            }
        }

        private void chkItem8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItem8.Checked)
            {
                numItem8.Enabled = true;
            }
            else
            {
                numItem8.Enabled = false;
                numItem8.Value = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numItem1.Enabled = false;
            numItem2.Enabled = false;
            numItem3.Enabled = false;
            numItem4.Enabled = false;
            numItem5.Enabled = false;
            numItem6.Enabled = false;
            numItem7.Enabled = false;
            numItem8.Enabled = false;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            total = item1 + item2 + item3 + item4 + item5 + item6 + item7 + item8;

            lblAmount.Text = total.ToString();
        }

        private void numItem1_ValueChanged(object sender, EventArgs e)
        {
            item1 = (int)numItem1.Value * 120.00;
        }

        private void numItem2_ValueChanged(object sender, EventArgs e)
        {
            item2 = (int)numItem2.Value * 110.00;
        }

        private void numItem3_ValueChanged(object sender, EventArgs e)
        {
            item3 = (int)numItem3.Value * 125.00;
        }

        private void numItem4_ValueChanged(object sender, EventArgs e)
        {
            item4 = (int)numItem4.Value * 150.00;
        }

        private void numItem5_ValueChanged(object sender, EventArgs e)
        {
            item5 = (int)numItem5.Value * 90.00;
        }

        private void numItem6_ValueChanged(object sender, EventArgs e)
        {
            item6 = (int)numItem6.Value * 135.00;
        }

        private void numItem7_ValueChanged(object sender, EventArgs e)
        {
            item7 = (int)numItem7.Value * 155.00;
        }

        private void numItem8_ValueChanged(object sender, EventArgs e)
        {
            item8 = (int)numItem8.Value * 162.00;
        }
    }
}
