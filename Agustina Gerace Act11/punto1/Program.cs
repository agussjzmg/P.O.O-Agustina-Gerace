using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    /*1. Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como
    dato las temperaturas medias mensuales de dichos paises.
    Se pide ingresar el nombre del país y seguidamente las tres temperaturas medias
    mensuales.
    Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en
    memoria.
    a. Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
    b. Imprimir los nombres de las paises y las temperaturas medias mensuales de las
    mismas.
    c. Calcular la temperatura media trimestral de cada país.
    d. Imprimir los nombres de los paises y las temperaturas medias trimestrales.
    e. Imprimir el nombre del país con la temperatura media trimestral mayor.*/
    class matriz1
    {
        private float[,] temp;
        private string[] paises;
        private float[] tempmedia;

        public void Cargar()
        {
            paises = new String[4];
            temp = new float[4, 3];
            for (int t = 0; t < paises.Length; t++)
            {
                Console.Write("Ingrese el pais: ");
                paises[t] = Console.ReadLine();
                for (int a = 0; a < temp.GetLength(1); a++)
                {
                    Console.Write("Ingrese temperatura media mensual: ");
                    string linea;
                    linea = Console.ReadLine();
                    temp[t, a] = float.Parse(linea);
                }
            }
        }

        public void ObtenerTempMediaTrimestral() {
            tempmedia = new float[4];
            for (int t = 0; t < temp.GetLength(0); t++)
            {
                float suma = 0;
                for (int a = 0; a < temp.GetLength(1); a++)
                {
                    suma = suma + temp[t, a];
                }
                tempmedia[t] = suma / 3;
            }
        }

        public void Imprimir()
        {
            for (int t = 0; t < temp.GetLength(0); t++)
            {
                Console.Write(paises[t] + ": ");

                for (int a = 0; a < temp.GetLength(1); a++)
                {
                    Console.Write(temp[t, a] + " ");
                }

                Console.WriteLine();
            }
        }
        public void ImprimirTri() {

            Console.WriteLine("Temperatura media trimestral de cada país");
            for (int t = 0; t < tempmedia.Length; t++)
            {
                Console.WriteLine(paises[t] + " con " + tempmedia[t]);
            }
        }

        public void TempMayor() {
            float may = tempmedia[0];
            string nom = paises[0];
            for (int t = 0; t < tempmedia.Length; t++)
            {
                if (tempmedia[t] > may)
                {
                    may = tempmedia[t];
                    nom = paises[t];
                }
            }
            Console.WriteLine("El pais con mayor temperatura media trimestral es "
                + nom + " con una temperatura de " + may);

        }

        static void Main(string[] args)
        {
            matriz1 mat1 = new matriz1();
            mat1.Cargar();
            mat1.ObtenerTempMediaTrimestral();
            mat1.Imprimir();
            mat1.ImprimirTri();
            mat1.TempMayor();
            Console.ReadKey();
        }
    }
}
