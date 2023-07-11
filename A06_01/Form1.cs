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
            costLblBurger.Text = "$2.00";
        }

        private void cheeseBurgerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SelectBurgerToolStripMenuItem.Text = cheeseBurgerToolStripMenuItem1.Text;
            costLblBurger.Text = "$2.50";
        }

        private void baconCheeseBurgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectBurgerToolStripMenuItem.Text = baconCheeseBurgerToolStripMenuItem.Text;
            costLblBurger.Text = "$3.50";
        }
    }
}
