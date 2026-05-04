using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
   //4. Se realiza una evaluación a 6 docentes por parte de sus alumnos. Se registran
   //sus nombres y puntajes promedio obtenidos (de 1 a 10).
   //Cargar sus datos en vectores paralelos, mostrar docente con calificación más
   //alta y más baja, ordenar los vectores de mayor a menor de acuerdo con la
   //calificación y mostrar en pantalla la cantidad de docentes que aprobaron y
   //desaprobaron (tomando como base que se aprueba con una nota mayor o igual
   //a 6)
    internal class punto4
    {
        private string[] doc;
        private int[] punt;
        private int alta = 0;
        private int baja = 1000000000;
        public void Cargar()
        {
            doc = new string[6];
            punt = new int[6];
            for (int i = 0; i < doc.Length; i++)
            {

                Console.Write("ingrese el nombre del docente ");
                string linea = Console.ReadLine();
                doc[i] = linea;
                Console.Write("ingrese la nota del docente: ");
                linea = Console.ReadLine();
                punt[i] = int.Parse(linea);
            }
        }
        public void NotaAlta()
        {
            string NomAlt = "";

            for (int i = 0; i < doc.Length; i++)
            {
                if (punt[i] > alta)
                {
                    alta = punt[i];
                    NomAlt = doc[i];
                }
            }

            Console.WriteLine("La nota más alta es de: " + NomAlt + " con un: " + alta);
        }

        public void NotaBaja()
        {
            string NomBaj = "";

            for (int i = 0; i < doc.Length; i++)
            {
                if (punt[i] < baja)
                {
                    baja = punt[i];
                    NomBaj = doc[i];
                }
            }

            Console.WriteLine("La nota más baja es de: " + NomBaj + " con un: " + baja);
        }
        public void ordenarMayor()
        {
            string aux;
            int auxi;

            Console.WriteLine("notas ordenadas de mayor a menor: ");

            for (int i = 0; i < punt.Length - 1; i++)
            {
                for (int a = 0; a < punt.Length - 1 - i; a++)
                {
                    if (punt[a] < punt[a + 1])
                    {
                        auxi = punt[a];
                        punt[a] = punt[a + 1];
                        punt[a + 1] = auxi;

                        aux = doc[a];
                        doc[a] = doc[a + 1];
                        doc[a + 1] = aux;
                    }
                }
            }

            for (int i = 0; i < punt.Length; i++)
            {
                Console.WriteLine(doc[i] + ": " + punt[i]);
            }
        }
        public void aprobaron()
        {
            int aprobados = 0;
            int desaprobados = 0;
            for (int i = 0; i < doc.Length; i++)
            {
                if (punt[i] >= 6)
                {
                    aprobados++;
                }
                else
                {
                    desaprobados++;
                }
            }
            Console.WriteLine("cantidad de docentes aprobados:" + aprobados);
            Console.WriteLine("cantidad de docentes desaprobados:" + desaprobados);
        }

        static void Main(string[] args)
        {
            punto4 p4 = new punto4();
            p4.Cargar();
            p4.NotaAlta();
            p4.NotaBaja();
            p4.ordenarMayor();
            p4.aprobaron();
            Console.ReadKey();
        }
    }
}
