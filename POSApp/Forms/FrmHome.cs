﻿using System;
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

        private void MnuItemAdd_Click(object sender, EventArgs e)
        {
           FrmEditItem frmEditItem = new FrmEditItem();
           frmEditItem.ShowDialog();
        }
    }
}
