using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    partial class libro
    {
        public libro()
        {
            Console.Write("ingrese titulo: ");
            titulo = Console.ReadLine();
            Console.Write("ingrese autor: ");
            autor = Console.ReadLine();
            do
            {
                Console.Write("cantidad de paginas (mayor a 10): ");
                string linea = Console.ReadLine();
                paginas = int.Parse(linea);
            }
            while (paginas <= 10);
        }
        public void resumen()
        {
            Console.WriteLine("titulo: " + titulo);
            Console.WriteLine("autor: " + autor);
            if (paginas < 100)
            {
                Console.WriteLine("libro corto");
            }
            else
            {
                Console.WriteLine("libro largo");
            }
            Console.WriteLine();
        }
    }
}