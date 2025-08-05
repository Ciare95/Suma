using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String seleccion1 = textBox1.Text;
            int numero1 = Convert.ToInt32(seleccion1);

            String seleccio2 = textBox2.Text;
            int numero2 = Convert.ToInt32(seleccio2);

            int resultado = numero1 + numero2;

            MessageBox.Show(resultado.ToString());
        }
    }
}
