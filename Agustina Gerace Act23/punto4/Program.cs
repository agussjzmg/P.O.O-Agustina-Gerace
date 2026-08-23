using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    /*4- 
    Un sistema central de domótica gestiona el consumo de los artefactos inteligentes
    vinculados a una red hogareña.
     Crear la clase DispositivoInteligente que contenga como atributos
    privados: nombreDispositivo (string) y consumoWatts (double). Definir
    sus propiedades y un constructor que reciba nom y watts.
     Crear la clase colaboradora PanelDomotico que administre un objeto
    List&lt;DispositivoInteligente&gt;.
     Métodos en PanelDomotico:
    1. Un constructor que permita al usuario cargar dinámicamente
    dispositivos por teclado. El sistema preguntará después de cada
    carga si se desea agregar otro dispositivo.
    2. MostrarDispositivos(): Listar todos los dispositivos
    configurados junto a sus consumos.
    3. CalcularConsumoTotal(): Calcular y mostrar en pantalla los
    Watts totales que consume la casa sumando los valores de la lista.
    4. DesconectarDispositivo(): Solicitar al usuario el nombre de
    un dispositivo y, si existe en la lista, removerlo de forma dinámica
    para simular su apagado remoto.*/
    class DispositivoInteligente
    {
        private string nombre;
        private double consumo;

        public DispositivoInteligente(string nom, double watts)
        {
            nombre = nom;
            consumo = watts;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Consumo
        {
            get { return consumo; }
            set { consumo = value; }
        }
    }

    class PanelDomotico
    {
        private List<DispositivoInteligente> dispositivos =
            new List<DispositivoInteligente>();

        public PanelDomotico()
        {
            string a;

            do
            {
                Console.Write("Cargar nombre del dispositivo: ");
                string nom = Console.ReadLine();

                Console.Write("Cargar su consumo de watts: ");
                double watts = double.Parse(Console.ReadLine());

                DispositivoInteligente dispositivo =
                    new DispositivoInteligente(nom, watts);

                dispositivos.Add(dispositivo);

                Console.Write("Queres seguir añadiendo dispositivos? si/no: ");
                a = Console.ReadLine();

            } while (a == "si");
        }

        public void MostrarDispositivos()
        {
            Console.WriteLine("Dispositivos configurados:");

            foreach (DispositivoInteligente d in dispositivos)
            {
                Console.WriteLine("nombre: " + d.Nombre + "consumo: " + d.Consumo + " watts");
            }
        }

        public void CalcularConsumoTotal()
        {
            double total = 0;

            foreach (DispositivoInteligente d in dispositivos)
            {
                total += d.Consumo;
            }

            Console.WriteLine(
                "\nEl consumo total de la casa es de: " + total + " Watts");
        }

        public void DesconectarDispositivo()
        {
            Console.Write(
                "Nombre del dispositivo que quiere desconectar: ");

            string nombre = Console.ReadLine();

            for (int a = dispositivos.Count - 1; a >= 0; a--)
            {
                if (dispositivos[a].Nombre == nombre)
                {
                    dispositivos.RemoveAt(a);

                    Console.WriteLine(
                        "El dispositivo fue desconectado correctamente.");

                    return;
                }
            }

            Console.WriteLine("No se encontró ese dispositivo.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PanelDomotico pd = new PanelDomotico();
            pd.MostrarDispositivos();
            pd.CalcularConsumoTotal();
            pd.DesconectarDispositivo();
            pd.MostrarDispositivos();
            pd.CalcularConsumoTotal();

            Console.ReadKey();
        }
    }
}