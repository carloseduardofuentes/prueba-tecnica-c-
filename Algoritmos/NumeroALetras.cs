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
    public partial class NumeroALetras : Form
    {
        public NumeroALetras()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            int numeroNivel1 = 0;
            int numeroNivel2 = 0;
            int numeroNivel3 = 0;

            if (numero < 10)
            {
                txtLetras.Text = unoAlNueve(numero);
            }
            else if (numero < 100)
            {
                numeroNivel2 = (numero / 10) * 10; // Obtener la decena

                numeroNivel1 = numero % 10; // Obtener unidad

                if (numero == numeroNivel2)
                    txtLetras.Text = decena(numeroNivel2);
                else
                    txtLetras.Text = decena(numeroNivel2) + " y " + unoAlNueve(numeroNivel1);
            }
            else if (numero < 1000)
            {
                numeroNivel3 = (numero / 100) * 100; // Obtener la centena

                numeroNivel2 = ((numero - numeroNivel3) / 10) * 10; // Obtener la decena

                numeroNivel1 = numero % 10; // Obtener unidad

                if (numero == numeroNivel3)
                    txtLetras.Text = centena(numeroNivel3);
                else if (numero == (numeroNivel3 + numeroNivel2))
                    txtLetras.Text = centena(numeroNivel3) + " " + decena(numeroNivel2);
                else
                    txtLetras.Text = centena(numeroNivel3) + " " + decena(numeroNivel2) + " y " + unoAlNueve(numeroNivel1);
            }
        }

        private string unoAlNueve(int numero)
        {
            string resultado = string.Empty;
            switch(numero)
            {
                case 1:
                    resultado = "uno";
                    break;
                case 2:
                    resultado = "dos";
                    break;
                case 3:
                    resultado = "tres";
                    break;
                case 4:
                    resultado = "cuatro";
                    break;
                case 5:
                    resultado = "cinco";
                    break;
                case 6:
                    resultado = "seis";
                    break;
                case 7:
                    resultado = "siete";
                    break;
                case 8:
                    resultado = "ocho";
                    break;
                case 9:
                    resultado = "nueve";
                    break;
            }

            return resultado;
        }

        private string decena(int numero)
        {
            string resultado = string.Empty;
            switch (numero)
            {
                case 10:
                    resultado = "diez";
                    break;
                case 20:
                    resultado = "veinte";
                    break;
                case 30:
                    resultado = "treinta";
                    break;
                case 40:
                    resultado = "cuarenta";
                    break;
                case 50:
                    resultado = "cincuenta";
                    break;
                case 60:
                    resultado = "sesenta";
                    break;
                case 70:
                    resultado = "setenta";
                    break;
                case 80:
                    resultado = "ochenta";
                    break;
                case 90:
                    resultado = "noventa";
                    break;
            }

            return resultado;
        }

        private string centena(int numero)
        {
            string resultado = string.Empty;
            switch (numero)
            {
                case 100:
                    resultado = "ciento";
                    break;
                case 200:
                    resultado = "doscientos";
                    break;
                case 300:
                    resultado = "trecientos";
                    break;
                case 400:
                    resultado = "cuatrocientos";
                    break;
                case 500:
                    resultado = "quinientos";
                    break;
                case 600:
                    resultado = "seiscientos";
                    break;
                case 700:
                    resultado = "sietecientos";
                    break;
                case 800:
                    resultado = "ochocientos";
                    break;
                case 900:
                    resultado = "novecientos";
                    break;
            }

            return resultado;
        }
    }
}
