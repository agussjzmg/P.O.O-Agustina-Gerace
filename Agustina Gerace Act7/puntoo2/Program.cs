using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puntoo2
{
    internal class punto2
    {
        /*2. Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
        elementos. Obtener la suma de los dos vectores, dicho resultado guardarlo en un
        tercer vector del mismo tamaño. Sumar componente a componente.*/
        private int[] vector;
        private int[] vector1;
        private int[] vector2;

        public void Cargar()
        {

            vector = new int[4];
            vector1 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingrese un valor: ");
                string linea;
                linea = Console.ReadLine();
                vector[i] = int.Parse(linea);
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingrese un segundo valor: ");
                string linea;
                linea = Console.ReadLine();
                vector1[i] = int.Parse(linea);

            }
        }
        public void Suma()
        {
            vector2 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                vector2[i] = vector1[i] + vector[i];
            Console.WriteLine("El numero acumulado de los elementos de ambos vectores es: " + vector2[i]);

            }
        }
        static void Main(string[] args)
        {
            punto2 p2 = new punto2();
            p2.Cargar();
            p2.Suma();
            Console.ReadKey();
        }
    }
}
