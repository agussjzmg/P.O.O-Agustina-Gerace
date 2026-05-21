using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    /*1. Confeccionar una clase que represente un empleado. Definir como atributos su
    nombre y su sueldo. En el constructor cargar los atributos y luego en otro
    método imprimir sus datos y por último uno que imprima un mensaje si debe
    pagar impuestos (si el sueldo supera a 3000)*/
    class Empleado
    {
        private string emp;
        private int sueldo;
        
        public Empleado() {
            Console.Write("Ingrese nombre del empleado: ");
            emp = Console.ReadLine();
            Console.Write("Ingrese su sueldo: ");
            string linea = Console.ReadLine();
            sueldo = int.Parse(linea);
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre: " + emp);
            Console.WriteLine("Sueldo: " + sueldo);
        }

        public void Mensaje() 
        {
            if (sueldo > 3000) {
                Console.WriteLine("Debe pagar impuestos");
            }
            else
            {
                Console.WriteLine("No debe pagar impuestos");
            }
        }
        static void Main(string[] args)
        {
            Empleado emple = new Empleado();
            emple.Imprimir();
            emple.Mensaje();
            Console.ReadKey();
        }
    }
}
