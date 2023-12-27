namespace Algoritmos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPalabrasRepetidas_Click(object sender, EventArgs e)
        {
            string[] palabras=txtTexto.Text.Split(" ");
            string resultado=string.Empty;
            int repetido=0; 
            List<palabra> oPalabras = new List<palabra>();
            bool existe=false;
            
            for(int i=0;i<palabras.Length; i++)
            {
                //1 forma usando Arrays
                //for (int j = 0; j < palabras.Length; j++)
                //{
                //    if (palabras[j] == palabras[i])
                //    {
                //        repetido++;
                //        if (repetido == 1)
                //        {
                //            palabra oPalabra = new palabra();
                //            oPalabra.nombre = palabras[i];
                //            oPalabra.cantidad = repetido;
                //            oPalabras.Add(oPalabra);
                //        }
                //        else if (repetido > 1)
                //        {
                //            palabra oPalabra3 = oPalabras.Find(x => x.nombre == palabras[i]);
                //            oPalabra3.cantidad = repetido;
                //        }
                //    }
                //}


                //2 forma                
                existe = oPalabras.Any(x => x.nombre == palabras[i]);
                if (existe)
                {

                    palabra oPalabra3 = oPalabras.Find(x => x.nombre == palabras[i]);
                    oPalabra3.cantidad++;

                }
                else
                {
                    repetido = 1;
                    palabra oPalabra2 = new palabra();
                    oPalabra2.nombre = palabras[i];
                    oPalabra2.cantidad = repetido;
                    oPalabras.Add(oPalabra2);
                }

                repetido = 0;
            }

            dataGridView1.DataSource=oPalabras;
        }
    }

    public class palabra
    {
        public string nombre { get; set; }    

        public int cantidad { get; set; }   
    }
}