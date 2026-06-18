using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
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
            Console.Write("Ingrese el nombre del producto: ");
            Nombre = Console.ReadLine();
            do
            {
                Console.Write("Ingrese el precio: ");
                linea = Console.ReadLine();
                Precio = float.Parse(linea);
                if (Precio <= 0)
                    Console.WriteLine("el precio tiene que ser mayor a 0.");
            }
            while (Precio <= 0);
            int stocki;
            do
            {
                Console.Write("Ingrese el stock: ");
                linea = Console.ReadLine();
                stocki = int.Parse(linea);
                if (stocki < 0)
                    Console.WriteLine("el stock no puede ser negativo.");
            }
            while (stocki < 0);
            Stock = stocki;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public float Precio
        {
            get { return precio; }
            set { if (value > 0) precio = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { if (value >= 0) stock = value; }
        }
    }

    class Inventario
    {
        private Producto[] productos;

        public Inventario()
        {
            productos = new Producto[3];

            for (int t = 0; t < productos.Length; t++)
            {
                Console.WriteLine("Producto n° " + (t + 1));
                productos[t] = new Producto();
            }
        }

        public void Mostrar()
        {
            for (int t = 0; t < productos.Length - 1; t++)
            {
                for (int a = t + 1; a < productos.Length; a++)
                {
                    if (productos[t].Precio > productos[a].Precio)
                    {
                        Producto aux = productos[t];
                        productos[t] = productos[a];
                        productos[a] = aux;
                    }
                }
            }
        }
        public void bajoalto()
        {
            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine(
                    "Nombre: " + productos[i].Nombre +
                    " Precio: " + productos[i].Precio +
                    " Stock: " + productos[i].Stock);
            }
            Producto masBarato = productos[0];
            Producto masCaro = productos[productos.Length - 1];

            Console.WriteLine(
                "El mas barato es: " + masBarato.Nombre + " con un precio de " + masBarato.Precio);
            Console.WriteLine(
                "El mas caro es: " + masCaro.Nombre + " con un precio de " + masCaro.Precio);
        }

        static void Main(string[] args)
        {
            Inventario i = new Inventario();
            i.Mostrar();
            i.bajoalto();
            Console.ReadKey();
        }
    }
}