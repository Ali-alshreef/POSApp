using POSApp.Data;
using POSApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSApp.Forms
{
    public partial class FrmEditItem : FrmBase // : Form
    {
        POSAppDB db = new POSAppDB();
        public FrmEditItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Product p = new Product();
                p.ItemName = txtItemName.Text;
                p.Barcode = txtBarcode.Text;
                p.Price = NUDPrice.Value;
                db.Products.Add(p);
            }
            catch (Exception)
            {
                MessageBox.Show("يجب ادخال ارقام فقط");
            }
        }

        private void FrmEditItem_Load(object sender, EventArgs e)
        {
            Active(true);
            txtBarcode.Focus();
            button1.Enabled = false;
            button2.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Active(true);
        }

        void Active(bool c)
        {
            txtItemName.Enabled = c;
            NUDPrice.Enabled = c;
            button1.Enabled = c;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmEditItem_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.BackColor == Color.Red)
            {
                this.BackColor = Color.White;
            }
            else if (this.BackColor == Color.White)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.Red;
            }
        }

        private void FrmEditItem_FormClosing(object sender, FormClosingEventArgs e)
        {

            //MessageBox.Show("هل انت متأكد من الاغلاق");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.White;
        }
    }
}