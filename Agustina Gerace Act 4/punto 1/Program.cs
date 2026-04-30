using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
/* 1. En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y
$500, realizar un programa que lea los sueldos que cobra cada empleado e
informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más
de $300.Además el programa deberá informar el importe que gasta la empresa
en sueldos al personal.*/
            int empleados = 0;
            int sueldo = 0;
            int empmax = 0;
            int empmin = 0;
            int importe = 0;
            int cont = 0;
            string linea;
                //= Console.ReadLine();
            Console.Write("Cuantos empleados hay?");
            linea = Console.ReadLine();
            empleados = int.Parse(linea);

            while (cont < empleados) {
                Console.Write("sueldo (mayor a 100 y menor a 500):");
                linea = Console.ReadLine();
                sueldo = int.Parse(linea);
                importe = importe + sueldo;
                if (sueldo > 99 && sueldo < 300) 
                {
                    empmin++;
                }
                if (sueldo > 299 && sueldo < 501) 
                {
                    empmax++;
                }
                cont ++;
            }
            Console.WriteLine("los empleados con sueldo mayor a 100 y menor a 300 son:" + empmin);
            Console.WriteLine("los empleados con sueldo mayor a 300 y menor a 500 son:" + empmax);
            Console.WriteLine("el importe es un total de:" + importe );
            Console.ReadKey();
        }
    }
}
