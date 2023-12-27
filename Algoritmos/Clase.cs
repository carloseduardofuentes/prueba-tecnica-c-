using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    internal class Clase
    {
        public bool Sumar2Num(out string mensaje)
        {
            bool resultado = false;

            mensaje = "";

            int[] array1 = { 4, 7, 10, 2, 18 };

            int objetivo = 17;

            int num1, num2;

            for (int i = 0; i < array1.Length; i++)
            {
                num1 = array1[i];

                for (int j = 0; j < array1.Length; j++)
                {
                    num2 = array1[j];

                    if (num1 + num2 == objetivo)
                    {
                        mensaje = "Num1= " + num1 + " y Num2= " + num2;
                        resultado = true;
                    }

                }
            }

            return resultado;
        }

        public bool Suma2NumOptimizada(out string mensaje)
        {
            bool resultado = false;

            mensaje = "";

            int[] array1 = { 4, 7, 10, 2, 18 };

            int[] array2 = new int[5];

            int cantidad_array2 = 0;

            int objetivo = 22;

            int num1, num2, diferencia, busqueda;

            for (int i = 0; i < array1.Length; i++)
            {
                num1 = array1[i];

                diferencia = objetivo - num1;

                busqueda = Array.Find(array1, element => element == diferencia);

                if (busqueda == diferencia)
                {
                    mensaje = "Num1= " + num1 + " y Num2= " + diferencia;
                    return true;
                }

                //cantidad_array2 = array2.Length;

                //array2[cantidad_array2] = num1;

            }
            mensaje = "No fue encontrado numero que sumen " + objetivo;
            return false;
        }
    }
}
