using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    //3. Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector
    //(el orden lo pueden elegir ustedes).
    internal class punto3
    {
        private int[] v;
        public void Cargar()
        {
            Console.Write("numero de elementos del vector: ");
            string linea = Console.ReadLine();
            int n = int.Parse(linea);
            v = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("numero de elementos del vector: ");
                linea = Console.ReadLine();
                v[i] = int.Parse(linea);
            }
        }
        public void Ordenar()
        {
            for (int a = 0; a < v.Length - 1; a++) 
            {
                for (int i = 0; i < v.Length - 1; i++)
                {
                    if (v[i] > v[i + 1])
                    {
                        int aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            punto3 p3 = new punto3();
            p3.Cargar();
            p3.Ordenar();
            Console.ReadKey();
        }
    }
}
