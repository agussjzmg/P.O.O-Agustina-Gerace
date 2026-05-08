using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    /*3. Confeccionar una clase para administrar los días que han faltado los 3 empleados de una
    empresa.
    Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz
    irregular para cargar los días que han faltado cada empleado (cargar el número de día que
    faltó)
    Cada fila de la matriz representa los días de cada empleado.
    a. Mostrar los empleados con la cantidad de inasistencias.
    b. Cuál empleado faltó menos días.*/
    class matriz3
    {
        private string[] nombres;
        private int[][] mat;

        public void Cargar()
        {
            nombres = new string[3];
            mat = new int[3][];
            string linea;
            for (int t = 0; t < nombres.Length; t++)
            {
                Console.Write("Nombre del empleado: ");
                nombres[t] = Console.ReadLine();

                Console.Write("Cuantos días faltó?: ");
                linea = Console.ReadLine();
                int cantidad = int.Parse(linea);
                mat[t] = new int[cantidad];

                for (int a = 0; a < mat[t].Length; a++)
                {
                    Console.Write("Que día faltó?: ");
                    linea = Console.ReadLine();
                    int dia = int.Parse(linea);

                    if (dia <= 0 || dia > 31)
                    {
                        Console.WriteLine("Esta mal, los dias solo van del 1 al 30");
                        a--;
                    }
                    else
                    {
                        mat[t][a] = dia;
                    }
                }
              
            }
        }
        public void Matriz() {
            for (int t = 0; t < mat.Length; t++)
            {
                Console.Write(nombres[t] + ": ");

                for (int a = 0; a < mat[t].Length; a++)
                {
                    Console.Write(mat[t][a] + " ");
                }

                Console.WriteLine();
            }
        }
        public void Imprimir()
        {
            for (int t = 0; t < nombres.Length; t++)
            {
                Console.WriteLine(nombres[t] + " faltó " + mat[t].Length + " días");
            }
        }

        public void MasFaltas()
        {
            int menor = mat[0].Length;
            string emp = nombres[0];

            for (int t = 1; t < nombres.Length; t++)
            {
                if (mat[t].Length < menor)
                {
                    menor = mat[t].Length;
                    emp = nombres[t];
                }
            }

            Console.WriteLine("El empleado con menos inasistencias es: " + emp);
        }

        static void Main(string[] args)
        {
            matriz3 mat3 = new matriz3();
            mat3.Cargar();
            mat3.Matriz();
            mat3.Imprimir();
            mat3.MasFaltas();

            Console.ReadKey();
        }
    }
}
