using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    /*7-
    Un restaurante automatizado procesa la comanda de una mesa para controlar la
    preparación y el cobro de los platos pedidos.
     Crear la clase Plato que contenga como atributos privados: nombrePlato
    (string) y precio (double). Definir sus propiedades correspondientes y un
    constructor que reciba nom y pre.
     Crear la clase GestionComandas que administre una lista de objetos List.
     Métodos en GestionComandas:
    o AgregarPlato():Solicitar por teclado los datos de un plato y
    agregarlo a la lista utilizando .Add().
    o MostrarComanda(): Listar todos los platos agregados hasta el
    momento junto a la cantidad total de ítems pedidos utilizando la
    propiedad .Count.
    o CalcularTotalMesa(): Calcular y mostrar en pantalla el monto
    total a cobrar sumando los precios de la lista.
    o CancelarPlato(): Solicitar al usuario el nombre de un plato y, si
    se encuentra en la lista, removerlo mediante .Remove() para
    actualizar la comanda.*/
    class Plato
    {
        private string nombrePlato;
        private double precio;
        public Plato(string nom, double pre)
        {
            nombrePlato = nom;
            precio = pre;
        }
        public string Nombre
        {
            set { nombrePlato = value; }
            get { return nombrePlato; }
        }
        public double Precio
        {
            set { precio = value; }
            get { return precio; }
        }
    }
    class gestionComandas
    {
        private List<Plato> platos = new List<Plato>();

        public void agregarPlato()
        {
            Console.Write("ingresa el nombre del plato: ");
            string nombre = Console.ReadLine();
            Console.Write("ingresa el precio del plato: ");
            string linea = Console.ReadLine();
            double precio = double.Parse(linea);
            Plato plato = new Plato(nombre, precio);
            platos.Add(plato);
        }
        public void MostrarComanda()
        {
            foreach (Plato plato in platos)
            {
                Console.WriteLine(plato.Nombre + " ");
                Console.WriteLine(plato.Precio);
                Console.WriteLine();
            }
            Console.WriteLine("cantidad de platos pedidos: " + platos.Count());
        }
        public void calcularTotalMesa()
        {
            double total = 0;
            foreach (Plato plato in platos)
            {
                total += plato.Precio;
            }
            Console.WriteLine("el total a cobrar es de  " + total);
        }
        public void CancelarPlato()
        {
            Console.Write("ingresar el nombre del plato cancelado: ");
            string nom = Console.ReadLine();
            for (int a = platos.Count(); a >= 0; a--)
            {
                if (platos[a].Nombre == nom)
                {
                    platos.RemoveAt(a);
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            gestionComandas gc = new gestionComandas();
            gc.agregarPlato();
            gc.MostrarComanda();
            gc.calcularTotalMesa();
            gc.CancelarPlato();
            Console.ReadKey();
        }
    }
}