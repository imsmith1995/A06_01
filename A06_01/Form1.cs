﻿using System;
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
        public double subtotal = 0;
        public double total = 0;

        public double regularBurgerCost = 4.00;
        public double CheeseBurgerCost = 4.50;
        public double BaconBurgerCost = 5.50;

        public double friesSmall = 1.50;
        public double friesMedium = 2.00;
        public double friesLarge = 2.50;

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
        }

        private void burgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectBurgerToolStripMenuItem.Text = burgerToolStripMenuItem.Text;
            string writer = regularBurgerCost.ToString("C");
            costLblBurger.Text = $"{writer}";
        }

        private void cheeseBurgerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SelectBurgerToolStripMenuItem.Text = cheeseBurgerToolStripMenuItem1.Text;
            string writer = CheeseBurgerCost.ToString("C");
            costLblBurger.Text = $"{writer}";
        }

        private void baconCheeseBurgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectBurgerToolStripMenuItem.Text = baconCheeseBurgerToolStripMenuItem.Text;
            string writer = BaconBurgerCost.ToString("C");
            costLblBurger.Text = $"{writer}";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SelectFriestoolStripMenuItem.Visible = chkFries.Checked;
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
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SelectFriestoolStripMenuItem.Text = toolStripMenuItem3.Text;
            string writer = friesMedium.ToString("C");
            costLblFries.Text = $"{writer}";
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SelectFriestoolStripMenuItem.Text = toolStripMenuItem4.Text;
            string writer = friesLarge.ToString("C");
            costLblFries.Text = $"{writer}";
        }

    }
}
