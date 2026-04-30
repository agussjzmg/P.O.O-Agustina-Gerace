using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    // 1. Cargar un vector de n elementos. Imprimir el menor y un mensaje si se repite dentro del vector.
    class punto1
    {
        private int[] vector;

        public void Cargar()
        {
            Console.Write("Cuantos elementos queres cargar?: ");
            int a = int.Parse(Console.ReadLine());

            vector = new int[a];  

            for (int i = 0; i < a; i++)
            {
                Console.Write("Ingrese un valor: ");
                string linea = Console.ReadLine();
                vector[i] = int.Parse(linea);
            }
        }
        public void Imprimir()
        {
            int menor = vector[0];
            int contador = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] < menor)
                {
                    menor = vector[i];
                   
                }
                    if (vector[i] == menor)
                    {
                        contador++;
                    }
                }
            Console.WriteLine("El menor valor es: " + menor);
            if (contador > 1)
            {
                Console.WriteLine("El menor se repite " + contador + " veces.");
            }
            else
            {
                Console.WriteLine("El menor no se repite.");
            }
        }

        static void Main(string[] args)
        {
            punto1 p1 = new punto1();
            p1.Cargar();
            p1.Imprimir();
            Console.ReadKey();
        }
    }
}