using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    /*3.
    Crear una clase base llamada SondaExploradora que contenga los atributos Modelo (string) y
    AutonomiaMinutos (int). Definir un constructor que reciba estos dos valores como parámetros y
    realice su asignación.
    Luego, definir dos clases derivadas de la clase base:
    ● SondaSubmarina: que añade el atributo propio PresionMaximaAtm (int, presión máxima
    soportada en atmósferas).
    ● RoverTerrestre: que añade el atributo propio CantidadRuedas (int).
    Cada una de estas clases derivadas debe poseer su propio constructor. El mismo debe recibir
    tanto el atributo específico como los heredados de la clase base, transfiriendo estos últimos a la
    clase SondaExploradora mediante el uso explícito de la palabra clave base.
    En el método Main, instanciar un objeto de cada clase derivada y mostrar la totalidad de sus
    parámetros unificados por consola.*/
    class SondaExploradora
    {
        private string modelo;
        private int automin;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public int AutoMin
        {
            get { return automin; }
            set { automin = value; }
        }
        public SondaExploradora(string modelo, int automin)
        {
            Modelo = modelo;
            AutoMin = automin;
        }
        public void ImprimirE()
        {
            Console.WriteLine("SONDA EXPLORADORA: ");
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Autonomia minutos: " + AutoMin);
        }
    }
        class SondaSubmarina : SondaExploradora
        {
        private int presionmaximaatm;
        public int PresionMaximaAtm
        {
            get { return presionmaximaatm; }
            set { presionmaximaatm = value; }
        }
        public SondaSubmarina(string modelo, int automin, int presionmaximaatm) : base (modelo, automin)
        { 
         PresionMaximaAtm = presionmaximaatm;
        }
        public void ImprimirS()
        {
            Console.WriteLine("SONDA SUBMARINA: ");
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Autonomia minutos: " + AutoMin);
            Console.WriteLine("Presión máxima soportada en atmósferas: " + PresionMaximaAtm);
        }
    }
        class RoverTerrestre : SondaExploradora
    {
        private int cantruedas;
        public int CantRuedas
        {
            get { return cantruedas; }
            set { cantruedas = value; }
        }
        public RoverTerrestre(string modelo, int automin, int cantruedas) : base(modelo, automin)
        { 
        CantRuedas = cantruedas;    
        }
        public void ImprimirT()
        {
            Console.WriteLine("ROVER TERRESTRE: ");
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Autonomia minutos: " + AutoMin);
            Console.WriteLine("Cantidad de ruedas: " + CantRuedas);
        }
        static void Main(string[] args)
        {
            SondaExploradora e = new SondaExploradora("DELL", 70);
            e.ImprimirE();
            SondaSubmarina s = new SondaSubmarina("Garnier", 65, 90);
            s.ImprimirS();
            RoverTerrestre t = new RoverTerrestre ("Rover", 56, 4);
            t.ImprimirT();
            Console.ReadKey();
        }
    }
}
