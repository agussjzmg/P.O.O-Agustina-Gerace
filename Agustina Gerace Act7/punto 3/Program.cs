using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{
    internal class punto3
    {
        /*3. Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de
un videojuego. El programa debe:
 Mostrar la puntuación más alta y la más baja.
 Calcular el promedio de puntuación.
 Contar cuántas veces superó los 500 puntos.*/
        private int[] pun;

        public void Cargar()
        {

            pun = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Ingrese la puntuacion: ");
                string linea;
                linea = Console.ReadLine();
                pun[i] = int.Parse(linea);
            }
        }
        public void altaybaja()
        {
            int alta = 0;
            int baja = 100000;
            for (int i = 0; i < 6; i++)
            {
                if (pun[i] > alta)
                {
                    alta = pun[i];
                }
                if (pun[i] < baja)
                {
                    baja = pun[i];
                }
            }
            Console.WriteLine("La puntuaciòn màs alta es: " + alta);
            Console.WriteLine("La puntuaciòn màs baja es: " + baja);
        }

        public void promedio()
        {
            int promedio = 0;
            int suma = 0;
            for (int i = 0; i < 6; i++)
            {
                suma = suma + pun[i];
                }
            promedio = suma / 6;
            Console.WriteLine("El promedio es de : " + promedio);
            }

        public void cont500()
        {
            int cont500 = 0;
            for (int i = 0; i < 6; i++)
            {
                if (pun[i]> 500) {
                    cont500++;
            }
        }
            if ( cont500 > 0) {
                Console.WriteLine("Veces que se superaron los 500 puntos: " + cont500);
            }
            else {
                Console.WriteLine("Nunca se superò el puntuaje de 500");
            }
        }

        static void Main(string[] args)
        {
            punto3 p3 = new punto3();
            p3.Cargar();
            p3.altaybaja();
            p3.promedio();
            p3.cont500();
            Console.ReadKey();
        }
    }
}
