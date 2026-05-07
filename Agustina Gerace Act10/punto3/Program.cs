using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    /*3- Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los
    cuatro valores que se encuentran en los vértices de la misma (mat[0][0]
    etc.)*/
    class matriz3
    {
        private int[,] mat;
        public void Cargar() {
            Console.Write("Cuantas fila tiene la matriz: ");
            string linea = Console.ReadLine();
            int filas = int.Parse(linea);
            Console.Write("Cuantas columnas tiene la matriz: ");
            linea = Console.ReadLine();
            int columnas = int.Parse(linea);
            mat = new int[filas, columnas];
            for (int a = 0; a < mat.GetLength(0); a++)
            {
                for (int t = 0; t < mat.GetLength(1); t++)
                {
                    Console.Write("Ingrese componente: ");
                    linea = Console.ReadLine();
                    mat[a, t] = int.Parse(linea);
                }
            }
        }
        public void ImprimirVertices() {


            int filas = mat.GetLength(0);
            int columnas = mat.GetLength(1);

            Console.WriteLine( mat[0, 0]);
            Console.WriteLine( mat[0, columnas - 1]);
            Console.WriteLine( mat[filas - 1, 0]);
            Console.WriteLine( mat[filas - 1, columnas - 1]);
        }
        static void Main(string[] args)
        {
            matriz3 mat3 = new matriz3();
            mat3.Cargar();
            mat3.ImprimirVertices();
            Console.ReadKey();
        }
    }
}
