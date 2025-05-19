namespace POSApp.Forms
{
    partial class FrmEditItem
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
            txtItemName = new TextBox();
            label1 = new Label();
            button1 = new Button();
            NUDPrice = new NumericUpDown();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            txtBarcode = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)NUDPrice).BeginInit();
            SuspendLayout();
            // 
            // txtItemName
            // 
            txtItemName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtItemName.Location = new Point(125, 53);
            txtItemName.Margin = new Padding(4);
            txtItemName.MaxLength = 5;
            txtItemName.Name = "txtItemName";
            txtItemName.PlaceholderText = "ادخل إسم الصنف";
            txtItemName.Size = new Size(272, 26);
            txtItemName.TabIndex = 0;
            txtItemName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(33, 61);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 18);
            label1.TabIndex = 1;
            label1.Text = "إسم الصنف";
            label1.MouseLeave += label1_MouseLeave;
            label1.MouseHover += label1_MouseHover;
            // 
            // button1
            // 
            button1.Location = new Point(280, 230);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 4;
            button1.Text = "حفظ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NUDPrice
            // 
            NUDPrice.DecimalPlaces = 3;
            NUDPrice.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            NUDPrice.Location = new Point(125, 111);
            NUDPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            NUDPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUDPrice.Name = "NUDPrice";
            NUDPrice.Size = new Size(260, 26);
            NUDPrice.TabIndex = 5;
            NUDPrice.TextAlign = HorizontalAlignment.Center;
            NUDPrice.ThousandsSeparator = true;
            NUDPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button2
            // 
            button2.Font = new Font("Bold Italic Art", 18F, FontStyle.Regular, GraphicsUnit.Point, 178);
            button2.Image = Properties.Resources.Addicon;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(82, 199);
            button2.Name = "button2";
            button2.Size = new Size(159, 75);
            button2.TabIndex = 6;
            button2.Text = "جديد";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 119);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(34, 18);
            label3.TabIndex = 7;
            label3.Text = "السعر";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 169);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 18);
            label4.TabIndex = 9;
            label4.Text = "الباركود";
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(125, 166);
            txtBarcode.Margin = new Padding(4);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.PlaceholderText = "الباركود";
            txtBarcode.Size = new Size(272, 26);
            txtBarcode.TabIndex = 8;
            txtBarcode.TextAlign = HorizontalAlignment.Center;
            // 
            // button3
            // 
            button3.Location = new Point(411, 12);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // FrmEditItem
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(508, 283);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(txtBarcode);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(NUDPrice);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtItemName);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4);
            Name = "FrmEditItem";
            Text = "fgytyt";
            FormClosing += FrmEditItem_FormClosing;
            Load += FrmEditItem_Load;
            MouseClick += FrmEditItem_MouseClick;
            ((System.ComponentModel.ISupportInitialize)NUDPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtItemName;
        private Label label1;
        private Button button1;
        private NumericUpDown NUDPrice;
        private Button button2;
        private Label label3;
        private Label label4;
        private TextBox txtBarcode;
        private Button button3;
    }
}