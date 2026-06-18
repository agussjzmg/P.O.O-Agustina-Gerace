using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace punto1
{
    /*1. Confeccionar una clase Persona que tenga como atributos el nombre y la
    edad (definir las propiedades para poder acceder a dichos atributos). Definir
    un método para imprimirlos. Plantear una segunda clase Empleado que
    herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) y el
    método para imprimir su sueldo. Definir un objeto de la clase Persona y
    llamar a sus métodos y propiedades. También crear un objeto de la clase
    Empleado y llamar a sus métodos y propiedades.*/
    class Persona
    {
        protected string nombre;
        protected int edad;
        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }
        public void Imprimir()
        {
            Console.WriteLine(Nombre + " con una edad de " + Edad);
        }
    }
    class Empleado : Persona
    {
        protected float sueldo;
        public float Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }
        public void ImprimirSueldo()
        {
            Console.WriteLine(Nombre + " tiene un sueldo de: " + Sueldo);
        }

        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.Nombre = "Agustina";
            p.Edad = 26;
            p.Imprimir();
            Empleado e = new Empleado();
            e.Nombre = "Thomas";
            e.Edad = 27;
            e.Sueldo = 1200000;
            e.Imprimir();
            e.ImprimirSueldo();
            Console.ReadKey();
        }
    }
}