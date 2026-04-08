using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    // Punto 2: Desarrollar una clase que represente un Cuadrado y permita cargar el valor
    // del lado e imprimir su perímetro y su superficie.

    class Cuadrado
    {
        float lado;

        public void Cargar()
        {
            Console.Write("Ingrese el valor del lado del cuadrado: ");
            lado = float.Parse(Console.ReadLine());
        }

        public void Perimetro()
        {
            float perimetro = lado * 4;
            Console.WriteLine("El perímetro es de: " + perimetro);
        }

        public void Superficie()
        {
            float superficie = lado * lado;
            Console.WriteLine("La superficie es de: " + superficie);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cuadrado = new Cuadrado();
            cuadrado.Cargar();
            cuadrado.Perimetro();
            cuadrado.Superficie();

            Console.ReadKey();
        }
    }
}

