using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    /*1.
    Confeccionar una clase llamada DispositivoEnergia que tenga como atributos privados el
    CodigoIdentificador (string) y la GeneracionKwh (double, que representa los Kilowatts-hora
    generados). Definir sus respectivas propiedades de lectura y escritura, validando que la
    generación no sea un valor negativo (en caso de serlo, asignarle 0). Plantear un método para
    imprimir estos datos básicos.
    Luego, crear una segunda clase llamada PanelSolar que herede de DispositivoEnergia. Añadir
    un atributo propio privado llamado AreaMetros (double, que representa la superficie del panel
    en metros cuadrados) con su propiedad correspondiente (validando que sea mayor a cero).
    Implementar un método para imprimir todos los datos del panel, incluyendo los heredados.
    En el programa principal (Main):
    ● Crear un objeto de la clase DispositivoEnergia, ingresar valores y probar su impresión.
    ● Crear un objeto de la clase PanelSolar, cargar sus datos por consola y comprobar que
    puede acceder tanto a sus propiedades heredadas como a las propias para realizar la
    muestra de información.*/
    class DispositivoEnergia
    {
        private string cod;
        private double genekwh;
        public string Cod
        {
            get { return cod; }
            set { cod = value; }
        }

        public double GeneKwh
        {
            get { return genekwh; }
            set
            {
                if (value > 0)
                {
                    genekwh = value;
                }
                else
                {
                    genekwh = 0;
                }
            }
        }
        public DispositivoEnergia(string cod, double genekwh)
        {
            Cod = cod;
            GeneKwh = genekwh; 
        }
        public void ImprimirD()
        {
            Console.WriteLine("DISPOSITIVO DE ENERGIA: ");
            Console.WriteLine("Codigo: " + Cod);
            Console.WriteLine("Kilowatts-hora generados: " + GeneKwh + "kwh");
        }
        }
        class PanelSolar : DispositivoEnergia
        {
        private double aream;
        public double Aream
        {
            get { return aream; }
            set { if (value > 0) aream = value; }
        }
        public PanelSolar(string cod, double genekwh, double aream) : base(cod, genekwh)
        {
            Aream = aream;
        }
        public void ImprimirP()
        {
            Console.WriteLine("PANEL SOLAR: ");
            Console.WriteLine("Codigo: " + Cod);
            Console.WriteLine("Kilowatts-hora generados: " + GeneKwh + "kwh");
            Console.WriteLine("Superficie del panel: " + Aream + "m²");
        }

        static void Main(string[] args)
        {
            DispositivoEnergia d = new DispositivoEnergia ("atvm", 35);
            d.ImprimirD();
            PanelSolar p = new PanelSolar ("adcd", 50, 67);
            p.ImprimirD();
            Console.ReadKey();
        }
    }
}
