using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    /*3. Geolocalización de Reservas Naturales
    Un centro de ecología realiza mapeos de biodiversidad para contabilizar el avistamiento de
    especies protegidas en cuadrículas de territorio.
    ● Confeccionar la clase ReservaNatural que tenga como atributos privados el
    NombreReserva y una matriz llamada avistamientos de 3x3 (que representa un
    mapa de coordenadas o sectores de 3 filas y 3 columnas, donde se almacena la
    cantidad de animales avistados en cada sector). El constructor de la clase debe
    cargar por teclado el nombre y rellenar el mapa de avistamientos.
    ● Confeccionar la clase colaboradora CentroEcologico que contenga un vector de 3
    objetos de la clase ReservaNatural.
    La clase CentroEcologico debe implementar los siguientes métodos:
    1. Un constructor que solicite la carga secuencial de las 3 reservas.
    2. Un método que enliste cada reserva junto a la cantidad total de avistamientos que
    registró en toda su superficie (la suma de toda su matriz rectangular).
    3. Un método que determine e informe cuál fue la coordenada o sector específico ([fila,
    columna]) que registró la mayor concentración de avistamientos de toda la red de
    reservas, indicando a qué reserva pertenece.*/
    class ReservaNatural
        {
            private string nombreReserva;
            private int[,] avistamientos;

            public ReservaNatural()
            {
                avistamientos = new int[3, 3];

                Console.Write("Ingrese nombre de la reserva: ");
                nombreReserva = Console.ReadLine();

                for (int t = 0; t < 3; t++)
                {
                    for (int a = 0; a < 3; a++)
                    {
                        Console.Write("Avistamientos en [" + t + "," + a + "]: ");
                        avistamientos[t, a] = int.Parse(Console.ReadLine());
                    }
                }
            }

            public string RetornarNombre()
            {
                return nombreReserva;
            }

            public int TotalAvistamientos()
            {
                int suma = 0;

                for (int t = 0; t < 3; t++)
                {
                    for (int a = 0; a < 3; a++)
                    {
                        suma += avistamientos[t, a];
                    }
                }

                return suma;
            }
             public int[,] RetornarMatriz()
            {
            return avistamientos;
             }
    }

        class CentroEcologico
        {
            private ReservaNatural[] reservas;

            public CentroEcologico()
            {
                reservas = new ReservaNatural[3];

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Reserva " + (i + 1));
                    reservas[i] = new ReservaNatural();
                }
            }

            public void MostrarTotales()
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine( " La cantidad total de avistamientos en " + reservas[i].RetornarNombre() + " es de " + reservas[i].TotalAvistamientos()
                    );
                }
            }

            public void MayorAvistamiento()
            {
            int mayor = reservas[0].RetornarMatriz()[0, 0];
            string nombre = "";
            int filaMayor = 0;
            int columnaMayor = 0;

            for (int i = 0; i < 3; i++)
            {
                int[,] matriz = reservas[i].RetornarMatriz();

                for (int t = 0; t < 3; t++)
                {
                    for (int a = 0; a < 3; a++)
                    {
                        if (matriz[t, a] > mayor)
                        {
                            mayor = matriz[t, a];
                            nombre = reservas[i].RetornarNombre();
                            filaMayor = t;
                            columnaMayor = a;
                        }
                    }
                }
            }

            Console.WriteLine("Reserva con mayor avistamientos: " + nombre);
            Console.WriteLine("Coordenada: [" + filaMayor + "," + columnaMayor + "]");
            Console.WriteLine("Cantidad: " + mayor);
        }
        
            static void Main(string[] args)
            {
                CentroEcologico c = new CentroEcologico();
                c.MostrarTotales();
                c.MayorAvistamiento();
                Console.ReadKey();
            }
        }
    }