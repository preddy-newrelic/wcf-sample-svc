using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.MathServiceClient _obj = new ServiceReference1.MathServiceClient("BasicHttpBinding_IMathService");
            label3.Text = _obj.Addition(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
