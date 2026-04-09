using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 3. Realizar un programa que acumule (sume) valores ingresados por teclado hasta
            ingresar el 9999 (no sumar dicho valor, indica que ha finalizado la carga). Imprimir el
            valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.

            correcciones: 1. En el punto 3 falta indicar si el valor acumulado es igual, mayor o menor a cero.
            */
            string linea;
            int numero = 1;
            int suma = 0;

            Console.Write("Ingresa un numero:");
            linea = Console.ReadLine();
            numero = int.Parse(linea);
            while (numero != 9999)
            {
               suma = suma + numero;
                Console.Write("Ingresa un numero:");
                linea = Console.ReadLine();
                numero = int.Parse(linea);

            }
            if (suma > 0)
            {
                    Console.WriteLine("la suma es mayor a 0");
            }
            else if (suma < 0) {
                    Console.WriteLine("la suma es menor a 0");
                }
            else {
                    Console.WriteLine("la suma es igual a 0");
                }
            
            Console.WriteLine("la suma del valor de los numeros es:" + suma);
            Console.ReadKey();
        }
    }
}
