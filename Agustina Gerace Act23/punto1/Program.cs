using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    /*1-
    En un servidor de red, las solicitudes de impresión se procesan dinámicamente en orden de
    llegada.
     Crear la clase Documento que contenga como atributos privados:
    nombreArchivo (string) y cantidadPaginas (int). Definir sus
    propiedades de solo lectura y un constructor que reciba los parámetros nom
    y pag.
     Crear la clase ServidorImpresion que administre una lista dinámica de
    documentos (List&lt;Documento&gt;).
     Métodos en ServidorImpresion:
    1. AgregarDocumento(): Solicitar por teclado los datos de un
    documento y agregarlo al final de la lista utilizando .Add().
    2. ImprimirSiguiente(): Si la lista no está vacía, simular la
    impresión del primer documento de la lista (mostrar sus datos en
    consola) y removerlo de la colección mediante .RemoveAt(0). Si está
    vacía, advertir que no hay trabajos pendientes.
    3. MostrarColaPendiente(): Listar todos los documentos que
    están esperando ser impresos y la cantidad total de páginas
    acumuladas en la cola de espera utilizando .Count.*/

    class documento
    {
        private string nombreArchivo;
        private int cantidadPaginas;

        public documento(string nom, int num)
        {
            nombreArchivo = nom;
            cantidadPaginas = num;
        }
        public string nombre
        {
            get { return nombreArchivo; }
            set { nombreArchivo = value; }
        }
        public int cantidad
        {
            get { return cantidadPaginas; }
            set { cantidadPaginas = value; }
        }

    }
    class servidorImpresion
    {
        private List<documento> lista = new List<documento>();

        public void AgregarDocumento()
        {
            string nom;
            int num;
            Console.Write("ingresa el nombre del archivo: ");
            nom = Console.ReadLine();
            Console.Write("ingresa la cantidad de paginas de ese archivo: ");
            string linea = Console.ReadLine();
            num = int.Parse(linea);
            documento docu = new documento(nom, num);
            lista.Add(docu);
            Console.WriteLine();
        }
        public void ImprimirSiguiente()
        {

            if (lista[0] != null)
            {
                Console.WriteLine(lista[0].nombre);
                lista.RemoveAt(0);
                Console.WriteLine("Registro eliminado");

            }
            else { Console.WriteLine("No hay trabajos pendientes."); }
        }
        public void MostrarColaPendiente()
        {
            foreach (documento docu in lista)
            {
                Console.WriteLine(docu.nombre + " " + docu.cantidad);
            }
            int i = lista.Count();
            int total = 0;
            for (int a = 0; a < i; a++)
            {
                total += lista[0].cantidad;
            }
            Console.WriteLine("Cantidad total de paginas acumuladas en la cola de espera: " + total);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            servidorImpresion s = new servidorImpresion();
            s.AgregarDocumento();
            s.ImprimirSiguiente();
            s.MostrarColaPendiente();
            Console.ReadKey();
        }
    }
}
