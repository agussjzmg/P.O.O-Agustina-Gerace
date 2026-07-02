using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    partial class reservaHotel
    {
        protected string nombrecliente;
        protected int cantidadnoches;
        protected string tipohabitacion;

        public string Nombrecliente
        {
            get { return nombrecliente; }
            set { nombrecliente = value; }
        }

        public int Cantidadnoches
        {
            get { return cantidadnoches; }
            set { cantidadnoches = value; }
        }

        public string Tipohabitacion
        {
            get { return tipohabitacion; }
            set { tipohabitacion = value; }
        }

        public reservaHotel()
        {
            Console.Write("Ingrese nombre del cliente: ");
            nombrecliente = Console.ReadLine();

            do
            {
                Console.Write("Ingrese cantidad de noches: ");
                cantidadnoches = int.Parse(Console.ReadLine());

            } while (cantidadnoches <= 0);

            do
            {
                Console.Write("Ingrese tipo de habitación (simple, doble o suite): ");
                tipohabitacion = Console.ReadLine().ToLower();

            } while (tipohabitacion != "simple" &&
                     tipohabitacion != "doble" &&
                     tipohabitacion != "suite");
        }
    }
}