using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    /*2. Plantear una clase Producto y otra clase Inventario.
    La clase Producto debe tener como atributos privados el nombre, precio y
    stock. Definir propiedades para acceder a estos atributos, asegurando que el
    stock no pueda ser negativo y el precio sea mayor a cero.
    La clase Inventario debe contener 3 objetos de la clase Producto. Definir un
    método para mostrar todos los productos ordenados de menor a mayor en
    base al precio, además, mostrar el producto más caro y más barato del
    inventario.*/
     class Producto
    {
        private string nombre;
        private float precio;
        private int stock;

        public Producto()
        {
            string linea;
            Console.Write("ingrese el producto: ");
            nombre = Console.ReadLine();
            Console.Write("ingrese el precio: ");
            linea = Console.ReadLine();
            precio = float.Parse(linea);
            Console.Write("ingrese el stock del producto: ");
            linea = Console.ReadLine();
            stock = int.Parse(linea);

            }
           
        static void Main(string[] args)
        {
        }
    }
}
