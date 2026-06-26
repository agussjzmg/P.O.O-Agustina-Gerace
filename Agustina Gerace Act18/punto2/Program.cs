using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    /*2.
    Plantear una clase llamada CriaturaMarina y otra clase llamada HabitatAcuatico.
    La clase CriaturaMarina debe tener como atributos privados: Especie (string),
    ProfundidadOptima (int, en metros) y NivelSalinidad (un valor de 1 a 100). Definir las
    propiedades necesarias para acceder a estos atributos asegurando mediante validaciones que:
    ● La profundidad óptima sea estrictamente mayor a cero (0).
    ● El nivel de salinidad se encuentre únicamente en el rango de 1 a 100 (de lo contrario,
    asignar un valor por defecto de 35, que representa la salinidad promedio del océano).
    La clase HabitatAcuatico debe contener como atributo un vector capaz de almacenar 3 objetos
    de la clase CriaturaMarina. Definir un método dentro de HabitatAcuatico para cargar las 3
    criaturas y otro método para mostrar todas las criaturas ordenadas de menor a mayor en base
    a su profundidad óptima. Además, el programa debe informar la especie que requiere el mayor
    nivel de salinidad para sobrevivir.*/
    class CriaturaMarina
    {
        private string especie;
        private int profopt;
        private int nivelsal;
        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }
        public int ProfOpt
        {
            get { return profopt; }
            set { if (value > 0) profopt = value; }
        }
        public int NivelSal
        {
            get { return nivelsal; }
            set
            {
                if (value > 0 && value < 101)
                {
                    nivelsal = value;
                }
                else
                {
                    nivelsal = 35;
                }
            }
        }
    }
        class HabitatAcuario
        {
        private CriaturaMarina[] crimar;
        public HabitatAcuario()
        {
            crimar = new CriaturaMarina[3];
            for (int t = 0; t < 3; t++)
            {
                crimar[t] = new CriaturaMarina();
            }
        }
        public void Cargar()
        {
            for (int t = 0; t < crimar.Length; t++)
            {
                string linea;
                Console.Write("Ingrese la especie: ");
                crimar[t].Especie = Console.ReadLine();
                do
                {
                    Console.Write("Ingrese la profundidad óptima: ");
                    linea = Console.ReadLine();
                    crimar[t].ProfOpt = int.Parse(linea);

                    if (crimar[t].ProfOpt <= 0)
                        Console.WriteLine("La profundidad debe ser mayor a 0.");
                }
                 while (crimar[t].ProfOpt <= 0);

                Console.Write("Ingrese el nivel de salinidad para sobrevivir (del 1 al 100, un numero fuera de este rango se denominara como 35m): ");
                linea = Console.ReadLine();
                crimar[t].NivelSal = int.Parse(linea);

            }
        }
        public void Mayor()
        {
            string espp = crimar[0].Especie;
            int mayor = crimar[0].NivelSal;
            CriaturaMarina aux;
            Console.WriteLine("Ordenada de menor a mayor en base a su profundidad óptima: ");
            for (int t = 0; t < crimar.Length; t++)
            {
                for (int a = 0; a < crimar.Length - 1 - t; a++)
                {
                    if (crimar[a].ProfOpt > crimar[a + 1].ProfOpt)
                    {
                        aux = crimar[a];
                        crimar[a] = crimar[a + 1];
                        crimar[a + 1] = aux;
                    }
                }
                Console.WriteLine(crimar[t].Especie + " - " + crimar[t].ProfOpt);
            }
            for (int t = 1; t < crimar.Length; t++)
            {
                if (crimar[t].NivelSal > mayor)
                {
                    mayor = crimar[t].NivelSal;
                    espp = crimar[t].Especie;
                }
            }
            Console.WriteLine("La especie que requiere el mayor nivel de salinidad para sobrevivir es: " + espp + " con una salinidad de " + mayor);
        }
            static void Main(string[] args)
        {
            HabitatAcuario h = new HabitatAcuario();
            h.Cargar();
            h.Mayor();
            Console.ReadKey();
        }
    }
}
