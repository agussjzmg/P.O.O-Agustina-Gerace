using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    /*1. Personal de un Gimnasio (Herencia Simple y Propiedades)
    Confeccionar una clase llamada PersonaGimnasio que tenga como atributos privados el
    Nombre y el DNI (definir sus respectivas propiedades de lectura y escritura). Plantear un
    método para imprimir estos datos básicos.
    Luego, crear una segunda clase llamada Profesor que herede de PersonaGimnasio. Añadir
    un atributo propio llamado Especialidad (con su propiedad correspondiente) y un método
    para imprimir todos los datos del profesor (incluyendo los heredados).
    En el programa principal (Main):
     Definir un objeto de la clase PersonaGimnasio, asignar valores a sus propiedades y
    llamar a su método de impresión.
     Crear un objeto de la clase Profesor, interactuar con sus propiedades y comprobar
    que puede acceder tanto a sus métodos propios como a los de la clase base.*/
    class PersonaGimnasio
    {
        protected string nombre;
        protected int DNI;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int dni
        {
            get { return DNI; }
            set { DNI = value; }
        }
        public void ImprimirB()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("DNI: " + dni);
        }
    }
        class Profesor : PersonaGimnasio
        {
        protected string espe;
        public string Espe
        {
            get { return espe; }
            set { espe = value; }
        }
        public void Imprimir() 
        {
            Console.WriteLine("Nombre del profesor = " + Nombre);
            Console.WriteLine("DNI = " + dni);
            Console.WriteLine("Especialidad = " + espe);
        }
    
        static void Main(string[] args)
        {
            PersonaGimnasio p = new PersonaGimnasio();
            p.Nombre = "Agustina";
            p.dni = 49554634;
            p.ImprimirB();
            Profesor e = new Profesor();
            e.Nombre = "Thomas";
            e.dni= 48351435;
            e.Espe = "entrenamiento en sala de musculación";
            e.Imprimir();
            Console.ReadKey();
        }
    
    }

}

