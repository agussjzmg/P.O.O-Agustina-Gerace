using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4. Se cuenta con la siguiente información:
            ● Las edades de 20 estudiantes del turno mañana.
            ● Las edades de 30 estudiantes del turno tarde.
            ● Las edades de 15 estudiantes del turno noche.
            Las edades de cada estudiante deben ingresarse por teclado.
            a) Obtener el promedio de las edades de cada turno (tres promedios)
            b) Imprimir dichos promedios (promedio de cada turno)
            c) Mostrar por pantalla un mensaje que indique cuál de los tres turnos tiene un
            promedio de edades menor. */

            int edadtm =0;
            int num1;
            int num2;
            int num3;
            string linea;
            int edadtt = 0;
            int edadtn =0;
            int promediotm;
            int promediott;
            int promediotn;
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine("ingrese la edad de los alumnos de turno mañana: ");
                linea = Console.ReadLine();
                num1 = int.Parse(linea);
                edadtm = num1 + edadtm;
                
            }
            for (int i = 0; i <= 30; i++)
            {
                Console.WriteLine("ingrese la edad de los alumnos de turno tarde: ");
                linea = Console.ReadLine();
                num2 = int.Parse(linea);
                edadtt = num2 + edadtt;

            }
            for (int i = 0; i <= 15; i++)
            {
                Console.WriteLine("ingrese la edad de los alumnos de turno noche: ");
                linea = Console.ReadLine();
                num3 = int.Parse(linea);
                edadtn = num3 + edadtn;

            }
            promediotm = edadtm % 20;
            promediott = edadtt % 30;
            promediotn = edadtn % 15;
            if (promediotm < promediotn && promediotm < promediott)
            {
                Console.WriteLine("el mas bajo es el de turno mañana con un promedio de: " + promediotm);
                Console.WriteLine("el promedio de turno tarde es: " + promediott);
                Console.WriteLine("el promedio de turno noche es: " + promediotn);
            }
            if (promediott < promediotn && promediott < promediotm)
            {
                Console.WriteLine("el mas bajo es el de turno tarde con un promedio de: " + promediott);
                Console.WriteLine("el promedio de turno mañana es: " + promediotm);
                Console.WriteLine("el promedio de turno noche es: " + promediotn);
            }
            if (promediotn < promediotm && promediotn < promediott)
            {
                Console.WriteLine("el mas bajo es el de turno noche con un promedio de: " + promediotn);
                Console.WriteLine("el promedio de turno tarde es: " + promediott);
                Console.WriteLine("el promedio de turno mañana es: " + promediotm);
            }
            Console.ReadKey();
        }

    }
 }
