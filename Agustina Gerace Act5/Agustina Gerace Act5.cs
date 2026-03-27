using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos
            //muestre la tabla de multiplicar del mismo(los primeros 13 términos)
            //Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el 39.

            string linea;
            int num;
            int producto;
            
            Console.WriteLine("ingrese un numero del 1 al 10: ");
            linea = Console.ReadLine();
            num = int.Parse(linea);

            for (int i= 1; i<=13; i++)   {

                producto = num * i;
                Console.WriteLine(producto);

            }
            Console.ReadKey();
        }
    }
}
