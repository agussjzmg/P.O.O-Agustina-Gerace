using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    /*2. Catálogo de Películas (Encapsulación, Validación y Composición)
    Plantear una clase llamada Pelicula y otra clase llamada Catalogo.
    La clase Pelicula debe tener como atributos privados: Titulo, DuracionMinutos y Calificacion
    (un puntaje del 1 al 5). Definir las propiedades necesarias para acceder a estos atributos,
    asegurando mediante validaciones lógicas que:
     La duración en minutos sea estrictamente mayor a cero (0).
     La calificación se encuentre únicamente en el rango de 1 a 5 (de lo contrario, asignar
    un valor por defecto de 1).
    La clase Catalogo debe contener internamente un vector capaz de almacenar 3 objetos de
    la clase Pelicula. Definir un método dentro de Catalogo para mostrar por pantalla todas las
    películas ordenadas de mayor a menor en base a su duración. Además, el método debe
    informar el título de la película con mejor calificación y cuál es la película más corta del
    catálogo.*/
    class Pelicula
    {
        private string titulo;
        private double duramin;
        private int cali;
        public Pelicula()
        {
            string linea;
            Console.Write("Ingrese el nombre de la pelicula: ");
            titulo = Console.ReadLine();
            do
            {
                Console.Write("Ingrese la duracion en minutos: ");
                linea = Console.ReadLine();
                duramin = double.Parse(linea);
                if (duramin > 0)
                    Console.WriteLine("la duración tiene que ser mayor a 0.");
            }
            while (duramin > 0);

            Console.Write("Ingrese su calificación (del 1 al 5, otro número fuera de este rango será denominado como 1): ");
            linea = Console.ReadLine();
            cali = int.Parse(linea);
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public double Duracion
        {
            get { return duramin; }
            set { if (value > 0) duramin = value; }
        }

        public int Cali
        {
            get { return cali; }
            set
            {
                if (value > 0 && value < 6)
                {
                    cali = value;
                }
                else
                {
                    cali = 1;
                }
            }
        }
    }
        class Catalogo 
        {
        private Pelicula[] peli;
        public Catalogo()
        {
            peli = new Pelicula[3];
            for (int t = 0; t < 3; t++)
            {
                peli[t] = new Pelicula();
            }
        }
        public void Funciones()
        {
            string nombrepelim = peli[0].Titulo;
            string nombrepelic = peli[0].Titulo;
            double menor = peli[0].Duracion;
            double mejor = peli[0].Cali;
            Pelicula aux;
                for (int t = 0; t < peli.Length - 1; t++)
                {
                    for (int a = 0; a < peli.Length - 1 - t; a++)
                    {
                        if (peli[a].Duracion < peli[a + 1].Duracion)
                        {
                            aux = peli[a];
                            peli[a] = peli[a + 1];
                            peli[a + 1] = aux;
                        }
                    }
                Console.WriteLine(peli[t].Titulo + " - " + peli[t].Duracion );
            }

                for (int t = 1; t < peli.Length; t++)
            {
                if (peli[t].Cali > mejor)
                {
                    mejor = peli[t].Cali;
                    nombrepelim = peli[t].Titulo;
                }
                    if (peli[t].Duracion < menor)
                    {
                        menor = peli[t].Duracion;
                        nombrepelic = peli[t].Titulo;
                    }
                

            }
            Console.WriteLine("La pelicula con mejor calificacion es: " + nombrepelim + " con una calificacion de " + mejor);
            Console.WriteLine("La pelicula mas corta del catalogo es: " + nombrepelic + " con un tiempo de " + menor);
        
        }
        static void Main(string[] args)
        {
                Catalogo c = new Catalogo();
                c.Funciones();
        }
    }

}
