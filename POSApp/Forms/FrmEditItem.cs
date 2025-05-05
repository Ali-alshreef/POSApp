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
        public FrmEditItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtItemName.Text;
                decimal price = Convert.ToDecimal(txtPrice.Text);
                decimal priceValue = NUDPrice.Value;
            }
            catch (Exception)
            {
                MessageBox.Show("يجب ادخال ارقام فقط");
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtPrice.Enabled = c;
            NUDPrice.Enabled = c;
            button1.Enabled = c;
        }
    }
}