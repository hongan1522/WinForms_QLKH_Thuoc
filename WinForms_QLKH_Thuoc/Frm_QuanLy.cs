﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormQLKH
{
    public partial class Frm_QuanLy : Form
    {
        public Frm_QuanLy()
        {
            InitializeComponent();
        }
        private void FrmQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
