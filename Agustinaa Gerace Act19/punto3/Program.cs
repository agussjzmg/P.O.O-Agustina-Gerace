using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
/*3. Armar una clase parcial JuegoArcade.
En el primer archivo, definir las propiedades NombreJuego, PuntajeMaximo, y
NivelDificultad (de 1 a 5). Valores cargados desde consola
En el segundo archivo, implementar un método que indique si un puntaje ingresado
supera el récord o no.
Desde Main, simular 4 partidas, mostrar qué jugador rompió el récord de su juego.*/
        internal class Program
        {
            static void Main(string[] args)
            {
                juegoArcade[] juegos = new juegoArcade[4];
                string mayN = "";
                int may = 0;
                for (int a = 0; a < 4; a++)
                {
                    Console.WriteLine("Partida " + (a + 1));

                    juegos[a] = new juegoArcade();
                    Console.Write("Nombre del jugador: ");
                    string jugador = Console.ReadLine();
                    juegos[a].SuperaRecord();
                    if (juegos[a].Puntajejugador > may)
                    {
                        may = juegos[a].Puntajejugador;
                        mayN = jugador;
                    }
                }
                Console.WriteLine("el jugador que rompió el record fue: " + mayN);
                Console.WriteLine("puntaje: " + may);
                Console.ReadKey();
            }
        }
    }
}
