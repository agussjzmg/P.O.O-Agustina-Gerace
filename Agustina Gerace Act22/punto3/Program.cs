using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    /*Actividad 3: Registro de entrenamientos
    Problema:
    Plantear una clase Entrenamiento con atributos: deportista y duración (en minutos).
     Incluir dos métodos RegistrarDuracion (sobrecarga de métodos):
    1. Uno que reciba horas y minutos y los convierta a minutos.
    2. Otro que reciba directamente los minutos.
     Crear una lista con 5 entrenamientos y mostrar el entrenamiento más largo y el
    más corto.
    */

    class entrenamiento
    {
        private string deportista;
        private int duracion;

        public string Deportista
        {
            get { return deportista; }
        }

        public int Duracion
        {
            get { return duracion; }
        }

        public entrenamiento()
        {
            Console.Write("ingrese el nombre del deportista: ");
            deportista = Console.ReadLine();
        }

        public void RegistrarDuracion(int horas, int minutos)
        {
            duracion = horas * 60 + minutos;
        }

        public void RegistrarDuracion(int minutos)
        {
            duracion = minutos;
        }

        public void Mostrar()
        {
            Console.WriteLine("deportista: " + deportista);
            Console.WriteLine("duración: " + duracion + " minutos");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<entrenamiento> lista = new List<entrenamiento>();

            entrenamiento e1 = new entrenamiento();
            e1.RegistrarDuracion(1, 30);
            lista.Add(e1);

            entrenamiento e2 = new entrenamiento();
            e2.RegistrarDuracion(90);
            lista.Add(e2);

            entrenamiento e3 = new entrenamiento();
            e3.RegistrarDuracion(2, 15);
            lista.Add(e3);

            entrenamiento e4 = new entrenamiento();
            e4.RegistrarDuracion(45);
            lista.Add(e4);

            entrenamiento e5 = new entrenamiento();
            e5.RegistrarDuracion(3, 0);
            lista.Add(e5);

            entrenamiento mayor = lista[0];
            entrenamiento menor = lista[0];

            foreach (entrenamiento e in lista)
            {
                if (e.Duracion > mayor.Duracion)
                {
                    mayor = e;
                }

                if (e.Duracion < menor.Duracion)
                {
                    menor = e;
                }
            }

            Console.WriteLine("entrenamiento más largo:");
            mayor.Mostrar();
            Console.WriteLine();
            Console.WriteLine("entrenamiento más corto:");
            menor.Mostrar();
            Console.ReadKey();
        }
    }
}
