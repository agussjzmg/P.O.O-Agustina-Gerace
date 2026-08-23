using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    /*3-
    Un centro de conservación marina registra de forma dinámica las especies de
    mamíferos marinos divisadas en la costa para su posterior análisis estadístico.
     Crear la clase MonitoreoCostero que contenga como atributo privado
    una lista de cadenas de texto List&lt;string&gt; especiesDetectadas.
     Métodos en MonitoreoCostero:
    1. CargarAvistamientos(): Solicitar por teclado nombres de
    especies marinas avistadas (ej: &quot;Ballena Franca&quot;, &quot;Lobo Marino&quot;,
    &quot;Delfín&quot;) y agregarlos a la lista utilizando .Add(). La carga finaliza
    cuando el usuario ingresa la palabra &quot;FIN&quot;.
    2. MostrarReporteOrdenado(): Imprimir la lista de avistamientos
    organizada alfabéticamente de la A a la Z utilizando el método
    .Sort().
    3. MostrarReporteInvertido(): Imprimir la lista organizada de la
    Z a la A combinando .Sort() con el método .Reverse().
    4. BuscarEspecie(): Pedir al operador que ingrese el nombre de un
    animal y, utilizando los métodos de búsqueda de listas, informar si la
    especie fue divisada en la costa durante el día.*/
    class MonitoreoCostero
    {
        private List<string> especies = new List<string>();
        public void cargarAvistamientos()
        {
            string a;
            do
            {
                Console.Write(" Ingresa los nombres de las especies avistadas (para finalizar escriba ´FIN´): ");
                a = Console.ReadLine();
                if (a != "FIN")
                {
                    especies.Add(a);
                }
            } while (a != "FIN");
        }
        public void MostrarReporteOrdenado()
        {
            especies.Sort();
            foreach (string a in especies)
            {
                Console.WriteLine(a);
            }
        }
        public void MostrarReporteInvertido()
        {
            Console.WriteLine();
            especies.Sort();
            especies.Reverse();
            foreach (string a in especies)
            {
                Console.WriteLine(a);
            }
        }
        public void BuscarEspecie()
        {
            Console.Write(" Ingresa el nombre de la especie que desea buscar: ");
            string a = Console.ReadLine();
            if (especies.Contains(a))
            {
                Console.WriteLine("La especie fue avistada");
            }
            else { Console.WriteLine("La especie no fue avistada"); }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MonitoreoCostero mc = new MonitoreoCostero();
            mc.cargarAvistamientos();
            mc.MostrarReporteOrdenado();
            mc.MostrarReporteInvertido();
            mc.BuscarEspecie();
            Console.ReadKey();
        }
    }
}
