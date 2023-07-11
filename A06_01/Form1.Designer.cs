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
            this.SelectBurgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.burgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheeseBurgerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.baconCheeseBurgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkBurger = new System.Windows.Forms.CheckBox();
            this.costLblBurger = new System.Windows.Forms.Label();
            this.SubtotalLbl = new System.Windows.Forms.Label();
            this.costLblFries = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.SelectFriestoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.chkFries = new System.Windows.Forms.CheckBox();
            this.subOutLbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
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
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(4);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectBurgerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(362, 232);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(202, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
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
            // chkBurger
            // 
            this.chkBurger.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkBurger.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBurger.Location = new System.Drawing.Point(25, 232);
            this.chkBurger.Name = "chkBurger";
            this.chkBurger.Size = new System.Drawing.Size(1035, 65);
            this.chkBurger.TabIndex = 4;
            this.chkBurger.Text = "Add Burger";
            this.chkBurger.UseVisualStyleBackColor = false;
            this.chkBurger.CheckedChanged += new System.EventHandler(this.chkBurger_CheckedChanged);
            // 
            // costLblBurger
            // 
            this.costLblBurger.AutoSize = true;
            this.costLblBurger.BackColor = System.Drawing.Color.WhiteSmoke;
            this.costLblBurger.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLblBurger.Location = new System.Drawing.Point(892, 239);
            this.costLblBurger.Name = "costLblBurger";
            this.costLblBurger.Size = new System.Drawing.Size(151, 51);
            this.costLblBurger.TabIndex = 5;
            this.costLblBurger.Text = "Burger";
            // 
            // SubtotalLbl
            // 
            this.SubtotalLbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SubtotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtotalLbl.Location = new System.Drawing.Point(1009, 1003);
            this.SubtotalLbl.Name = "SubtotalLbl";
            this.SubtotalLbl.Size = new System.Drawing.Size(426, 76);
            this.SubtotalLbl.TabIndex = 6;
            this.SubtotalLbl.Text = "Subtotal :";
            this.SubtotalLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // costLblFries
            // 
            this.costLblFries.AutoSize = true;
            this.costLblFries.BackColor = System.Drawing.Color.WhiteSmoke;
            this.costLblFries.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLblFries.Location = new System.Drawing.Point(892, 374);
            this.costLblFries.Name = "costLblFries";
            this.costLblFries.Size = new System.Drawing.Size(118, 51);
            this.costLblFries.TabIndex = 9;
            this.costLblFries.Text = "Fries";
            this.costLblFries.Click += new System.EventHandler(this.label2_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectFriestoolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(362, 367);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(202, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // SelectFriestoolStripMenuItem
            // 
            this.SelectFriestoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.SelectFriestoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFriestoolStripMenuItem.Name = "SelectFriestoolStripMenuItem";
            this.SelectFriestoolStripMenuItem.Size = new System.Drawing.Size(265, 54);
            this.SelectFriestoolStripMenuItem.Text = "(Select a Size)";
            this.SelectFriestoolStripMenuItem.Visible = false;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(359, 58);
            this.toolStripMenuItem2.Text = "Small";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(359, 58);
            this.toolStripMenuItem3.Text = "Medium";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(359, 58);
            this.toolStripMenuItem4.Text = "Large";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // chkFries
            // 
            this.chkFries.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkFries.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFries.Location = new System.Drawing.Point(25, 367);
            this.chkFries.Name = "chkFries";
            this.chkFries.Size = new System.Drawing.Size(1035, 65);
            this.chkFries.TabIndex = 8;
            this.chkFries.Text = "Add Fries";
            this.chkFries.UseVisualStyleBackColor = false;
            this.chkFries.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // subOutLbl
            // 
            this.subOutLbl.AutoSize = true;
            this.subOutLbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.subOutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subOutLbl.Location = new System.Drawing.Point(1300, 1027);
            this.subOutLbl.Name = "subOutLbl";
            this.subOutLbl.Size = new System.Drawing.Size(92, 51);
            this.subOutLbl.TabIndex = 10;
            this.subOutLbl.Text = "test";
            this.subOutLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1579, 1246);
            this.Controls.Add(this.subOutLbl);
            this.Controls.Add(this.costLblFries);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.SubtotalLbl);
            this.Controls.Add(this.costLblBurger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.chkBurger);
            this.Controls.Add(this.chkFries);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
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
        private System.Windows.Forms.Label SubtotalLbl;
        private System.Windows.Forms.Label costLblFries;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem SelectFriestoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.CheckBox chkFries;
        private System.Windows.Forms.Label subOutLbl;
    }
}

