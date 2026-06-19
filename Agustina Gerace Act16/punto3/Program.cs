using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    /*Crear una clase base Vehículo que contenga atributos marca y
    velocidadMaxima.
    Definir dos clases derivadas: Auto y Moto, que hereden de Vehículo. Cada
    una debe tener un constructor que reciba los valores de los atributos base
    mediante la palabra clave base, y un atributo propio (cantidadPuertas en
    Auto, cilindrada en Moto).
    Crear un objeto de cada clase y mostrar todos sus datos por consola.*/
    class Vehículo
    {
        protected string marca;
        protected float vel;
        public Vehículo()
        {
            Console.Write("ingresar marca: ");
            Marca = Console.ReadLine();
            Console.Write("ingresar velocidad maxima: ");
            string linea = Console.ReadLine();
            Vel = float.Parse(linea);
        }
        public string Marca
        {
            set { marca = value; }
            get { return marca; }
        }
        public float Vel
        {
            set { vel = value; }
            get { return vel; }
        }
    }
    class Auto : Vehículo
    {
        private int puertas;
        public Auto()
        {
            Console.Write("ingresar la cantida de puertas del auto: ");
            string linea = Console.ReadLine();
            puertas = int.Parse(linea);
        }
        public void imprimir()
        {
            Console.WriteLine("velocidad del auto: " + Vel);
            Console.WriteLine("marca del auto: " + Marca);
            Console.WriteLine("cantidad de puertas del auto: " + puertas);

        }
    }
    class Moto : Vehículo
    {
        private int cilindrada;
        public Moto()
        {
            Console.Write("ingresar la cilindrada de la moto: ");
            string linea = Console.ReadLine();
            cilindrada = int.Parse(linea);
        }
        public void imprimir()
        {
            Console.WriteLine("velocidad de la moto: " + Vel);
            Console.WriteLine("marca de la moto: " + Marca);
            Console.WriteLine("cilindrada de la moto: " + cilindrada);

        }
        static void Main(string[] args)
        {
            Auto a = new Auto();
            a.imprimir();
            Moto m = new Moto();
            m.imprimir();
            Console.ReadKey();
        }
    }
}
