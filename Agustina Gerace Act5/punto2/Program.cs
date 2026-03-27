using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 2. Realizar un programa que lea los lados de n triángulos, e informar:
            a) De cada uno de ellos, qué tipo de triángulo es: equilátero (tres lados
            iguales), isósceles (dos lados iguales), o escaleno (ningún lado igual)
            b) Cantidad de triángulos de cada tipo.
            c) Tipo de triángulo que posee menor cantidad. */

            int lado1;
            int num;
            int lado2;
            int lado3;
            int iso = 0;
            int esc = 0;
            int equi = 0;
            string linea;

            Console.WriteLine("cuantos triangulos quiere ingresar?");
            linea = Console.ReadLine();
            num = int.Parse(linea);

            for (int i = 0; i == num ; i++)    {
            Console.WriteLine("ingrese el primer lado del triàngulo: ");
            linea = Console.ReadLine();
            lado1 = int.Parse(linea);

            Console.WriteLine("ingrese el segundo lado del triàngulo: ");
            linea = Console.ReadLine();
            lado2 = int.Parse(linea);

            Console.WriteLine("ingrese el tercer lado del triàngulo: ");
            linea = Console.ReadLine();
            lado3 = int.Parse(linea);

            if (lado1 == lado2 &&  lado2 == lado3) {
                Console.Write(" Este triàngulo es equilatero ya que tiene todos sus lados iguales");
                equi ++;
            }
            else
            {
                    if (( lado1 == lado2 && lado2 != lado3 && lado1 != lado3) || (lado1 !=lado2 && lado2 == lado3 && lado1 != lado3) || (lado1 != lado2 && lado2 != lado3 && lado1 == lado3)) {

                Console.Write(" Este triàngulo es isoceles ya que tiene dos de sus lados iguales");
                iso++;
                }
             
            else
                {
                    if (lado1!=lado2 && lado2!=lado3)  {
                Console.Write(" Este triàngulo es escaleno ya que no tiene ninguno de sus lados iguales");
                esc++;
            }
                    }
                }
            }
            if ( esc <= equi && esc <= iso)
            {

            Console.WriteLine("los equilateros son: " + equi);
            Console.WriteLine("los isoceles son: " + iso);
            Console.WriteLine("los escalenos con menor cantidad son: " + esc);
            }
                else
                {
                    if (equi <= esc && equi <= iso)
            {
                Console.WriteLine("los equilateros con menor cantidad son: " + equi);
                Console.WriteLine("los isoceles son: " + iso);
                Console.WriteLine("los escalenos son: " + esc);
            }
                
                    else
                    {
                        if (iso <= equi && iso <= esc)
            {
                Console.WriteLine("los equilateros son: " + equi);
                Console.WriteLine("los isoceles con menor cantidad son: " + iso);
                Console.WriteLine("los escalenos son: " + esc);
            }
                    }
                }
            
            Console.ReadKey();
        }
    }
    
}
