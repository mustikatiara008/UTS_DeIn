using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perhitungan_volumebangunbalok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Double p, l, t, v;

        private void button1_Click(object sender, EventArgs e)
        {
            p = Convert.ToDouble(textBox1.Text);
            l = Convert.ToDouble(textBox2.Text);
            t = Convert.ToDouble(textBox3.Text);
            v = p * l * t;

            textBox4.Text = v.ToString();
        }
    }
}
