using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    /*2. Implementar la clase operaciones. Se deben cargar dos valores enteros en el
    constructor, calcular su suma, resta, multiplicación y división, cada una en un
    método, imprimir dichos resultados.*/
    class Operaciones
    {
        private int uno;
        private int dos;

        public Operaciones()
        {
            for (int i = 0; i < 1; i++)
            {
                Console.Write("Ingrese el primer numero: ");
                string linea = Console.ReadLine();
                uno = int.Parse(linea);
                Console.Write("Ingrese el segundo numero: ");
                linea = Console.ReadLine();
                dos = int.Parse(linea);
            }
        }
        public void Suma()
        {
            int suma;
            suma = uno + dos;
            Console.WriteLine("La suma de esos dos numeros es: " + suma);
        }
        public void Resta()
        {
            int resta;
            resta = uno - dos;
            Console.WriteLine("La resta de esos numeros es: " + resta);
        }
        public void Multiplicacion()
        {
            int mult;
            mult = uno * dos;
            Console.WriteLine("La multiplicación de esos numeros es: " + mult);
        }
        public void Division()
        {
            int div;
            div = uno / dos;
            if (div <= 0)
            {
                Console.WriteLine("No se puede hacer la división de esos números");
            }
            else
            {
                Console.WriteLine("La división de esos numeros es: " + div);
            }
        }
        static void Main(string[] args)
        {
            Operaciones op = new Operaciones();
            op.Suma();
            op.Resta();
            op.Multiplicacion();
            op.Division();
            Console.ReadKey();
        }
    }
}