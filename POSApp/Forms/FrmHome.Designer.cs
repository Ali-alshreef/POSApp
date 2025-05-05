namespace POSApp.Forms
{
    partial class FrmHome
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
            menuStrip1 = new MenuStrip();
            الأصنافToolStripMenuItem = new ToolStripMenuItem();
            MnuItemAdd = new ToolStripMenuItem();
            العملاءToolStripMenuItem = new ToolStripMenuItem();
            إضافةعميلToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { الأصنافToolStripMenuItem, العملاءToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(679, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // الأصنافToolStripMenuItem
            // 
            الأصنافToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuItemAdd });
            الأصنافToolStripMenuItem.Image = Properties.Resources.productshow;
            الأصنافToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            الأصنافToolStripMenuItem.Name = "الأصنافToolStripMenuItem";
            الأصنافToolStripMenuItem.Size = new Size(95, 36);
            الأصنافToolStripMenuItem.Text = "الأصناف ";
            // 
            // MnuItemAdd
            // 
            MnuItemAdd.Image = Properties.Resources.Custom_Icon_Design_Flatastic_4_Package_add;
            MnuItemAdd.ImageScaling = ToolStripItemImageScaling.None;
            MnuItemAdd.Name = "MnuItemAdd";
            MnuItemAdd.Size = new Size(196, 38);
            MnuItemAdd.Text = "إضافة صنف";
            MnuItemAdd.Click += MnuItemAdd_Click;
            // 
            // العملاءToolStripMenuItem
            // 
            العملاءToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { إضافةعميلToolStripMenuItem });
            العملاءToolStripMenuItem.Name = "العملاءToolStripMenuItem";
            العملاءToolStripMenuItem.Size = new Size(52, 36);
            العملاءToolStripMenuItem.Text = "العملاء";
            // 
            // إضافةعميلToolStripMenuItem
            // 
            إضافةعميلToolStripMenuItem.Name = "إضافةعميلToolStripMenuItem";
            إضافةعميلToolStripMenuItem.Size = new Size(133, 22);
            إضافةعميلToolStripMenuItem.Text = "إضافة عميل";
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(679, 371);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmHome";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmHome";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem الأصنافToolStripMenuItem;
        private ToolStripMenuItem MnuItemAdd;
        private ToolStripMenuItem العملاءToolStripMenuItem;
        private ToolStripMenuItem إضافةعميلToolStripMenuItem;
    }
}