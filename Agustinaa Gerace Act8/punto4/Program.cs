using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{

    //4. Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
    //habitantes de este. Ordenar alfabéticamente e imprimir los resultados. Por último
    //ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir
    //nuevamente.
    internal class punto4
    {
        private string[] paises;
        private int[] hab;
        public void Cargar()
        {
            paises = new string[5];
            hab = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("cargar pais: ");
                string linea = Console.ReadLine();
                paises[i] = linea;
                Console.Write("numero de habitantes: ");
                linea = Console.ReadLine();
                hab[i] = int.Parse(linea);
            }
        }
        public void OrdenarAlf()
        {
            string aux;
            int auxi;

            for (int a = 0; a < 4; a++)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (paises[i].CompareTo(paises[i + 1]) > 0)
                    {
                        aux = paises[i];
                        paises[i] = paises[i + 1];
                        paises[i + 1] = aux;

                        auxi = hab[i];
                        hab[i] = hab[i + 1];
                        hab[i + 1] = auxi;
                    }
                }
            }

            Console.WriteLine("Paises ordenados alfabeticamente:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(paises[i] + ": " + hab[i]);
            }
        }
        public void OrdenarHab()
        {
            string aux;
            int auxi;

            for (int a = 0; a < 4; a++)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (hab[i] < hab[i + 1]) 
                    {
                        aux = paises[i];
                        paises[i] = paises[i + 1];
                        paises[i + 1] = aux;

                        auxi = hab[i];
                        hab[i] = hab[i + 1];
                        hab[i + 1] = auxi;
                    }
                }
            }

            Console.WriteLine("Paises ordenados por habitantes:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(paises[i] + ": " + hab[i]);
            }
        }
        static void Main(string[] args)
        {
            punto4 p4 = new punto4();
            p4.Cargar();
            p4.OrdenarAlf();
            p4.OrdenarHab();
            Console.ReadKey();
        }
    }
}
