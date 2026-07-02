using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    partial class juegoArcade
    {
        protected string nombrejuego;
        protected int puntajemaximo;
        protected int dificultad;

        public string Nombrejuego
        {
            set { nombrejuego = value; }
            get { return nombrejuego; }
        }

        public int Puntajemaximo
        {
            set { puntajemaximo = value; }
            get { return puntajemaximo; }
        }

        public int Dificultad
        {
            set { dificultad = value; }
            get { return dificultad; }
        }

        public juegoArcade()
        {
            Console.Write("nombre del juego: ");
            nombrejuego = Console.ReadLine();

            Console.Write("puntaje maximo: ");
            string linea = Console.ReadLine();
            puntajemaximo = int.Parse(linea);

            do
            {
                Console.Write("dificultad (1 a 5): ");
                linea = Console.ReadLine();
                dificultad = int.Parse(linea);
            }
            while (dificultad < 1 || dificultad > 5);
        }
    }
}