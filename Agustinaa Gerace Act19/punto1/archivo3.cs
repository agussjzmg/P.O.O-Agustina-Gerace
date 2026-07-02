using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    partial class reservaHotel
    {
        protected int precio;

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public void CalcularTotal()
        {
            if (tipohabitacion == "simple")
            {
                precio = 5000;
            }
            else if (tipohabitacion == "doble")
            {
                precio = 8000;
            }
            else if (tipohabitacion == "suite")
            {
                precio = 12000;
            }

            precio = precio * cantidadnoches;
        }
    }
}