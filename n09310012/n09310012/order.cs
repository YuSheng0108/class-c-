using System.IO;
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
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
            if (!File.Exists("OrderDate.csv"))
                File.WriteAllText("OrderDate.csv", "時間,餐點,飲料\n", Encoding.UTF8);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            string formattedDateTime = currentDateTime.ToString("yyyy/MM/dd HH:mm");



            List<string> MenuA = new List<string>();
            
            if (checkBox1.Checked)
            {
                MenuA.Add(checkBox1.Text);
            }
            if (checkBox2.Checked)
            {
                MenuA.Add(checkBox2.Text);
            }
            if (checkBox3.Checked)
            {
                MenuA.Add(checkBox3.Text);
            }
            if (checkBox4.Checked)
            {
                MenuA.Add(checkBox4.Text);
            }
            if (checkBox5.Checked)
            {
                MenuA.Add(checkBox5.Text);
            }

            List<string> MenuB = new List<string>();

            if (checkBox6.Checked)
            {
                MenuB.Add(checkBox6.Text);
            }
            if (checkBox7.Checked)
            {
                MenuB.Add(checkBox7.Text);
            }
            if (checkBox8.Checked)
            {
                MenuB.Add(checkBox8.Text);
            }
            if (checkBox9.Checked)
            {
                MenuB.Add(checkBox9.Text);
            }
            if (checkBox10.Checked)
            {
                MenuB.Add(checkBox10.Text);
            }
            string filePeth = @"C:\Users\s9500\Desktop\class-c-\nOrderDate.csv";

            using (StreamWriter writer = new StreamWriter(filePeth, true, Encoding.UTF8))
            {
                if (writer.BaseStream.Length == 0)
                {
                    writer.WriteLine("時間,餐點,飲品");
                }
                foreach (string item in MenuA)
                {
                    writer.WriteLine($"{formattedDateTime}, 餐點,{item},");
                }
                foreach (string item in MenuB)
                {
                    writer.WriteLine($"{formattedDateTime}, 飲品,{item}");
                }
            }
            
            MessageBox.Show("餐點:" + MenuA[0] + Environment.NewLine  + "飲品:" + MenuB[0] , "請確認餐點");


        }

        private void Food_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Drink_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}