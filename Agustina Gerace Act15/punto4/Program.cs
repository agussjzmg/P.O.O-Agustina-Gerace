using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    /*4. Línea de Ensamblaje Robótico
    En una planta de fabricación automatizada, cada robot industrial realiza tareas de
    ensamblaje complejas divididas en operaciones secundarias de duración variable.
    ● Diseñar la clase RobotEnsamblador que tenga como atributos privados:
    1. ModeloRobot.
    2. Una matriz irregular de tipo float (float[][] tiemposOperacion) donde cada
    fila representa una de las 4 fases principales del proceso (Estructura,
    Cableado, Pintura y Testeo), y cada columna los segundos que demoró en
    completar las distintas subtareas de esa fase (por ejemplo, en la fase de
    Estructura el robot puede tener 3 sub-tareas, pero en la de Testeo solo tiene
    1).
    3. El constructor de RobotEnsamblador debe pedir su modelo, preguntar para
    cada una de las 4 fases de fabricación cuántas sub-tareas requirió realizar

    (definiendo el tamaño de cada fila) y cargar la duración en segundos de cada
    una de ellas.

    ● Diseñar la clase colaboradora PlantaIndustrial que gestione a 3 objetos de la clase
    RobotEnsamblador. Implementar en PlantaIndustrial:
    1. Un constructor que cargue la información de los 3 robots instalados en la
    planta.
    2. Un método que muestre un reporte detallado con los tiempos de operación
    de cada robot fase por fase.
    3. Un método que calcule el promedio general de tiempo por tarea de cada
    robot y declare al &quot;Robot más Eficiente&quot; (aquel que registre el promedio de
    tiempo por operación más bajo de la planta).*/
    class RobotEnsamblador
        {
            private string modeloRobot;
            private float[][] tiemposOperacion;

            public RobotEnsamblador()
            {
                string[] fases = { "Estructura", "Cableado", "Pintura", "Testeo" };

                Console.Write("Ingrese modelo del robot: ");
                modeloRobot = Console.ReadLine();

                tiemposOperacion = new float[4][];

                for (int t = 0; t < 4; t++)
                {
                    Console.Write("Cantidad de subtareas en " + fases[t] + ": ");
                    int cant = int.Parse(Console.ReadLine());

                    tiemposOperacion[t] = new float[cant];

                    for (int a = 0; a < cant; a++)
                    {
                        Console.Write("Tiempo de la subtarea " + (a + 1) + ": ");
                        tiemposOperacion[t][a] = float.Parse(Console.ReadLine());
                    }
                }
            }

            public string RetornarModelo()
            {
                return modeloRobot;
            }

            public void Mostrar()
            {
                string[] fases = { "Estructura", "Cableado", "Pintura", "Testeo" };

                Console.WriteLine("\nRobot: " + modeloRobot);

                for (int t = 0; t < 4; t++)
                {
                    Console.Write(fases[t] + ": ");

                    for (int a = 0; a < tiemposOperacion[t].Length; a++)
                    {
                        Console.Write(tiemposOperacion[t][a] + " ");
                    }

                    Console.WriteLine();
                }
            }

            public float Promedio()
            {
                float suma = 0;
                int contador = 0;

                for (int t = 0; t < 4; t++)
                {
                    for (int a = 0; a < tiemposOperacion[t].Length; a++)
                    {
                        suma += tiemposOperacion[t][a];
                        contador++;
                    }
                }

                return suma / contador;
            }
        }

        class PlantaIndustrial
        {
            private RobotEnsamblador[] robots;

            public PlantaIndustrial()
            {
                robots = new RobotEnsamblador[3];

                for (int t = 0; t < 3; t++)
                {
                    Console.WriteLine("Robot " + (t + 1));
                    robots[t] = new RobotEnsamblador();
                }
            }

            public void Reporte()
            {
                for (int t = 0; t < 3; t++)
                {
                    robots[t].Mostrar();
                }
            }

            public void RobotMasEficiente()
            {
                float menor = robots[0].Promedio();
                string nombre = robots[0].RetornarModelo();

                for (int t = 1; t < 3; t++)
                {
                    if (robots[t].Promedio() < menor)
                    {
                        menor = robots[t].Promedio();
                        nombre = robots[t].RetornarModelo();
                    }
                }

                Console.WriteLine("Robot más eficiente: " + nombre);
                Console.WriteLine("Promedio por tarea: " + menor + " segundos");
            }
            static void Main(string[] args)
            {
                PlantaIndustrial planta = new PlantaIndustrial();
                planta.Reporte();
                planta.RobotMasEficiente();
                Console.ReadKey();
            }
        }
    }