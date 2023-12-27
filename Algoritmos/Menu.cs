using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Postfijo postfijo = new Postfijo();
            postfijo.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumeroALetras numeroALetras = new NumeroALetras();
            numeroALetras.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            string mensaje = string.Empty;
            Clase clase = new Clase();
            resultado = clase.Sumar2Num(out mensaje);
            MessageBox.Show(resultado.ToString() + " Numeros encontrados: " + mensaje);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            string mensaje = string.Empty;
            Clase clase = new Clase();
            resultado = clase.Suma2NumOptimizada(out mensaje);
            MessageBox.Show(resultado.ToString() + " Numeros encontrados: " + mensaje);
        }
    }
}
