using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarAtmaUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
        }
        int counter = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int dice1, dice2;
            Random rnd = new Random();
            dice1 = rnd.Next(0, 6);
            dice2 = rnd.Next(0, 6);
            pictureBox1.Image = ımageList1.Images[dice1];
            pictureBox2.Image = ımageList1.Images[dice2];
            counter++;
            if (counter == 5)
            {
                timer1.Stop();
                counter = 0;
                button1.Enabled = true;
            }
        }
    }
}
