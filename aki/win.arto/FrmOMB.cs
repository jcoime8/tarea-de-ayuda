using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_aki;

namespace win.arto
{
    public partial class FrmOMB : Form
    {
        public FrmOMB()
        {
            InitializeComponent();
        }
        ClsOMB omb = new ClsOMB();
        private void button1_Click(object sender, EventArgs e)
        {
            omb.N11 = Convert.ToDouble(textBox1.Text);
            omb.N21 = Convert.ToDouble(textBox2.Text);
            MessageBox.Show("El resultado es: " + omb.suma());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            omb.N11 = Convert.ToDouble(textBox1.Text);
            omb.N21 = Convert.ToDouble(textBox2.Text);
            MessageBox.Show("El resultado es: " + omb.resta());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            omb.N11 = Convert.ToDouble(textBox1.Text);
            omb.N21 = Convert.ToDouble(textBox2.Text);
            MessageBox.Show("El resultado es " + omb.multiplicar());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            omb.N11 = Convert.ToDouble(textBox1.Text);
            omb.N21 = Convert.ToDouble(textBox2.Text);
            MessageBox.Show("El resultado es: " + omb.dividir());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
