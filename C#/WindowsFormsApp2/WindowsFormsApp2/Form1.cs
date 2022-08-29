using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amt;
            double.TryParse(textBox1.Text, out amt);
            textBox2.Text = (amt * 0.050).ToString("c2");
            double.TryParse(textBox1.Text, out amt);
            textBox3.Text = (amt * 1.00).ToString("c2");
            double.TryParse(textBox1.Text, out amt);
            textBox4.Text = (amt * .20).ToString("c2");
            double.TryParse(textBox1.Text, out amt);
            textBox5.Text = (amt * .51).ToString("c2");
            double.TryParse(textBox1.Text, out amt);
            textBox6.Text = (amt * .71).ToString("c2");
            double.TryParse(textBox1.Text, out amt);
            textBox7.Text = (amt * .04).ToString("c2");
        }
    }
}
