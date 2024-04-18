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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void abcde_Click(object sender, EventArgs e)
        {
            if (label4.Text == "請按我一下")
                label4.Text = "我已經被按過了";

            else if (label4.Text == "我已經被按過了")
                label4.Text = "請按我一下";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void puls1_Click(object sender, EventArgs e)
        {
            String count = number.Text;
            int sum = Int32.Parse(count)+1;
            number.Text = sum.ToString();
        }

        private void number_Click(object sender, EventArgs e)
        {

        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            
        }

        private void HW10_Click(object sender, EventArgs e)
        {
            int height = HW10.Height;
            int width = HW10.Width;
            HW10.Size = new Size(height + 10, height + 10);
        }

        private void cher_Click(object sender, EventArgs e)
        {
            Form cher = new ckr();
            cher.Show();
        }

        private void m1_Click(object sender, EventArgs e)
        {
            String count = number.Text;
            int sum = Int32.Parse(count) - 1;
            number.Text = sum.ToString();
        }

        private void count_Click(object sender, EventArgs e)
        {
            Form cher = new text32();
            cher.Show();
        }

        private void mid_Click(object sender, EventArgs e)
        {
            Form mid = new midtest();
            mid.Show();
        }
    }
}
