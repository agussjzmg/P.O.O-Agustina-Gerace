using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace punto_1
{
    /*1. Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
    El valor acumulado de todos los elementos del vector.
    El valor acumulado de los elementos del vector que sean mayores a 36.
    Cantidad de valores mayores a 50. */


    class punto1
    {
        private int[] vector; 

    public void Cargar()
        {
            
            vector = new int[8];
            for (int i = 0; i < 8; i++) {
                Console.Write("Ingrese un valor: ");
                string linea;
                linea = Console.ReadLine();
                vector[i] = int.Parse(linea);

            }
        }
        public void Imprimir() {
            
            int val = 0;
            int val2 = 0;
            int val3 = 0;
            for (int i = 0; i< 8; i++) {
                val = val + vector[i];
                if (vector[i] > 36)
                {
                    val2= val2 + vector[i];
                }
               if  (vector[i] > 50 ) {
                    val3 = val3 + vector[i];
                }
            }
            Console.WriteLine("El numero acumulado de los elementos es: " + val);
            Console.WriteLine("El numero acumulado de los elementos del vector mayores a 36 es " + val2);
            Console.WriteLine("El numero acumulado de los elementos del vector mayores a 50 es " + val3);
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





