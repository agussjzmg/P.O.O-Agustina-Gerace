using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4. En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada
            cuenta corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe
            finalizar al ingresar un valor negativo en el número de cuenta.
            Se pide confeccionar un programa que lea los datos de las cuentas corrientes e
            informe:
            a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo
            que:
            Estado de la cuenta:
            ○ “Acreedor” si el saldo es &gt;0.
            ○ “Deudor” si el saldo es &lt;0.
            ○ “Nulo” si el saldo es =0.
            b) La suma total de los saldos acreedores.

            correcciones: 2. El punto 4 no corta de primeras cuando ingreso un numero de cuenta negativo. 
            Además, en el repositorio hay dos carpetas con el mismo punto 4. Revisar.
        */
            int saldo = 0;
            int resultado = 0;
            int numerocuenta = 0;
            string linea;
            Console.Write("numero de cuenta: ");
            linea = Console.ReadLine();
            numerocuenta = int.Parse(linea);
            while (numerocuenta >= 0)
            {
                Console.Write("saldo: ");
                linea = Console.ReadLine();
                saldo = int.Parse(linea);
                if (saldo > 0)
                {
                    Console.WriteLine("acreedor");
                    resultado = resultado + saldo;
                }
                else
                {
                    if (saldo < 0)
                    {
                        Console.WriteLine("deudor");

                    }
                    else
                    {
                        Console.WriteLine("nulo");

                    }
                }
                Console.WriteLine("saldo acreedores: " + resultado);
            }
            Console.ReadKey();
        }
    }
}
