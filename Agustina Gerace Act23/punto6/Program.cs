using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto6
{
    /*6-
    Una biblioteca pública gestiona de forma digital su catálogo de obras literarias
    para organizar la consulta de ejemplares por parte de los lectores.
     Crear la clase Libro que contenga como atributos privados: titulo
    (string) y anioPublicacion (int). Definir sus propiedades de solo lectura y
    un constructor que reciba tit y anio.
     Crear la clase BibliotecaCentral que administre una lista de objetos
    List.
     Métodos en BibliotecaCentral:
    1. CargarCatalogo(): Solicitar por teclado títulos y años de
    publicación para agregar libros a la lista mediante .Add(). La carga
    finaliza cuando el usuario ingresa la palabra &quot;FIN&quot; como título.
    2. ListarCatalogo(): Mostrar en pantalla todos los libros del catálogo
    junto a la cantidad total de obras registradas mediante la propiedad
    .Count.
    3. FiltrarPorAnio(): Solicitar al usuario un año determinado e
    imprimir en consola únicamente aquellos libros cuyo año de
    publicación sea menor a dicho valor.
    4. RemoverLibro(): Pedir al usuario el título de un libro y, utilizando
    los métodos de búsqueda y remoción de listas, eliminarlo de la
    colección si se encuentra presente.*/
    class Libro
    {
        private string titulo;
        private int aniopublicacion;
        public Libro(string tit, int anio)
        {
            titulo = tit;
            aniopublicacion = anio;
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public int Anio
        {
            get { return Anio; }
            set { Anio = value; }
        }
    }
    class Bibliotecacentral
    {
        private List<Libro> libros = new List<Libro>();
        public void CargarCatalogo()
        {
            string titulo;
            int anio;
            do
            {
                Console.Write("ingresar titulo del libro (FIN para finalizar): ");
                titulo = Console.ReadLine();
                Console.Write("ingresar año de publicacion del libro: ");
                string linea = Console.ReadLine();
                anio = int.Parse(linea);
                Libro libro = new Libro(titulo, anio);
                libros.Add(libro);
            } while (titulo == "FIN");
        }
        public void ListarCatalogo()
        {
            foreach (Libro libro in libros)
            {
                Console.WriteLine(libro.Titulo + " ");
                Console.WriteLine(libro.Anio);
                Console.WriteLine();
            }
            Console.WriteLine("cantidad de libros registrados: " + libros.Count());
        }
        public void FiltrarPorAnio()
        {
            Console.Write("ingresar año de publicacion del libro: ");
            string linea = Console.ReadLine();
            int anio = int.Parse(linea);
            foreach (Libro libro in libros)
            {
                if (libro.Anio < anio)
                {
                    Console.WriteLine(libro.Titulo + " ");
                    Console.WriteLine(libro.Anio);
                    Console.WriteLine();
                }
            }
        }
        public void RemoverLibro()
        {
            Console.Write("ingresar el titulo del libro a remover: ");
            string tit = Console.ReadLine();
            for (int a = libros.Count(); a >= 0; a--)
            {
                if (libros[a].Titulo == tit)
                {
                    libros.RemoveAt(a);
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bibliotecacentral bc = new Bibliotecacentral();
            bc.CargarCatalogo();
            bc.ListarCatalogo();
            bc.FiltrarPorAnio();
            bc.RemoverLibro();
            Console.ReadKey();
        }
    }
}
