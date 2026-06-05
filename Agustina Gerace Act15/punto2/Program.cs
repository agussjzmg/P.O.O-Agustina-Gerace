using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    /*2. Logística de Puerto Espacial
    Una estación de acoplamiento registra el peso de los contenedores transportados en las
    bodegas de carga de las naves espaciales que llegan al puerto.
    ● Crear la clase NaveEspacial que contenga únicamente el atributo privado
    NombreNave y su constructor para cargarlo.
    ● Crear la clase colaboradora PuertoControl que contenga:
    ○ Un vector de 3 objetos de la clase NaveEspacial.
    ○ Una matriz irregular de tipo double llamado pesoContenedores, donde
    cada fila representa a una nave, el tamaño de la fila es la cantidad de
    bodegas que posee esa nave, y los valores almacenados son los pesos (en
    toneladas) de los contenedores que transporta cada bodega.

    En PuertoControl, definir los siguientes métodos:

    1. Un constructor que cargue los nombres de las 3 naves, pregunte para cada una
    cuántas bodegas activas posee (para definir el tamaño de su fila en la matriz
    irregular) y cargue el peso del contenedor asignado a cada bodega.
    2. Un método que muestre en pantalla el detalle de los pesos cargados por cada nave
    espacial.
    3. Un método que identifique e informe qué nave transporta el contenedor individual
    más pesado de todo el puerto espacial (el valor máximo absoluto de la matriz
    irregular).
    4. Un método que indique el nombre de la nave que transporta menor peso acumulado
    total (la suma de todos sus contenedores).*/
    class NaveEspacial
        {
            private string nombreNave;

            public NaveEspacial()
            {
                Console.Write("Ingrese nombre de la nave: ");
                nombreNave = Console.ReadLine();
            }

            public string RetornarNombre()
            {
                return nombreNave;
            }
        }

        class PuertoControl
        {
            private NaveEspacial[] naves;
            private double[][] pesoContenedores;

            public PuertoControl()
            {
                naves = new NaveEspacial[3];
                pesoContenedores = new double[3][];

                for (int t = 0; t < 3; t++)
                {
                    Console.WriteLine("Nave " + (t + 1));

                    naves[t] = new NaveEspacial();

                    Console.Write("Cantidad de bodegas: ");
                    int cant = int.Parse(Console.ReadLine());

                    pesoContenedores[t] = new double[cant];

                    for (int a = 0; a < cant; a++)
                    {
                        Console.Write("Peso del contenedor " + (a + 1) + ": ");
                        pesoContenedores[t][a] = double.Parse(Console.ReadLine());
                    }
                }
            }

            public void Mostrar()
            {
                for (int t = 0; t < 3; t++)
                {
                    Console.WriteLine("Nave: " + naves[t].RetornarNombre());

                    for (int a = 0; a < pesoContenedores[t].Length; a++)
                    {
                        Console.WriteLine("Bodega " + (a + 1) + ": " + pesoContenedores[t][a] + " toneladas");
                    }
                }
            }

            public void ContenedorMasPesado()
            {
                double mayor = pesoContenedores[0][0];
                string nombre = naves[0].RetornarNombre();

                for (int t = 0; t < 3; t++)
                {
                    for (int a = 0; a < pesoContenedores[t].Length; a++)
                    {
                        if (pesoContenedores[t][a] > mayor)
                        {
                            mayor = pesoContenedores[t][a];
                            nombre = naves[t].RetornarNombre();
                        }
                    }
                }

                Console.WriteLine("El contenedor más pesado pesa " + mayor + " toneladas y está en la nave " + nombre);
            }

            public void MenorPesoTotal()
            {
                double menor = 10000;
                string nombre = "";

                for (int t = 0; t < 3; t++)
                {
                    double suma = 0;

                    for (int a = 0; a < pesoContenedores[t].Length; a++)
                    {
                        suma += pesoContenedores[t][a];
                    }

                    if (suma < menor)
                    {
                        menor = suma;
                        nombre = naves[t].RetornarNombre();
                    }
                }

                Console.WriteLine("La nave con menor peso acumulado es " + nombre + " con " + menor + " toneladas.");
            }
            
            static void Main(string[] args)
            {
                PuertoControl p = new PuertoControl();
                p.Mostrar();
                p.ContenedorMasPesado();
                p.MenorPesoTotal();
                Console.ReadKey();
            }
        }
    }