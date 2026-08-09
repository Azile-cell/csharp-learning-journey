using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAmountDue_TextChanged(object sender, EventArgs e)
        {
            UpdateAmountDue();
        }
        private void UpdateAmountDue()
        {
            int toppingAmount = 7;
            int total = 0;


            if (rdSmall.Checked == true)
            {
                total += 20;
            }
            else if (rdMedium.Checked == true)
            {
                total += 35;
            }
            else if (rdLarge.Checked == true)
            {
                total += 55;
            }

            if (rdThick.Checked == true)
            {
                total += 2;
            }
            else if (rdThin.Checked == true)
            {
                total += 1;
            }

            int toppingCount = 0;
            if (chkPepperoni.Checked)
            {
                toppingCount++;
            }

            if (chkJalapeno.Checked)
            {
                toppingCount++;

            }
            if (chkSpinach.Checked)
            {
                toppingCount++;
            }
            if (chkExtraCheese.Checked)
            {
                toppingCount++;
            }
            if (chkPineapple.Checked)
            {
                toppingCount++;
            }
            if (chkSheddedChicken.Checked)
            {
                toppingCount++;
            }
            if (chkMushroom.Checked)
            {
                toppingCount++;
            }
            if (chkDriedShrimp.Checked)
            {
                toppingCount++;
            }
            if (chkGroundedBeef.Checked)
            {
                toppingCount++;
            }

            total += toppingCount * toppingAmount;

            txtAmountDue.Text = total.ToString();


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                UpdateAmountDue();

            }
        }
    }

}
    

