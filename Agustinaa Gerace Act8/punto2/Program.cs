using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    //2. Definir un vector donde almacenar los nombres de 5 países. Confeccionar el
    //algoritmo de ordenamiento alfabético.
    internal class punto2
    {
        private string[] paises;
        public void Cargar()
        {
            paises = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("escribir nombre de un pais: ");
                string linea = Console.ReadLine();
                paises[i] = linea;
            }
        }
        public void Ordenar()
        {
            string aux;
            for (int a = 0; a < 4; a++) 
            {
                for (int i = 0; i < 4; i++)
                {
                    if (paises[i].CompareTo(paises[i + 1]) > 0)
                    {
                        aux = paises[i];
                        paises[i] = paises[i + 1];
                        paises[i + 1] = aux;
                    }
                }
            }
        }
        public void Mostrar()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(paises[i]);
            }
        }
        static void Main(string[] args)
        {
            punto2 p2 = new punto2();
            p2.Cargar();
            p2.Ordenar();
            p2.Mostrar();
            Console.ReadKey();
        }
    }
}