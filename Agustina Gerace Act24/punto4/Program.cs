using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    /*10-
    Un estacionamiento medido administra el ingreso y la salida de los vehículos que
    utilizan su playa por orden de llegada.
     Crear la clase Ticket que contenga como atributos privados: patente
    (string) y horasEstadia (int). Definir sus propiedades de solo lectura y un
    constructor que reciba pat y hs.
     Crear la clase GestionEstacionamiento que administre una lista
    dinámica de tickets (List).
     Métodos en GestionEstacionamiento:
    o RegistrarIngreso(): Solicitar por teclado los datos de un ticket y
    agregarlo al final de la lista utilizando .Add().
    o ProcesarSalida(): Si la lista no está vacía, simular la salida del
    primer vehículo de la lista (mostrar sus datos en consola) y
    removerlo de la colección mediante .RemoveAt(0). Si está vacía,
    advertir que no hay vehículos esperando salida.
    o MostrarVehiculosEstacionados(): Listar todos los vehículos
    alojados en la playa y la cantidad total de unidades presentes
    utilizando la propiedad .Count.*/
    class ticket
    {
        private string patente;
        private int horasestadia;
        public ticket(string pat, int hs)
        {
            patente = pat;
            horasestadia = hs;
        }
        public string Patente
        {
            set { patente = value; }
            get { return patente; }
        }
        public int Hora
        {
            set { horasestadia = value; }
            get { return horasestadia; }
        }
    }
    class gestionEstacionamiento
    {
        private List<ticket> tickets = new List<ticket>();
        public void RegistrarIngreso()
        {
            Console.Write("ingresa el patente del vehiculo: ");
            string patente = Console.ReadLine();
            Console.Write("ingresa las horas de estadia del vehiculo: ");
            string linea = Console.ReadLine();
            int hora = int.Parse(linea);
            ticket ticket = new ticket(patente, hora);
            tickets.Add(ticket);
        }
        public void ProcesarSalida()
        {
            if (tickets.Count() != 0)
            {
                tickets.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("no hay vehiculos esperando salida");
            }
        }
        public void MostrarVehiculosEstacionados()
        {
            foreach (ticket t in tickets)
            {
                Console.WriteLine(t.Patente + " ");
                Console.WriteLine(t.Hora);
                Console.WriteLine();
            }
            Console.WriteLine("cantidad de autos en la playa: " + tickets.Count());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            gestionEstacionamiento gestion = new gestionEstacionamiento();
            gestion.RegistrarIngreso();
            gestion.ProcesarSalida();
            gestion.MostrarVehiculosEstacionados();
            Console.ReadKey();
        }
    }
}
