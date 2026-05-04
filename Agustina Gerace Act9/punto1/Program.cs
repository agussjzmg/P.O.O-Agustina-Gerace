using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    //1. Se desea desarrollar un programa que permita registrar los nombres y las
    //calificaciones de 6 estudiantes. Luego de cargar los datos, se debe mostrar el
    //nombre del estudiante con la nota más alta, junto con su nota. Al igual que el
    //estudiante con la nota más baja. Informar si hay estudiantes con la misma nota
    //máxima o mínima.
    internal class punto1
    {
        private string[] nombre;
        private int[] notas;
        private int alta = 0;
        private int baja = 1000000000;
        public void Cargar()
        {
            nombre = new string[6];
            notas = new int[6];
            for (int i = 0; i < nombre.Length; i++)
            {

                Console.Write("nombre del estudiante ");
                string linea = Console.ReadLine();
                nombre[i] = linea;
                Console.Write("notasa del estudiante: ");
                linea = Console.ReadLine();
                notas[i] = int.Parse(linea);
            }
        }
        public void NotaAlta()
        {
            string nomAlt = nombre[0];
            double alta = notas[0];

            for (int i = 1; i < nombre.Length; i++)
            {
                if (notas[i] > alta)
                {
                    alta = notas[i];
                    nomAlt = nombre[i];
                }
            }

            Console.WriteLine("La nota más alta es de: " + nomAlt + " con un: " + alta);
        }

        public void NotaBaja()
        {
            string nomBaj = nombre[0];
            double baja = notas[0];

            for (int i = 1; i < nombre.Length; i++)
            {
                if (notas[i] < baja)
                {
                    baja = notas[i];
                    nomBaj = nombre[i];
                }
            }

            Console.WriteLine("La nota más baja es de: " + nomBaj + " con un: " + baja);
        }
        public void Mismanota()
        {
            int contAlta = 0;
            int contBaja = 0;
            for (int i = 0; i < nombre.Length; i++)
            {
                if (notas[i] == alta)
                {
                    contAlta++;
                }
                if (notas[i] == baja)
                {
                    contBaja++;
                }
            }
            Console.WriteLine("la nota mas alta se repite " + contAlta + " veces");
            Console.WriteLine("la nota mas baja se repite " + contBaja + " veces");
        }

        static void Main(string[] args)
        {
            punto1 p1 = new punto1();
            p1.Cargar();
            p1.NotaAlta();
            p1.NotaBaja();
            p1.Mismanota();
            Console.ReadKey();
        }
    }
}
