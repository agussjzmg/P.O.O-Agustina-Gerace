using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    partial class juegoArcade
    {
        protected int puntajeJugador;
        public void SuperaRecord()
        {
            Console.WriteLine("puntaje maximo actual: " + puntajemaximo);

            Console.Write("ingrese puntaje del jugador: ");
            string linea = Console.ReadLine();
            puntajeJugador = int.Parse(linea);
            if (puntajeJugador > puntajemaximo)
            {
                puntajemaximo = puntajeJugador;
                Console.WriteLine("rompio record");
            }
            else
            {
                Console.WriteLine("no superó el record");
            }
        }
        public int Puntajejugador
        {
            set { puntajeJugador = value; }
            get { return puntajeJugador; }
        }
    }
}