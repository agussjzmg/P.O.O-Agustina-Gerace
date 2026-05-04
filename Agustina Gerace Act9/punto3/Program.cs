using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    //3. Se registran los nombres de 5 atletas y sus tiempos (en segundos) en una
    //carrera de 100 metros. El programa debe cargar los datos en dos vectores
    //paralelos, calcular y mostrar el promedio de los tiempos, mostrar el nombre del
    //atleta con mejor y peor tiempo, y mostrar los nombres de quienes superaron el
    //promedio.
    internal class punto3
    {
        private string[] nombre;
        private int[] tiempo;
        private int prom = 0;
        public void Cargar()
        {
            nombre = new string[5];
            tiempo = new int[5];
            int suma = 0;
            for (int i = 0; i < nombre.Length; i++)
            {

                Console.Write("ingrese el nombre del atleta ");
                string linea = Console.ReadLine();
                nombre[i] = linea;
                Console.Write("ingrese el tiempo del atleta en segundos: ");
                linea = Console.ReadLine();
                tiempo[i] = int.Parse(linea);
                suma = suma + tiempo[i];
            }
            prom = suma / 5;
            Console.WriteLine("promedio: " + prom);
        }
        public void TiempoAlto()
        {
            int alta = tiempo[0];
            string nomAlt = nombre[0];

            for (int i = 1; i < nombre.Length; i++)
            {
                if (tiempo[i] > alta)
                {
                    alta = tiempo[i];
                    nomAlt = nombre[i];
                }
            }

            Console.WriteLine("el peor tiempo es de: " + nomAlt + " con " + alta + " segundos");
        }
        public void TiempoBajo()
        {
            int baja = tiempo[0];
            string nomBaj = nombre[0];

            for (int i = 1; i < nombre.Length; i++)
            {
                if (tiempo[i] < baja)
                {
                    baja = tiempo[i];
                    nomBaj = nombre[i];
                }
            }

            Console.WriteLine("el mejor tiempo es de: " + nomBaj + " con " + baja + " segundos");
        }
        public void SupPromedio()
        {
            Console.WriteLine("atletas que superaron el promedio: ");
            for (int i = 0; i < nombre.Length; i++)
            {
                if (tiempo[i] > prom)
                {
                    Console.WriteLine(nombre[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            punto3 p3 = new punto3();
            p3.Cargar();
            p3.TiempoAlto();
            p3.TiempoBajo();
            p3.SupPromedio();
            Console.ReadKey();
        }
    }
}
