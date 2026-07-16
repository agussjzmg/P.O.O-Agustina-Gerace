using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    /*Actividad 2: Posicionamiento de elementos en consola
    Problema:
    Definir una clase ElementoPantalla con atributos: nombre, posX y posY.
     Implementar propiedades y un constructor que cargue valores.
     Crear un método Mostrar() que use Console.SetCursorPosition() para ubicar el
    nombre en pantalla y Console.CursorVisible para ocultar el cursor.
     Generar un vector de 4 elementos y mostrarlos en distintas posiciones en la
    consola.*/
    class elementoPantalla
    {
        private string nombre;
        private int posx;
        private int posy;
        public elementoPantalla()
        {
            Console.Write("ingresar el nombre de la clase: ");
            nombre = Console.ReadLine();
            Console.Write("ingresar la posicion del cursor sobre el eje x: ");
            string linea = Console.ReadLine();
            posx = int.Parse(linea);
            Console.Write("ingresar la posicion del cursor sobre el eje y");
            linea = Console.ReadLine();
            posy = int.Parse(linea);
        }
        public void mostrar()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(posx, posy);
            Console.Write(nombre);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            elementoPantalla[] elementos = new elementoPantalla[4];
            for (int t = 0; t < elementos.Length; t++)
            {
                elementos[t] = new elementoPantalla();
                elementos[t].mostrar();
            }
            Console.ReadKey();
        }
    }
}

