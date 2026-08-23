using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    /*8-
    Una farmacia controla el nivel de stock de sus medicamentos para evitar el
    desabastecimiento de insumos esenciales.
     Crear la clase Medicamento que contenga los atributos privados: nombre
    (string) y stock (int). Definir sus propiedades correspondientes. Su
    constructor debe recibir nom y stk.
     Crear la clase ControlFarmacia que administre una lista de objetos List.
     Métodos en ControlFarmacia:
    o Un constructor que cargue por teclado una lista inicial de 4
    medicamentos ingresando sus nombres y stock.
    o ListarStock(): Mostrar la lista de medicamentos en pantalla.

    o RemoverAgotados(): Recorrer la lista y remover por completo de
    la colección a todos aquellos medicamentos cuyo stock sea igual a 0.
    o MostrarMedicamentosDisponibles(): Imprimir la lista
    actualizada y la cantidad de productos disponibles en el inventario
    utilizando la propiedad .Count.*/
    class medicamentos
    {
        private string nombre;
        private int stock;

        public medicamentos(string nom, int stk)
        {
            nombre = nom;
            stock = stk;
        }

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public int Stock
        {
            set { stock = value; }
            get { return stock; }
        }
    }

    class controlFarmacia
    {
        private List<medicamentos> mdc = new List<medicamentos>();

        public controlFarmacia()
        {
            for (int a = 0; a < 4; a++)
            {
                Console.Write("Ingresa el nombre del medicamento: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingresa el stock del medicamento: ");
                string linea = Console.ReadLine();

                int stock = int.Parse(linea);

                medicamentos medicamento = new medicamentos(nombre, stock);

                mdc.Add(medicamento);
            }
        }

        public void ListarStock()
        {
            foreach (medicamentos m in mdc)
            {
                Console.WriteLine(m.Nombre + " ");
                Console.WriteLine(m.Stock);
                Console.WriteLine();
            }
        }

        public void RemoverAgotados()
        {
            for (int a = mdc.Count - 1; a >= 0; a--)
            {
                if (mdc[a].Stock == 0)
                {
                    mdc.RemoveAt(a);
                }
            }
        }

        public void MostrarMedicamentosDisponibles()
        {
            foreach (medicamentos m in mdc)
            {
                Console.WriteLine(m.Nombre + " ");
                Console.WriteLine(m.Stock);
                Console.WriteLine();
            }

            Console.WriteLine("Cantidad de medicamentos disponibles: " + mdc.Count);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            controlFarmacia farmacia = new controlFarmacia();

            Console.WriteLine("Stock inicial:");
            farmacia.ListarStock();

            farmacia.RemoverAgotados();

            Console.WriteLine("Medicamentos disponibles:");
            farmacia.MostrarMedicamentosDisponibles();

            Console.ReadKey();
        }
    }
}
