using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace n09310012
{
    public partial class midtest : Form
    {
        public midtest()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void trefson_Click(object sender, EventArgs e)
        {
            double c = double.Parse(Center.Text);
            double f = (c * (9.0 / 5.0) + 32);
            label2.Text = f.ToString()+"度F";
        }
    }
}
