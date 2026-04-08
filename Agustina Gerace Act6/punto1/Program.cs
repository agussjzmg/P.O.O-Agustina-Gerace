using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    // Punto 1: Desarrollar una clase que represente un punto en el plano y permita cargar
    // los valores de x e y, e imprimir en que cuadrante se encuentra.


    class Puntos
    {
        float x;
        float y;

        public void Cargar()
        {
            Console.Write("Cuanto vale X?: ");
            x = float.Parse(Console.ReadLine());

            Console.Write("Cuanto vale Y?: ");
            y = float.Parse(Console.ReadLine());
        }

        public void Cuadrante()
        {
            if (x > 0 && y > 0)
                Console.WriteLine("Se encuentra sobre el primer cuadrante");
            else if (x < 0 && y > 0)
                Console.WriteLine("Se encuentra sobre el segundo cuadrante");
            else if (x < 0 && y < 0)
                Console.WriteLine("Se encuentra sobre el tercer cuadrante");
            else if (x > 0 && y < 0)
                Console.WriteLine("Se encuentra sobre el cuarto cuadrante");
            else
                Console.WriteLine("El punto se encuentra sobre un eje");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Puntos puntos = new Puntos();
            puntos.Cargar();
            puntos.Cuadrante();

            Console.ReadKey();
        }
    }
}


