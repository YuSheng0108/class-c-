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
            string formattedDateTime =currentDateTime.ToString("yyyy/MM/dd HH:mm");
            File.AppendAllText("OrderDate.csv", formattedDateTime + "," + food + "," + drink + "\n", Encoding.UTF8);

            MessageBox.Show("餐點:" + food + Environment.NewLine + "飲料:" + drink, "請確認餐點");

        }

        private void Food_Paint(object sender, PaintEventArgs e)
        {
            foreach (Control c in food.Controls)
            {
                if (c is checkbox)
                {
                    if (((checkbox)c).Checked == true)
                    {
                        
                    }
                }
            }
        }

        private void Drink_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
