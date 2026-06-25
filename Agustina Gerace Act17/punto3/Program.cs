using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    /*3. Fábrica de Computadoras (Herencia y Constructores con base)
    Crear una clase base llamada Computadora que contenga los atributos Marca y
    MemoriaRAM (en GB). Definir un constructor que reciba estos dos valores obligatoriamente.
    Luego, definir dos clases derivadas de la clase base:
     Notebook: que añade el atributo propio TamanoPantalla (en pulgadas).
     Escritorio: que añade el atributo propio PotenciaFuente (en Watts).
    Cada una de estas clases derivadas debe poseer su propio constructor, el cual debe recibir
    tanto los atributos específicos como los de la clase base, transfiriendo estos últimos a la
    clase Computadora mediante el uso explícito de la palabra clave base. Instanciar un objeto
    de cada clase derivada en el Main y mostrar la totalidad de sus datos por consola.*/
    class Computadora
    {
        protected string marca;
        protected int memoria;
        public string Marca
        {
            set { marca = value; }
            get { return marca; }
        }
        public int Memoria
        {
            set { memoria = value; }
            get { return memoria; }
        }
        public Computadora(string marca, int memoria)
        {
            Marca = marca;
            Memoria = memoria;
        }
        public void ImprimirC()
        {
            Console.WriteLine("COMPUTADORA: ");
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Memoria Ram: " + Memoria + "gb");
        }
    }
    class Notebook : Computadora
    {
        protected float tamañoPantalla;
        public float TamañoPantalla
        {
            get { return tamañoPantalla; }
            set { tamañoPantalla = value; }
        }
        public Notebook(string marca, int memoria, float tamañoPantalla) : base(marca, memoria)
        {
            TamañoPantalla = tamañoPantalla;
        }
        public void ImprimirN()
        {
            Console.WriteLine("NOTEBOOK: ");
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Memoria Ram: " + Memoria + "gb");
            Console.WriteLine("Tamaño de la pantalla: " + TamañoPantalla + "pulgadas");
        }

    }
        class Escritorio : Computadora
    {
        protected double potenciaFuerte;
        public double PotenciaFuerte
        {
            get { return potenciaFuerte; }
            set { potenciaFuerte = value; }
        }
        public Escritorio(string marca, int memoria, double potenciaFuerte) : base(marca, memoria)
        {
            PotenciaFuerte = potenciaFuerte;
        }
        public void ImprimirE()
        {
            Console.WriteLine("ESCRITORIO: ");
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Memoria Ram: " + Memoria + "gb");
            Console.WriteLine("Potencia de la fuente: " + PotenciaFuerte + "watts");
        }

        static void Main(string[] args)
        {
            Computadora c = new Computadora("Apple", 4);
            c.ImprimirC();
            Notebook n = new Notebook("Toshiba", 3, 10) ;
            n.ImprimirN();
            Escritorio e = new Escritorio("DELL", 6, 67);
            e.ImprimirE();
            Console.ReadKey();
        }
    }
}