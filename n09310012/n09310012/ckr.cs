using System;
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
    public partial class ckr : Form
    {
        public ckr()
        {
            InitializeComponent();
        }

        private void zoo_Click(object sender, EventArgs e)
        {
            Form zoo = new Form1();
            zoo.Show();
        }
    }
}
