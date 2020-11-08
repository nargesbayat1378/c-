using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poroject_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTimeText_Click(object sender, EventArgs e)
        {
            time T1 = new time();
            label1.Text = T1.ToString();
            time T2 = new time(15,20,10);
            label1.Text += "\nT2="+T2.ToString();
            time T3 = new time(14,5);
            label1.Text += "\nT3=" + T3.ToString();
            time T4 = new time(12);
            label1.Text += "\nT4=" + T4.ToString();
            
        }
        time T6;
        private int x;
        private void btnset_Click(object sender, EventArgs e)
        {

            T6 = new time(8, 30, 15);
            label2.Text="whit parametric constructor"+T6.ToString();

            int h = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);
            int s = Convert.ToInt32(textBox3.Text);

            T6.SetTime(h, m, s);
            label2.Text +="\nafter   "+T6.ToString();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
           // T6.increment();
            T6++;
            label5.Text=
            T6.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //T6.dcrement();
            T6--;
            label6.Text =
            T6.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt16(textBox4.Text);
           // T6.add(n);
            time t = new time();
           // t = T6 + n;
            t = n + T6;
            label7.Text =
            t.ToString();
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt16(textBox4.Text);
            time t = new time();
            t =T6-n;
            label8.Text =
            t.ToString();
        }
       

    }
}
