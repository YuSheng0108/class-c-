﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n09310012
{
    public partial class checkbox : Form
    {
        public checkbox()
        {
            InitializeComponent();
        }

        public bool Checked { get; internal set; }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                MessageBox.Show(checkBox1.Text + "已被按下");
        }

        private void checkbox_Load(object sender, EventArgs e)
        {

        }
    }
}
