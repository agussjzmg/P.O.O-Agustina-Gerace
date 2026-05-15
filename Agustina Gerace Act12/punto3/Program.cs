using System;

namespace punto3
{
    /*3. Academia de Gastronomía: Recetario Dinámico
    Un chef instructor evalúa a 3 alumnos en un examen final. Cada alumno debe presentar
    una cantidad distinta de platos (uno presenta 2 platos, otro 4 y otro 3).
    ● Definir un vector para los nombres de los alumnos.
    ● Definir una matriz irregular para cargar el puntaje obtenido (0 a 100) en cada plato
    presentado.
    ● Métodos:
    1. Cargar nombres y definir el tamaño de las filas según la cantidad de platos
    de cada alumno.
    2. Cargar los puntajes de cada plato validando que estén entre 0 y 100.
    3. Mostrar el listado de alumnos y el puntaje de cada uno de sus platos.
    4. Calcular el puntaje promedio de cada alumno e informar si está &quot;Aprobado&quot;
    (promedio &gt;= 70) o &quot;Reprobado&quot;.
    5. Determinar quién obtuvo el puntaje individual más alto en un solo plato (el
    valor máximo de la matriz).*/
    internal class matriz3
    {
            private string[] nombres;
            private int[][] puntajes;
            public void Cargar()
            {
                nombres = new string[3];
                puntajes = new int[3][];

                for (int t = 0; t < nombres.Length; t++)
                {
                    Console.Write("Nombre del alumno: ");
                    nombres[t] = Console.ReadLine();

                    Console.Write("Cuantos platos presento?: ");
                    int cantidad = int.Parse(Console.ReadLine());

                    puntajes[t] = new int[cantidad];
                }
            }

            public void CargarPuntajes()
            {
                for (int t = 0; t < puntajes.Length; t++)
                {
                    Console.WriteLine("Puntajes de " + nombres[t]);

                    for (int a = 0; a < puntajes[t].Length; a++)
                    {
                        int nota;

                        do
                        {
                            Console.Write("Ingrese puntaje del plato " + (a + 1) + ": ");
                            nota = int.Parse(Console.ReadLine());
                        if (nota < 0 || nota > 100)
                        {
                            Console.WriteLine("Esta mal, el puntaje debe estar entre 0 y 100");
                        }

                    } while (nota < 0 || nota > 100);

                        puntajes[t][a] = nota;
                    }
                }
            }

            public void Mostrar()
            {
                for (int t = 0; t < nombres.Length; t++)
                {
                    Console.WriteLine("Alumno: " + nombres[t]);

                    for (int a = 0; a < puntajes[t].Length; a++)
                    {
                        Console.WriteLine("Plato " + (a + 1) + ": " + puntajes[t][a]);
                    }

                    Console.WriteLine();
                }
            }

            public void Promedios()
            {
                for (int t = 0; t < nombres.Length; t++)
                {
                    int suma = 0;

                    for (int a = 0; a < puntajes[t].Length; a++)
                    {
                        suma += puntajes[t][a];
                    }

                    double promedio = (double)suma / puntajes[t].Length;

                    Console.WriteLine("Promedio de " + nombres[t] + ": " + promedio);

                    if (promedio >= 70)
                    {
                        Console.WriteLine("Aprobado");
                    }
                    else
                    {
                        Console.WriteLine("Reprobado");
                    }

                    Console.WriteLine();
                }
            }

            public void MayorPuntaje()
            {
                int mayor = puntajes[0][0];
                string alumno = nombres[0];

                for (int t = 0; t < puntajes.Length; t++)
                {
                    for (int a = 0; a < puntajes[t].Length; a++)
                    {
                        if (puntajes[t][a] > mayor)
                        {
                            mayor = puntajes[t][a];
                            alumno = nombres[t];
                        }
                    }
                }

                Console.WriteLine("El puntaje mas alto fue " + mayor);
                Console.Write(" del alumno " + alumno);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                matriz3 mat3 = new matriz3();
                mat3.Cargar();
                mat3.CargarPuntajes();
                mat3.Mostrar();
                mat3.Promedios();
                mat3.MayorPuntaje();
                Console.ReadKey();
            }
        }
    }