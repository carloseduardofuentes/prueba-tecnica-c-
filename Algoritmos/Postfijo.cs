using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos
{
    public partial class Postfijo : Form
    {
        static private Stack<string> pila = new Stack<string>();        
        List<string> ListaExpresionInfija = new List<string>();
        public Postfijo()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            string expresionInfija = txtExpresionInfija.Text;

            string expresionPostfija = "";

            int precedenciaPila = 0;

            int precedenciaExpresion = 0;

            int numero = 0;

            if(convertirALista(expresionInfija, out ListaExpresionInfija))
            {
                foreach (string x in ListaExpresionInfija)
                {
                    if (Int32.TryParse(x, out numero))
                    {
                        expresionPostfija += x + " ";
                    }
                    else if (x == "(")
                    {
                        pila.Push(x.ToString());
                    }
                    else if (x == "+" || x == "-" || x == "*" || x == "/" || x == "^")
                    {
                        if (pila.Count > 0)
                        {
                            precedenciaPila = precedenciaOperador(pila.Peek());

                            precedenciaExpresion = precedenciaOperador(x);

                            while (precedenciaPila > precedenciaExpresion)
                            {
                                expresionPostfija += pila.Pop() + " ";
                                if (pila.Count > 0)
                                {
                                    precedenciaPila = precedenciaOperador(pila.Peek());
                                }
                                else
                                {
                                    precedenciaPila = 0;
                                }
                            }
                        }

                        pila.Push(x.ToString());
                    }
                    else if (x == ")")
                    {
                        while (pila.Peek() != "(")
                        {
                            expresionPostfija += pila.Pop() + " ";
                        }

                        //Elimine de la pila parentesis de apertura
                        pila.Pop();

                    }
                }

                //Vaciar la pila y agregarlo a la expresion postfija
                while (pila.Count > 0)
                {
                    expresionPostfija += pila.Pop() + " ";
                }
                                
                txtExpresionPostfija.Text = expresionPostfija;
            }
            else
            {
                txtExpresionPostfija.Text = "La expresión solo puede contener números y operadores";
            }
            
        }

        private bool convertirALista(string expresion, out List<string> listaExterna)
        {
            List<string> Lista = new List<string>();

            bool resultado = false;

            //Validar que la expresion solo contenga números, operadores y paréntesis
            if (Regex.IsMatch(expresion, @"^[0-9\*\+\-\/\^\(\)]+$"))
            {
                resultado = true;

                for (int i = 0; i < expresion.Length; i++)
                {
                    Lista.Add(expresion[i].ToString());
                }
            }

            listaExterna=Lista;

            return resultado;
        }

        private int precedenciaOperador(string operador)
        {
            int precedencia = 0;

            if (operador == "+" || operador == "-")
            {
                precedencia = 1;
            }
            else if (operador == "*" || operador == "/")
            {
                precedencia = 2;
            }
            else if (operador == "^")
            {
                precedencia = 3;
            }

            return precedencia;
        }
    }
}
