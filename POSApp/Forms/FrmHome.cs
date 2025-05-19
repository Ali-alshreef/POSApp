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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }
        FrmEditItem frmEditItem;
        private void MnuItemAdd_Click(object sender, EventArgs e)
        {
            frmEditItem = new FrmEditItem();
            frmEditItem.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Select(3, 5);
            string x = textBox1.Text.Substring(3, 5);
            //textBox1.Copy();
            textBox1.Cut();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool c = checkBox1.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool c = checkBox1.Checked;
        }
    }
}
