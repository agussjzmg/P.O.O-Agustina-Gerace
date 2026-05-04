using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    //2. Una empresa registra los nombres de sus 5 vendedores y el total de ventas
    //realizadas por cada uno en un mes. Cargar los nombres y ventas en dos
    //vectores paralelos, ordenar los datos de mayor a menor según las ventas,
    //imprimir la lista ordenada con nombre y monto de la venta, e informar quien fue
    //el que menos vendió de los 5 empleados.
    internal class punto2
    {
        private string[] vend;
        private int[] vent;
        public void Cargar()
        {
            vend = new string[5];
            vent = new int[5];
            for (int i = 0; i < vend.Length; i++)
            {

                Console.Write("nombre del vendedor: ");
                string linea = Console.ReadLine();
                vend[i] = linea;
                Console.Write("total de ventas del vendedor: ");
                linea = Console.ReadLine();
                vent[i] = int.Parse(linea);
            }
        }
        public void OrdenarMayor()
        {
            string aux;
            int auxi;

            Console.WriteLine("datos ordenados de mayor a menor segun las ventas: ");

            for (int i = 0; i < vent.Length - 1; i++)
            {
                for (int a = 0; a < vent.Length - 1 - i; a++)
                {
                    if (vent[a] < vent[a + 1])
                    {
                        auxi = vent[a];
                        vent[a] = vent[a + 1];
                        vent[a + 1] = auxi;

                        aux = vend[a];
                        vend[a] = vend[a + 1];
                        vend[a + 1] = aux;
                    }
                }
            }

            for (int i = 0; i < vent.Length; i++)
            {
                Console.WriteLine(vend[i] + ": " + vent[i]);
            }

            Console.WriteLine("el que menos vendio fue: " + vend[vent.Length - 1]);
        }
        static void Main(string[] args)
        {
            punto2 p2 = new punto2();
            p2.Cargar();
            p2.OrdenarMayor();
            Console.ReadLine();
        }
    }
}
