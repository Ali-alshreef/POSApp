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
            label2 = new Label();
            txtPrice = new TextBox();
            button1 = new Button();
            NUDPrice = new NumericUpDown();
            button2 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)NUDPrice).BeginInit();
            SuspendLayout();
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(125, 61);
            txtItemName.Margin = new Padding(4);
            txtItemName.Name = "txtItemName";
            txtItemName.PlaceholderText = "ادخل إسم الصنف";
            txtItemName.Size = new Size(243, 26);
            txtItemName.TabIndex = 0;
            txtItemName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 64);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 18);
            label1.TabIndex = 1;
            label1.Text = "إسم الصنف";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 121);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 18);
            label2.TabIndex = 3;
            label2.Text = "السعر";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(125, 118);
            txtPrice.Margin = new Padding(4);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "ادخل السعر";
            txtPrice.Size = new Size(243, 26);
            txtPrice.TabIndex = 2;
            txtPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(293, 230);
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
            NUDPrice.Location = new Point(137, 165);
            NUDPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            NUDPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUDPrice.Name = "NUDPrice";
            NUDPrice.Size = new Size(231, 26);
            NUDPrice.TabIndex = 5;
            NUDPrice.TextAlign = HorizontalAlignment.Center;
            NUDPrice.ThousandsSeparator = true;
            NUDPrice.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // button2
            // 
            button2.Location = new Point(164, 230);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 6;
            button2.Text = "جديد";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 173);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(34, 18);
            label3.TabIndex = 7;
            label3.Text = "السعر";
            // 
            // FrmEditItem
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 317);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(NUDPrice);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtPrice);
            Controls.Add(label1);
            Controls.Add(txtItemName);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmEditItem";
            Text = "FrmEditItem";
            Load += FrmEditItem_Load;
            ((System.ComponentModel.ISupportInitialize)NUDPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtItemName;
        private Label label1;
        private Label label2;
        private TextBox txtPrice;
        private Button button1;
        private NumericUpDown NUDPrice;
        private Button button2;
        private Label label3;
    }
}