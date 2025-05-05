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
            catch(Exception)
            {
                MessageBox.Show("خطأ يجل ادخال ارقام فقط في حقل السعر");
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
