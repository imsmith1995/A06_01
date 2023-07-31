using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A06_01
{
    public partial class Form1 : Form
    {
        public double subtotal = 0.0;
        public double total = 0;

        public double regularBurgerCost = 4.00;
        public double CheeseBurgerCost = 4.50;
        public double BaconBurgerCost = 5.50;

        public double friesSmall = 1.50;
        public double friesMedium = 2.00;
        public double friesLarge = 2.50;

        public double drinkSmall = 1.00;
        public double drinkMedium = 1.50;
        public double drinkLarge = 2.00;

        public double activeBurger = 0.0;
        public double activeFrie = 0.0;
        public double activeDrink = 0.0;

        public void RecalSubTotal()
        {
            subtotal = activeBurger + activeFrie + activeDrink;
            string writer = subtotal.ToString("C");
            subOutLbl.Text = $"{writer}";
        }

        public void WaterCheck()
        {
            if(selectDrinkToolStripMenuItem8.Text is "Water")
            {
                costLblDrink.Text = "$0.00";
                activeDrink = 0.0;
                RecalSubTotal();
            }
            {
                //if(selectDrinkSizeToolStripMenuItem8.Text is "Small")
                //{
                //    activeDrink = drinkSmall;
                //}
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void cheeseBurgerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chkBurger_CheckedChanged(object sender, EventArgs e)
        {
            SelectBurgerToolStripMenuItem.Visible = chkBurger.Checked;
            if(chkBurger.Checked != true)
            {
                activeBurger = 0;
                costLblBurger.Text = "$0.00";
                SelectBurgerToolStripMenuItem.Text = "(Select a Burger)";
                RecalSubTotal();
            }
        }

        private void burgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectBurgerToolStripMenuItem.Text = burgerToolStripMenuItem.Text;
            string writer = regularBurgerCost.ToString("C");
            costLblBurger.Text = $"{writer}";
            activeBurger = regularBurgerCost;
            RecalSubTotal();
        }

        private void cheeseBurgerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SelectBurgerToolStripMenuItem.Text = cheeseBurgerToolStripMenuItem1.Text;
            string writer = CheeseBurgerCost.ToString("C");
            costLblBurger.Text = $"{writer}";
            activeBurger = CheeseBurgerCost;
            RecalSubTotal();
        }

        private void baconCheeseBurgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectBurgerToolStripMenuItem.Text = baconCheeseBurgerToolStripMenuItem.Text;
            string writer = BaconBurgerCost.ToString("C");
            costLblBurger.Text = $"{writer}";
            activeBurger = BaconBurgerCost;
            RecalSubTotal();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SelectFriestoolStripMenuItem.Visible = chkFries.Checked;
            activeFrie = 0;
            costLblFries.Text = "$0.00";
            SelectFriestoolStripMenuItem.Text = "(Select a Size)";
            RecalSubTotal();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SelectFriestoolStripMenuItem.Text = toolStripMenuItem2.Text;
            string writer = friesSmall.ToString("C");
            costLblFries.Text = $"{writer}";
            activeFrie = friesSmall;
            RecalSubTotal();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SelectFriestoolStripMenuItem.Text = toolStripMenuItem3.Text;
            string writer = friesMedium.ToString("C");
            costLblFries.Text = $"{writer}";
            activeFrie = friesMedium;
            RecalSubTotal();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SelectFriestoolStripMenuItem.Text = toolStripMenuItem4.Text;
            string writer = friesLarge.ToString("C");
            costLblFries.Text = $"{writer}";
            activeFrie = friesLarge;
            RecalSubTotal();
        }

        private void chkDrink_CheckedChanged(object sender, EventArgs e)
        {
            selectDrinkSizeToolStripMenuItem.Visible = chkDrink.Checked;
            selectDrinkToolStripMenuItem8.Visible = chkDrink.Checked;
            activeDrink = 0;
            costLblDrink.Text = "$0.00";
            selectDrinkSizeToolStripMenuItem.Text = "(Select a Size)";
            RecalSubTotal();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            selectDrinkSizeToolStripMenuItem.Text = toolStripMenuItem5.Text;
            string writer = drinkSmall.ToString("C");
            costLblDrink.Text = $"{writer}";
            activeDrink = drinkSmall;
            RecalSubTotal();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            selectDrinkSizeToolStripMenuItem.Text = toolStripMenuItem6.Text;
            string writer = drinkMedium.ToString("C");
            costLblDrink.Text = $"{writer}";
            activeDrink = drinkMedium;
            RecalSubTotal();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            selectDrinkSizeToolStripMenuItem.Text = toolStripMenuItem7.Text;
            string writer = drinkLarge.ToString("C");
            costLblDrink.Text = $"{writer}";
            activeDrink = drinkLarge;
            RecalSubTotal();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            selectDrinkToolStripMenuItem8.Text = toolStripMenuItem9.Text;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            selectDrinkToolStripMenuItem8.Text = toolStripMenuItem10.Text;
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            selectDrinkToolStripMenuItem8.Text= toolStripMenuItem11.Text;
        }

        private void waterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectDrinkToolStripMenuItem8.Text = waterToolStripMenuItem.Text;
            WaterCheck();
        }
    }
}
