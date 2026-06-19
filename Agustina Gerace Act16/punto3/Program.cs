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
        public Vehiculo()
        {
            Marca= marca;
            Vel= vel;
        }
    }
    class Auto : Vehículo
    {
        private int puertas;
        public int Puertas
        {
            set { puertas = value; }
            get { return puertas; }
        }
        public Auto() 
        {
        Puertas = puertas;
        }
        public void imprimir()
        {
            Console.WriteLine("Auto: ");
            Console.WriteLine("velocidad del auto: " + Vel);
            Console.WriteLine("marca del auto: " + Marca);
            Console.WriteLine("cantidad de puertas del auto: " + puertas);

        }
    }
    class Moto : Vehículo
    {
        private int cilindrada;
        public int Cili
        {
            set { cilindrada = value; }
            get { return cilindrada; }
        }
        public Moto() 
        {
        Cili = cilindrada;
        }
        public void imprimirm()
        {
            Console.WriteLine("Moto: ");
            Console.WriteLine("velocidad de la moto: " + Vel);
            Console.WriteLine("marca de la moto: " + Marca);
            Console.WriteLine("cilindrada de la moto: " + cilindrada);

        }
        static void Main(string[] args)
        {
            Auto a = new Auto();
            a.Marca = "Honda";
            a.Vel = 9999;
            a.Puertas = 4;
            a.imprimir();
            Moto m = new Moto();
            m.Marca= "Yamaha";
            m.Vel = 100;
            m.Cili = 600;
            m.imprimirm();
            Console.ReadKey();
        }
    }
}
