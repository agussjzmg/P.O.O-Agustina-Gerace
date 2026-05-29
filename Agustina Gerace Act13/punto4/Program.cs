using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    /*4. Plantear una clase Alumno que tenga los atributos privados: nombre y un
    vector de 4 notas. Definir un constructor que solicite el ingreso del nombre del
    alumno y sus 4 calificaciones.
    Luego, confeccionar una clase Curso que contenga un vector de 3 objetos
    Alumno.
    Agregar los siguientes métodos:
    a) Un método que imprima el nombre de cada alumno y su promedio.
    b) Un método que muestre el nombre del alumno con el promedio más
    alto.
    c) Un método que indique qué alumnos tienen al menos una nota
    desaprobada (nota menor a 6)*/
    class Alumno
    {
        private string nom;
        private float[] notas;
        public Alumno()
        {
            notas = new float[4];
            string linea;
            Console.Write("ingrese el nombre del alumno: ");
            nom = Console.ReadLine();
            for (int t = 0; t < 4; t++)
            {
                Console.Write("ingrese las notas: ");
                linea = Console.ReadLine();
                notas[t] = float.Parse(linea);
            }
        }
        public float Promedio()
        {
            float suma = 0;

            for (int t = 0; t < 4; t++)
            {
                suma = suma + notas[t];
            }

            float promedio = suma / 4;
            return promedio;
        }
        public string NomAlumno()
        {
            return nom;
        }
        public bool Desaprobado()
        {
            for (int t = 0; t < 4; t++)
            {
                if (notas[t] < 6)
                {
                    return true;
                }
            }

            return false;
        }
    }

        class Curso
        {
            private Alumno[] alumnos;

            public Curso()
            {
                alumnos = new Alumno[3];

                for (int t = 0; t < 3; t++)
                {
                    Console.WriteLine("alumno " + (t + 1));
                    alumnos[t] = new Alumno();
                }
            }
            public void ImprimirPromedios()
            {
                for (int t = 0; t < 3; t++)
                {
                    Console.WriteLine(alumnos[t].NomAlumno() + " con un promedio de: " + alumnos[t].Promedio());
                }
            }
            public void PromedioMasAlto()
            {
                float mayor = alumnos[0].Promedio();
                string nombre = alumnos[0].NomAlumno();

                for (int t = 1; t < 3; t++)
                {
                    if (alumnos[t].Promedio() > mayor)
                    {
                        mayor = alumnos[t].Promedio();
                        nombre = alumnos[t].NomAlumno();
                    }
                }

                Console.WriteLine("El alumno con mayor promedio es: " + nombre);
            }
            public void AlumnoDes()
            {
            Console.WriteLine("Alumnos que tienen al menos una nota desaprobada: ");
         
            for (int t = 0; t < 3; t++)
            {
                if (alumnos[t].Desaprobado())
                {
                    Console.WriteLine(alumnos[t].NomAlumno());
                }
            }
        }
        static void Main(string[] args)
            {
                Curso c = new Curso();

                c.ImprimirPromedios();
                c.PromedioMasAlto();
                c.AlumnoDes();
                Console.ReadKey();
            }
         }
}