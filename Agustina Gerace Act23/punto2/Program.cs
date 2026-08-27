using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    /*2-
    Una empresa de logística autónoma monitorea el estado y nivel de batería de sus
    drones de entrega en vuelo de regreso a la base.
     Crear la clase Dron que contenga los atributos privados: codigo (string) y
    nivelBateria (int, de 0 a 100). Definir sus propiedades correspondientes.
    Su constructor debe recibir cod y bat.
     Crear la clase CentroControl que administre una lista de objetos
    List&lt;Dron&gt;.
     Métodos en CentroControl:

    1. Un constructor que cargue por teclado una lista inicial de 4 drones
    ingresando sus códigos y baterías.
    2. ListarFlota(): Mostrar la lista de drones en pantalla.
    3. RemoverDronesBajos(): Recorrer la lista y remover por
    completo de la flota a todos aquellos drones cuyo nivel de batería
    sea menor o igual al 15% (ya que requieren mantenimiento
    automático urgente).
    4. MostrarDronesRestantes(): Imprimir la flota actualizada y la
    cantidad de drones operativos utilizando la propiedad .Count.*/
    class dron
    {
        private int codigo;
        private int bateria;
        public dron(int cod, int bat)
        {
            codigo = cod;
            bateria = bat;
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int Bateria
        {
            get { return bateria; }
            set { bateria = value; }
        }
    }
    class centroControl
    {
        private List<dron> drons = new List<dron>();
        public centroControl()
        {
            for (int t = 0; t < 5; t++)
            {
                Console.Write("ingrese el codigo del dron correspondiente: ");
                string linea = Console.ReadLine();
                int cod = int.Parse(linea);
                int bat;
                do
                {
                    Console.Write("ingrese la bateria restante del dron correspondiente: ");
                    linea = Console.ReadLine();
                    bat = int.Parse(linea);
                } while (bat < 0 || bat > 100);
                dron d = new dron(cod, bat);
                drons.Add(d);
            }
        }
        public void ListarFlota()
        {
            foreach (dron d in drons)
            {
                Console.WriteLine(d.Codigo + " con " + d.Bateria + "% de bateria");
            }
        }
        public void RemoverDronesBajos()
        {
            for (int t = 4; t >= 0; t--)
            {
                if (drons[t].Bateria <= 15)
                {
                    drons.RemoveAt(t);
                }
            }
        }
        public void MostrarDronesRestantes()
        {
            foreach (dron d in drons)
            {
                Console.WriteLine(d.Codigo + " con " + d.Bateria + "% de bateria");
            }
            Console.WriteLine(drons.Count());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            centroControl cc = new centroControl();
            cc.ListarFlota();
            cc.RemoverDronesBajos();
            cc.MostrarDronesRestantes();
            Console.ReadKey();
        }
    }
}  
