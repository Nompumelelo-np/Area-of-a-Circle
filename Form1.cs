using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_of_a_Circle
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
            const double PI = 3.14;
            double r ;
            double A ;

            r = double.Parse(textBox1.Text);

            A = (PI * r *r);


            textBox2.Text = A.ToString();
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
