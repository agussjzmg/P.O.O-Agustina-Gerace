using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 3. Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
            a) La cantidad de valores ingresados negativos.
            b) La cantidad de valores ingresados positivos.
            c) La cantidad de múltiplos de 15.
            d) El valor acumulado de los números ingresados que son pares.*/

            string linea;
            int num;
            int positivos = 0;
            int negativos = 0;
            int mult15 = 0;
            int par = 0;

            for (int i = 0; i <=10 ; i++) {
            Console.WriteLine("ingrese un numero: ");
            linea = Console.ReadLine();
            num = int.Parse(linea);
                if (num > 0) {
                    positivos++;
                }
                if (num < 0)
                {
                    negativos++;
                }
                if (num % 15 == 0)
                {
                    mult15++;
                }
                if (num % 2 == 0)
                {
                    par++;
                }

            }
            Console.WriteLine("La cantidad de numeros positivos son: " + positivos);
            Console.WriteLine("La cantidad de numeros negativos son: " + negativos);
            Console.WriteLine("La cantidad de multiplos de 15 son: " + mult15);
            Console.WriteLine("La cantidad de numeros pares son: " + par);
            Console.ReadKey();
        }
    }
}
