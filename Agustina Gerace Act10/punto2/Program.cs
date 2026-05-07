using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    /*2- Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la
      primer fila con la segunda. Imprimir luego la matriz.*/
    class matriz2
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
        public void IntercambiarFila()
        {
            for (int t = 0; t < mat.GetLength(1); t++)
            {
                int aux = mat[0, t];
                mat[0, t] = mat[1, t];
                mat[1, t] = aux;
            }
        }
        public void Imprimir() {
            for (int a = 0; a < mat.GetLength(0); a++)
            {
                for (int t = 0; t < mat.GetLength(1); t++)
                {
                    Console.WriteLine(mat[a, t] + "  ");
                }
                Console.WriteLine();
            }
        }
        
        static void Main(string[] args)
        {
            matriz2 mat2 = new matriz2();
            mat2.Cargar();
            mat2.IntercambiarFila();
            mat2.Imprimir();
            Console.ReadKey();
        }
    }
}
