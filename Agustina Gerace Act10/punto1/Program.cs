using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    /*1- Crear una matriz de 2 filas y 5 columnas. Realizar la carga de
     componentes por columna (es decir primero ingresar toda la primer
     columna, luego la segunda columna y así sucesivamente)
     Imprimir luego la matriz. */
   class matriz1
    {
        private int[,] mat;
        public void Cargar()
        {
            mat = new int[2, 5];
            for (int a = 0; a < 2; a++) {
                for (int t = 0; t < 5; t++) { 
                Console.Write("Ingrese componente: ");
                string linea = Console.ReadLine();
                mat[a,t] = int.Parse(linea);
                }
            }
        }

        public void Imprimir() {
            for (int a = 0; a < 2; a++)
            {
                for (int t = 0; t < 5; t++)
                {
                    Console.WriteLine( mat[a, t] + "  ");
                }
                Console.WriteLine();
            }
         }
        static void Main(string[] args)
        {
            matriz1 mat1 = new matriz1();
            mat1.Cargar();
            mat1.Imprimir();
            Console.ReadKey();

        }
    }
}
