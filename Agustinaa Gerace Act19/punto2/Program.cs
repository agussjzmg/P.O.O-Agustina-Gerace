using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    /*2. Crear una clase parcial Libro.
    En el primer archivo, declarar las propiedades Título, Autor y Páginas. Validar que la
    cantidad de páginas sea mayor a 10. Valores cargados desde consola
    En el segundo archivo, agregar un método Resumen() que muestre el título, autor y
    si el libro es corto (menos de 100 páginas) o largo.
    Desde la clase principal, cargar 2 libros y mostrar cuál es el más extenso.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            libro[] libros = new libro[2];

            int mayor = 0;
            string mayorN = "";

            for (int a = 0; a < 2; a++)
            {
                libros[a] = new libro();
                libros[a].resumen();
                if (libros[a].Paginas > mayor)
                {
                    mayor = libros[a].Paginas;
                    mayorN = libros[a].Titulo;
                }
            }
            Console.WriteLine("el libro mas extenso es: " + mayorN + " con " + mayor + " paginas");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
