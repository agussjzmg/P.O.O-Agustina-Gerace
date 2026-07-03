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
     class ElementoPantalla
    {
        private string nombre;
        private int posX;
        private int posY;
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int PosX
        {
            set { posX = value; }
            get { return posX; }
        }
        public int PosY
        {
            set { posY = value; }
            get { return posY; }
        }
        public ElementoPantalla(string nombre, int posX, int posY)
        {
            Nombre = nombre;
            PosX = posX;
            PosY = posY;
        }
        public void Mostrar() 
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(PosX, PosY);
            Console.WriteLine("Nombre: " + Nombre);
        }
        static void Main(string[] args)
        {
            ElementoPantalla ep = new ElementoPantalla("Agus", 30, 1);
            ElementoPantalla ep1 = new ElementoPantalla("Thomy", 28, 3);
            ElementoPantalla ep2 = new ElementoPantalla("Mateo", 26, 5);
            ElementoPantalla ep3 = new ElementoPantalla("Vicky", 24, 7);
            ep.Mostrar();
            ep1.Mostrar();
            ep2.Mostrar();
            ep3.Mostrar();

        }
    }
}
