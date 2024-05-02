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
            timer1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }



        private void restart_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Stop")
            {
               button1.Text = "Start";
                timer1.Enabled = false;
            }
            else
            {
                button1.Text = "Stop";
                timer1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int second;
            label1.Text = String.Format("{0}秒", this.second);
            this.second++;
        }
    }
}
