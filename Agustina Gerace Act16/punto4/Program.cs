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
        public string TipoAlim
        {
            set { 
                alim = value;}
            get { 
                return alim;  }
        }
        public void imprimirA() 
        {
        Console.WriteLine("Mamiferos:");
        Console.WriteLine("su especie es " + Especie);
        Console.WriteLine("su tipo de alimentacion es " + TipoAlim);
        }
    }
    class Perro : Mamifero
    {
        private string nombre;
         public string Nombrep
        {
            set { 
                nombre = value;}
            get { 
                return nombre;  }
        }
         public void imprimirP() 
        {
        Console.WriteLine("Perros:");
        Console.WriteLine("su especie es " + Especie);
        Console.WriteLine("su nombre es " + Nombrep);
        }
        static void Main(string[] args)
        {
            Mamifero m = new Mamifero();
            m.Especie = "herbívoros";
            m.TipoAlim= "plantas";
            m.ImprimirA();
            Perro p = new Perro();
            p.Especie = "carnivoro"
            p.Nombrep = "Luna";
            p.ImprimirP();
            Console.ReadKey();
        }
    }
}
