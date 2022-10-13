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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        ClsLogin ini = new ClsLogin();
        private void button1_Click(object sender, EventArgs e) //Primera clase: LOGIN
        {
            if (ini.nuevo(textBox1.Text, textBox2.Text) == true) 
            {
                MessageBox.Show("Clave correcta");
                MDIPresentacion presentar = new MDIPresentacion();
                presentar.Show();
            }
            else
            {
                MessageBox.Show("Clave incorrecta");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
