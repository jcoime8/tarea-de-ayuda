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
    public partial class Serie : Form
    {
        public Serie()
        {
            InitializeComponent();
        }
        SerieF tres = new SerieF();
    
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Join(" - ", tres.serieF(Convert.ToInt32(textBox1.Text)));
        }
    }
}
