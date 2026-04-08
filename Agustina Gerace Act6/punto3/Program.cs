using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    // Punto 3: Confeccionar una clase que represente un empleado con nombre y sueldo.
    // Cargar datos, imprimirlos y mostrar si debe pagar impuestos (sueldo > 3000).

    class Empleado
    {
        string nombre;
        float sueldo;

        public void Cargar()
        {
            Console.Write("Ingrese el nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese el sueldo: ");
            sueldo= float.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Sueldo: " + sueldo);
        }

        public void Impuestos()
        {
            if (sueldo > 3000)
                Console.WriteLine("Debe pagar impuestos");
            else
                Console.WriteLine("No debe pagar impuestos");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            empleado.Cargar();
            empleado.Imprimir();
            empleado.Impuestos();

            Console.ReadKey();
        }
    }
}

