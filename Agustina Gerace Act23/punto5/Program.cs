using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto5
{
    /*5-
    Un taller mecánico automatizado administra la recepción y egreso de automóviles
    que se encuentran en el sector de reparaciones.
     Crear la clase Vehiculo que contenga como atributos privados: patente
    (string) y costoReparacion (double). Definir sus propiedades
    correspondientes y un constructor que reciba pat y costo.
     Crear la clase GestionTaller que administre una lista de objetos List.
     Métodos en GestionTaller:
    o IngresarVehiculo(): Solicitar por teclado la patente y el costo de
    reparación de un vehículo para agregarlo a la lista mediante .Add().
    o BuscarVehiculo(): Pedir al operador que ingrese una patente y,
    recorriendo la lista, informar si el vehículo está en el taller y mostrar
    su costo asociado.
    o EntregarVehiculo(): Solicitar una patente por teclado, buscar el
    vehículo en la lista y, si existe, removerlo de la colección mediante
    .Remove() confirmando la entrega del automóvil.

    o CalcularRecaudacionPendiente(): Listar los vehículos
    actualmente en reparación, la cantidad total de unidades alojadas en
    el taller mediante la propiedad .Count y la suma total acumulada por
    cobrar.*/

    class vehiculo
    {
        private string patente;
        private double costoDeReparacion;
        public vehiculo(string pat, double costo)
        {
            patente = pat;
            costoDeReparacion = costo;
        }
        public string Patente
        {
            get { return patente; }
            set { patente = value; }
        }
        public double Costo
        {
            get { return costoDeReparacion; }
            set { costoDeReparacion = value; }
        }
    }
    class GestionTaller
    {
        private List<vehiculo> vehiculos = new List<vehiculo>();
        public void IngresarVehiculo()
        {
            string a;
            do
            {
                Console.Write("ingresa la patente del vehiculo: ");
                string pat = Console.ReadLine();
                Console.Write("ingrese el costo de reparacion del vehiculo: ");
                string linea = Console.ReadLine();
                double costo = double.Parse(linea);
                Console.Write("ingrese ´.´ si desea terminar de añadir vehiculos: ");
                a = Console.ReadLine();
                if (a != ".")
                {
                    vehiculo vehiculo = new vehiculo(pat, costo);
                    vehiculos.Add(vehiculo);
                }
            } while (a != ".");
        }
        public void BuscarVehiculo()
        {
            Console.Write("ingresar la patente del vehiculo buscado: ");
            string pat = Console.ReadLine();
            foreach (vehiculo vehiculo in vehiculos)
            {
                if (vehiculo.Patente == pat)
                {
                    Console.WriteLine("su costo de reparacion es de " + vehiculo.Costo);
                }
            }
        }
        public void EntregarVehiculo()
        {
            Console.Write("ingresar la patente del vehiculo buscado: ");
            string pat = Console.ReadLine();
            for (int a = vehiculos.Count(); a >= 0; a--)
            {
                if (vehiculos[a].Patente == pat)
                {
                    vehiculos.RemoveAt(a);
                }
            }
        }
        public void CalcularRecaudacionPendiente()
        {
            Console.WriteLine("la cantidad de vehiculos que hay para reparar es de: " + vehiculos.Count());
            double total = 0;
            foreach (vehiculo vehiculo in vehiculos)
            {
                total += vehiculo.Costo;
            }
            Console.WriteLine("el total a cobrar es de: " + total);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GestionTaller gestion = new GestionTaller();
            gestion.IngresarVehiculo();
            gestion.BuscarVehiculo();
            gestion.EntregarVehiculo();
            gestion.CalcularRecaudacionPendiente();
            Console.ReadKey();

        }
    }
}
