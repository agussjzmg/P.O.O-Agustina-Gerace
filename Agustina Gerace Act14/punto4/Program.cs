using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    /*4. Inventario de Sucursales 
    Plantear una clase llamada Articulo que tenga como atributos privados el NombreArticulo, el Precio y el StockActual. El constructor de la clase debe cargar estos atributos por teclado.
    Confeccionar otra clase llamada Sucursal que contenga un vector de 3 objetos de la clase Articulo. El constructor de Sucursal debe pedir el nombre o número de la sucursal y realizar la carga de los 3 artículos.
    Implementar en la clase Sucursal los siguientes métodos:
    Un método que imprima la lista de los artículos junto con su valor total en inventario (Precio * Stock).
    Un método que busque y muestre el nombre del artículo más caro del local.
    Un método que verifique e indique qué artículos de la sucursal requieren reposición urgente (aquellos cuyo stock sea menor o igual a 5 unidades).
    */
    class Articulo
    {
        private string nombre;
        private double precio;
        private int stock;

        public Articulo()
        {
            string linea;
            Console.Write("ingrese el nombre del articulo: ");
            nombre = Console.ReadLine();
            Console.Write("ingrese su precio: ");
            linea = Console.ReadLine();
            precio = double.Parse(linea);
            Console.Write("ingrese el stock del articulo: ");
            linea = Console.ReadLine();
            stock = int.Parse(linea);
        }
        public string RetornarNombre()
        {
            return nombre;
        }

        public double RetornarPrecio()
        {
            return precio;
        }

        public int RetornarStock()
        {
            return stock;
        }
    }
class Sucursal
   {
        private Articulo[] art;
        private string nombreSucu;

        public Sucursal()
        {
            Console.Write("Ingrese el nombre o numero de la sucursal: ");
            nombreSucu = Console.ReadLine();

            art = new Articulo[3];
            for (int t = 0; t < 3; t++)
            {
                art[t] = new Articulo();
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("Lista de articulos en el inventario de: " + nombreSucu);

            for (int t = 0; t < art.Length; t++)
            {
                double total = art[t].RetornarPrecio() * art[t].RetornarStock();

                Console.WriteLine(
                    art[t].RetornarNombre() +
                    " valor total: " + total);
            }
        }
        public void MasCaro()
        {
            double mayor = art[0].RetornarPrecio();
            string nomMayor = art[0].RetornarNombre();

            for (int t = 1; t < art.Length; t++)
            {
                if (art[t].RetornarPrecio() > mayor)
                {
                    mayor = art[t].RetornarPrecio();
                    nomMayor = art[t].RetornarNombre();
                }
            }

            Console.WriteLine("El articulo mas caro es: " + nomMayor);
        }
        public void RepoUrg()
        {

            for (int t = 0; t < art.Length; t++)
            {
                if (art[t].RetornarStock() <= 5)
                {
                    Console.WriteLine( "Articulo con reposición urgente: " + art[t].RetornarNombre());
                }
            }
        }


        static void Main(string[] args)
        {
            Sucursal s = new Sucursal();
            s.Imprimir();
            s.MasCaro();
            s.RepoUrg();
        }
    }
}
