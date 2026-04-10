using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_4
{
    internal class punto4
    {
        /*4. Cargar un vector de 10 elementos y verificar posteriormente si el mismo está
        ordenado de menor a mayor y de mayor a menor.*/
        private int[] vector;

        public void Cargar()
        {

            vector = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un valor: ");
                string linea;
                linea = Console.ReadLine();
                vector[i] = int.Parse(linea);

            }
        }
        public void mayoramenor()
        {
            int cal= 0;
            int num = 100000000;
            for (int i = 0; i < 10; i++)
            { 
                if (vector[i] < num)
                {
                    cal++;
                }
                num = vector[i];
            }
            if (cal == 10)
            {
            Console.WriteLine("esta ordenado de mayor a menor");
            }
        }

        public void menoramayor()
        {
            int cal = 0;
            int num = -100000000;
            for (int i = 0; i < 10; i++)
            {
                if (vector[i] > num)
                {
                    cal++;
                }
                num = vector[i];
            }
            if (cal == 10)
            {  
            Console.WriteLine("esta ordenado de menor a mayor");
            }
        }
       
        static void Main(string[] args)
        {
            punto4 p4 = new punto4();
            p4.Cargar();
            p4.mayoramenor();
            p4.menoramayor();
            Console.ReadKey();
        }
    }
}
