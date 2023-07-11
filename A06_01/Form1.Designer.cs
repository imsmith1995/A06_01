namespace A06_01
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chkBurger = new System.Windows.Forms.CheckBox();
            this.SelectBurgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.burgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheeseBurgerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.baconCheeseBurgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costLblBurger = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1555, 90);
            this.label1.TabIndex = 2;
            this.label1.Text = "Best Burgers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectBurgerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(665, 261);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(557, 58);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chkBurger
            // 
            this.chkBurger.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkBurger.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBurger.Location = new System.Drawing.Point(160, 261);
            this.chkBurger.Name = "chkBurger";
            this.chkBurger.Size = new System.Drawing.Size(1275, 65);
            this.chkBurger.TabIndex = 4;
            this.chkBurger.Text = "Add Burger";
            this.chkBurger.UseVisualStyleBackColor = false;
            this.chkBurger.CheckedChanged += new System.EventHandler(this.chkBurger_CheckedChanged);
            // 
            // SelectBurgerToolStripMenuItem
            // 
            this.SelectBurgerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.burgerToolStripMenuItem,
            this.cheeseBurgerToolStripMenuItem1,
            this.baconCheeseBurgerToolStripMenuItem});
            this.SelectBurgerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectBurgerToolStripMenuItem.Name = "SelectBurgerToolStripMenuItem";
            this.SelectBurgerToolStripMenuItem.Size = new System.Drawing.Size(309, 54);
            this.SelectBurgerToolStripMenuItem.Text = "(Select a Burger)";
            this.SelectBurgerToolStripMenuItem.Visible = false;
            this.SelectBurgerToolStripMenuItem.Click += new System.EventHandler(this.cheeseBurgerToolStripMenuItem_Click);
            // 
            // burgerToolStripMenuItem
            // 
            this.burgerToolStripMenuItem.Name = "burgerToolStripMenuItem";
            this.burgerToolStripMenuItem.Size = new System.Drawing.Size(509, 58);
            this.burgerToolStripMenuItem.Text = "Burger";
            this.burgerToolStripMenuItem.Click += new System.EventHandler(this.burgerToolStripMenuItem_Click);
            // 
            // cheeseBurgerToolStripMenuItem1
            // 
            this.cheeseBurgerToolStripMenuItem1.Name = "cheeseBurgerToolStripMenuItem1";
            this.cheeseBurgerToolStripMenuItem1.Size = new System.Drawing.Size(509, 58);
            this.cheeseBurgerToolStripMenuItem1.Text = "Cheese Burger";
            this.cheeseBurgerToolStripMenuItem1.Click += new System.EventHandler(this.cheeseBurgerToolStripMenuItem1_Click);
            // 
            // baconCheeseBurgerToolStripMenuItem
            // 
            this.baconCheeseBurgerToolStripMenuItem.Name = "baconCheeseBurgerToolStripMenuItem";
            this.baconCheeseBurgerToolStripMenuItem.Size = new System.Drawing.Size(509, 58);
            this.baconCheeseBurgerToolStripMenuItem.Text = "Bacon Cheese Burger";
            this.baconCheeseBurgerToolStripMenuItem.Click += new System.EventHandler(this.baconCheeseBurgerToolStripMenuItem_Click);
            // 
            // costLblBurger
            // 
            this.costLblBurger.AutoSize = true;
            this.costLblBurger.BackColor = System.Drawing.Color.WhiteSmoke;
            this.costLblBurger.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLblBurger.Location = new System.Drawing.Point(1284, 268);
            this.costLblBurger.Name = "costLblBurger";
            this.costLblBurger.Size = new System.Drawing.Size(138, 51);
            this.costLblBurger.TabIndex = 5;
            this.costLblBurger.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1579, 1246);
            this.Controls.Add(this.costLblBurger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.chkBurger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.CheckBox chkBurger;
        private System.Windows.Forms.ToolStripMenuItem SelectBurgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem burgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheeseBurgerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem baconCheeseBurgerToolStripMenuItem;
        private System.Windows.Forms.Label costLblBurger;
    }
}

