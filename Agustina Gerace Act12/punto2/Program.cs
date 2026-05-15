using System;
namespace punto2
{
    /*2. Gestión de Complejo de Cine Un cine tiene 4 salas con diferentes capacidades de 
     * espectadores (la Sala 1 tiene 10 asientos, la Sala 2 tiene 15, la Sala 3 tiene 8 y
     * la Sala 4 tiene 12). ● Definir una matriz irregular de 4 filas para representar los asientos.
     * ● Métodos: 1. Inicializar la matriz con los tamaños de las salas mencionadas (sin intervención del operador).
     * 2. Crear un método de "Venta de Entradas" que permita cargar la edad del espectador en un asiento específico (fila y columna). 
     * 3. Imprimir el mapa de ocupación de las salas indicando la edad del espectador en cada asiento.
     * 4. Calcular cuántos menores de edad (menos de 18 años) hay en cada sala. 
     * 5. Informar cuál es el promedio de edad de los espectadores de todo el complejo. */
   
    class matriz2
    {
            private int[][] salas;
           
        public void Cargar()
            {
                salas = new int[4][];

                salas[0] = new int[10];
                salas[1] = new int[15];
                salas[2] = new int[8];
                salas[3] = new int[12];
            }

            public void VentaEntradas()
            {
                string linea;

                Console.WriteLine("ingrese cuantas entradas quiere comprar:");
                linea = Console.ReadLine();
                int cantidad = int.Parse(linea);

                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine("ingrese numero de sala (1 a 4):");
                    linea = Console.ReadLine();
                    int fila = int.Parse(linea) - 1;

                    Console.WriteLine("ingrese numero de asiento:");
                    linea = Console.ReadLine();
                    int columna = int.Parse(linea);

                    Console.WriteLine("ingrese edad del espectador:");
                    linea = Console.ReadLine();
                    int edad = int.Parse(linea);

                    salas[fila][columna] = edad;
                }
            }

            public void MostrarSalas()
            {
                Console.WriteLine("mapa de las salas:");

                for (int t = 0; t < salas.Length; t++)
                {
                    Console.Write("sala " + (t + 1) + ": ");

                    for (int a = 0; a < salas[t].Length; a++)
                    {
                        Console.Write(salas[t][a] + " ");
                    }

                    Console.WriteLine();
                }
            }

            public void MenoresSala()
            {
                for (int t = 0; t < salas.Length; t++)
                {
                    int menores = 0;

                    for (int a = 0; a < salas[t].Length; a++)
                    {
                        if (salas[t][a] < 18 && salas[t][a] > 0)
                        {
                            menores++;
                        }
                    }

                    Console.WriteLine("sala " + (t + 1) + " cantidad de menores: " + menores);
                }
            }

            public void promedio()
            {
                int suma = 0;
                int cantidad = 0;

                for (int t = 0; t < salas.Length; t++)
                {
                    for (int a = 0; a < salas[t].Length; a++)
                    {
                        suma = suma + salas[t][a];
                        cantidad++;

                    }
                }

                if (cantidad > 0)
                {
                    double promedio;

                    promedio = (double)suma / cantidad;

                    Console.WriteLine("el promedio general de edad es de: " + promedio);
                }
            }

            static void Main(string[] args)
            {
                matriz2 mat2 = new matriz2();
                mat2.Cargar();
                mat2.VentaEntradas();
                mat2.MostrarSalas();
                mat2.MenoresSala();
                mat2.promedio();
                Console.ReadKey();
            }
        }
    }