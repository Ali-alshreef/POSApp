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
            Active(false);
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
    }
}