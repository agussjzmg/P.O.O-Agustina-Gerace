using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    /*Armar tres clases: Animal, Mamífero y Perro.
    La clase Animal debe tener un atributo especie.
    La clase Mamífero, que hereda de Animal, debe tener un atributo
    tipoAlimentacion.
    La clase Perro, que hereda de Mamífero, debe tener un atributo nombre.
    Cada clase debe tener un constructor que reciba los datos correspondientes
    y los imprima indicando a qué clase pertenecen. Los datos deben ser
    asignados previamente
    Crear un objeto de la clase Perro y verificar la ejecución en cadena de los
    constructores.*/
    class Animal
    {
        protected string especie;
        public Animal()
        {
            Console.Write("ingresar nombre de la especie: ");
            especie = Console.ReadLine();
            Console.WriteLine("nombre de la especie: " + especie);
        }
        public string Especie
        {
            set {
                especie = value;  }
            get{ 
                return especie;}
        }
    }
    class Mamifero : Animal
    {
        protected string alim;
        public Mamifero()
        {
            Console.Write("ingresar tipo de alimentacion del mamifero: ");
            alim = Console.ReadLine();
            Console.WriteLine("tipo de alimentacion: " + alim);
        }
        public string Alim
        {
            set { 
                alim = value;}
            get { 
                return alim;  }
        }
    }
    class Perro : Mamifero
    {
        private string nombre;
        public Perro()
        {
            Console.Write("ingresar nombre del perro: ");
            nombre = Console.ReadLine();
            Console.WriteLine("nombre del perro: " + nombre);
        }
        static void Main(string[] args)
        {
            //Mamifero m = new Mamifero();
            Perro p = new Perro();
            Console.ReadKey();
        }
    }
}
