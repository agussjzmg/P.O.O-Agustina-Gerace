using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    /*3. Competencia de Atletismo
    Plantear una clase llamada Atleta que tenga como atributos privados el Nombre y el TiempoSegundos (tiempo que tardó en completar una carrera). Definir un constructor para ingresar ambos datos.
    Luego, crear una clase llamada Carrera que administre 3 objetos de la clase Atleta como atributos de la clase.
    Definir los siguientes métodos en la clase Carrera:
    Un constructor que cargue los datos de los 3 atletas de la carrera.
    Un método que imprima los nombres de los atletas junto con sus marcas de tiempo.
    Un método que calcule e imprima el tiempo promedio de la carrera.
    Un método que informe el nombre del atleta ganador de la carrera (aquel que completó la prueba en el menor tiempo).
    Un método que muestre a los atletas que superaron el promedio.
    */
    internal class Atleta
    {
        private string nombre;

        private double tiempoSegundos;

        public Atleta()
        {
            string linea;
            Console.Write("Ingrese el nombre del atleta: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el tiempo en segundos: ");
            linea = Console.ReadLine();
            tiempoSegundos = double.Parse(linea);
        }

        public string NombreAtleta()
        {
            return nombre;
        }

        public double Tiempo()
        {
            return tiempoSegundos;
        }
    }

    class Carrera
    {
        private Atleta[] atletas;

        public Carrera()
        {
            atletas = new Atleta[3];
            for (int i = 0; i < 3; i++)
            {
                atletas[i] = new Atleta();
            }
        }

        public void Imprimir()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Atleta: " + atletas[i].NombreAtleta() + " su marca de tiempo es de: " + atletas[i].Tiempo() + " segundos");
            }
        }

        public void CalcularPromedio()
        {
            double suma = 0;
            for (int i = 0; i < 3; i++)
            {
                suma = suma + atletas[i].Tiempo();
            }
            double promedio = suma / 3;
            Console.WriteLine("El tiempo promedio de la carrera es: " + promedio );
        }

        public void Ganador()
        {
            double menor = atletas[0].Tiempo();
            string nombreGanador = atletas[0].NombreAtleta();

            for (int i = 1; i < 3; i++)
            {
                if (atletas[i].Tiempo() < menor)
                {
                    menor = atletas[i].Tiempo();
                    nombreGanador = atletas[i].NombreAtleta();
                }
            }
            Console.WriteLine("El ganador es: " + nombreGanador + " con un tiempo de " + menor );
        }

        public void SuperaronPromedio()
        {
            double suma = 0;
            for (int i = 0; i < 3; i++)
            {
                suma = suma + atletas[i].Tiempo();
            
            double promedio = suma / 3;

            if (atletas[i].Tiempo() > promedio)
                {
                    Console.WriteLine("Los atletas que superaron el promedio son: " + atletas[i].NombreAtleta()  );
                }
            }
        }

        static void Main(string[] args)
        {
            Carrera c = new Carrera();
            c.Imprimir();
            c.CalcularPromedio();
            c.Ganador();
            c.SuperaronPromedio();
            Console.ReadKey();
        }
    }
}
