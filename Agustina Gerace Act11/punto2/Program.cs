using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace punto2
    {
        /*2. Confeccionar una clase para administrar una matriz irregular
        de 5 filas y 1 columna la primer fila, 2 columnas la segunda fila
        y así sucesivamente hasta 5 columnas la última fila.
        Realizar la carga por teclado e imprimir posteriormente.*/

        class matriz2
        {
            private int[][] mat;

            public void Cargar()
            {
                mat = new int[5][];
                mat[0] = new int[1];
                mat[1] = new int[2];
                mat[2] = new int[3];
                mat[3] = new int[4];
                mat[4] = new int[5];

                string linea; 

                for (int t = 0; t < mat.Length; t++)
                {
                    for (int a = 0; a < mat[t].Length; a++)
                    {
                        Console.Write("Ingrese componente de la matriz: ");
                        linea = Console.ReadLine();
                        mat[t][a] = int.Parse(linea);
                    }
                }
            }

            public void Imprimir()
            {
                for (int t = 0; t < mat.Length; t++)
                {
                    for (int a = 0; a < mat[t].Length; a++)
                    {
                        Console.Write(mat[t][a] + " ");
                    }

                    Console.WriteLine();
                }
            }

            static void Main(string[] args)
            {
                matriz2 mat2 = new matriz2();
                mat2.Cargar();
                mat2.Imprimir();

                Console.ReadKey();
            }
        }
    }