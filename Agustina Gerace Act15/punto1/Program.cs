using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    /*1. Monitoreo Clínico de Pacientes
    En una sala de cuidados intensivos, se requiere realizar un seguimiento constante del ritmo
    cardíaco de los pacientes.
    ● Plantear una clase llamada Paciente que tenga como atributos privados:
    1. Nombre (de tipo string).
    2. Una matriz llamada ritmoCardiaco de tamaño 3x4 (representando los
    registros de pulsaciones tomados durante 3 días diferentes, en 4 momentos
    clave de cada día: mañana, mediodía, tarde y noche).
    3. El constructor de Paciente debe pedir su nombre y solicitar la carga por
    teclado de las 12 lecturas cardíacas.

    ● Confeccionar la clase colaboradora SalaMonitoreo que administre un vector de 3
    objetos de la clase Paciente. Su constructor debe inicializar el vector y solicitar la
    carga de los 3 pacientes. Implementar los siguientes métodos dentro de
    SalaMonitoreo:
    1. Un método que imprima la grilla de lecturas cardíacas completa de cada
    paciente organizada por día y momento.
    2. Un método que calcule e imprima el promedio de pulsaciones de cada
    paciente a lo largo de todo su monitoreo.
    3. Un método que verifique si algún paciente registró un evento de taquicardia
    severa (cualquier lectura individual que sea estrictamente mayor a 120
    pulsaciones), mostrando por consola su nombre y la lectura detectada.*/
    class Paciente
    {
            private string nom;
            private float[,] ritmoCardiaco;

            public Paciente()
            {
                ritmoCardiaco = new float[3, 4];

                Console.Write("Ingrese nombre del paciente: ");
                nom = Console.ReadLine();

                string[] momentos = { "mañana", "mediodía", "tarde", "noche" };

                for (int t = 0; t < 3; t++)
                {
                    Console.WriteLine("Día " + (t + 1));

                    for (int a = 0; a < 4; a++)
                    {
                        Console.Write("Ingrese ritmo cardíaco de la " + momentos[a] + ": ");
                        ritmoCardiaco[t, a] = float.Parse(Console.ReadLine());
                    }
                }
            }

            public void Imprimir()
            {
                Console.WriteLine("paciente: " + nom);

                for (int t = 0; t < 3; t++)
                {
                    for (int a = 0; a < 4; a++)
                    {
                        Console.Write(ritmoCardiaco[t, a] + " ");
                    }
                    Console.WriteLine();
                }
            }

            public void Promedio()
            {
                float suma = 0;

                for (int t = 0; t < 3; t++)
                {
                    for (int a = 0; a < 4; a++)
                    {
                        suma += ritmoCardiaco[t, a];
                    }
                }

                Console.WriteLine("Promedio de " + nom + ": " + (suma / 12));
            }

            public void Taquicardia()
            {
                for (int t = 0; t < 3; t++)
                {
                    for (int a = 0; a < 4; a++)
                    {
                        if (ritmoCardiaco[t, a] > 120)
                        {
                            Console.WriteLine(nom + " registró una evento de taquicardia severa con una lectura de " + ritmoCardiaco[t, a]);
                        }
                    }
                }
            }
        }

        class SalaMonitoreo
        {
            private Paciente[] pac;

            public SalaMonitoreo()
            {
                pac = new Paciente[3];

                for (int i = 0; i < 3; i++)
                {
                    pac[i] = new Paciente();
                }
            }

            public void MostrarPacientes()
            {
                for (int i = 0; i < 3; i++)
                {
                    pac[i].Imprimir();
                }
            }

            public void MostrarPromedios()
            {
                for (int i = 0; i < 3; i++)
                {
                    pac[i].Promedio();
                }
            }

            public void MostrarTaquicardias()
            {
                for (int i = 0; i < 3; i++)
                {
                    pac[i].Taquicardia();
                }
            }
            static void Main(string[] args)
            {
                SalaMonitoreo s = new SalaMonitoreo();
                s.MostrarPacientes();
                s.MostrarPromedios();
                s.MostrarTaquicardias();
                Console.ReadKey();
            }
        }
    }