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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            button3 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button4 = new Button();
            checkBox2 = new CheckBox();
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
            MnuItemAdd.Size = new Size(151, 38);
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
            // button1
            // 
            button1.Location = new Point(499, 114);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "copy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.CharacterCasing = CharacterCasing.Upper;
            textBox1.Location = new Point(217, 114);
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(228, 23);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 252);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // button2
            // 
            button2.Location = new Point(516, 248);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "لصق";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.CharacterCasing = CharacterCasing.Upper;
            textBox2.Location = new Point(195, 187);
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Both;
            textBox2.Size = new Size(228, 23);
            textBox2.TabIndex = 5;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(58, 121);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(50, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "1111";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button3
            // 
            button3.Location = new Point(58, 156);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "check Value";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(178, 312);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(329, 312);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(195, 345);
            button4.Name = "button4";
            button4.Size = new Size(155, 23);
            button4.TabIndex = 10;
            button4.Text = "Radiobutton Value";
            button4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(58, 85);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(50, 19);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "2222";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(679, 380);
            Controls.Add(checkBox2);
            Controls.Add(button4);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button3);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
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
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Button button3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button4;
        private CheckBox checkBox2;
    }
}