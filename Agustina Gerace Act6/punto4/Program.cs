using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    // Punto 4: Implementar la clase Operaciones. Cargar dos valores enteros y calcular
    // suma, resta, multiplicación y división, cada una en un método.

    class Operaciones
    {
        int valor1;
        int valor2;

        public void Cargar()
        {
            Console.Write("Ingrese el primer valor: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());
        }

        public void Suma()
        {
            int suma = valor1 + valor2;
            Console.WriteLine("Su suma es de: " + suma);
        }

        public void Resta()
        {
            int resta = valor1 - valor2;
            Console.WriteLine("Su resta de " + resta);
        }

        public void Multiplicacion()
        {
            int multiplicacion = valor1 * valor2;
            Console.WriteLine("Su multiplicación de: " + multiplicacion);
        }

        public void Division()
        {
            if (valor2 > 0)
            {
                int division = valor1 / valor2;
                Console.WriteLine("Y por último su división es de: " + division);
            }
            else
            {
                Console.WriteLine("Y por último, no se puede dividir por cero");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();
            operaciones.Cargar();
            operaciones.Suma();
            operaciones.Resta();
            operaciones.Multiplicacion();
            operaciones.Division();

            Console.ReadKey();
        }
    }
}

