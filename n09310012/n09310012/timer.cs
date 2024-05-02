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
    public partial class timer : Form
    {
        int second;
        public timer()
        {
            InitializeComponent();
            this.second = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void start_Click(object sender, EventArgs e)
        {
            int second;
            label1.Text = String.Format("{0}秒", this.second);
            this.second++;
        }

        private void restart_Click(object sender, EventArgs e)
        {
            if (start.Text == "Stop")
            {
                start.Text = "Start";
                timer1.Enabled = true;
            }
            else
            {
                start.Text = "Stop";
                timer1.Enabled = false;
            }
        }
    }
}
