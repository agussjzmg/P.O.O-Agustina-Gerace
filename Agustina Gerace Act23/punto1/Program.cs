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
    class Documento
    {
        private string nomar;
        //https://www.youtube.com/watch?v=37EIJThpc8U&list=RD37EIJThpc8U&start_radio=1
        //http://youtube.com/watch?v=CXZ7Nz69OPg&list=PLq_UjttdaR_LfmnpSInmBCJdJPAstIw2J
        private int cantp;
        public string Nomar
        {
            set
            {
                nomar = value;
            }
            get
            {
                return nomar;
            }
        }
        public int Cantp
        {
            set
            { 
                cantp = value;
            }
            get
            {
                return cantp;
            }
        }
    }
        class ServidorImpresion
    {
        List<Documento> lista = new List<Documento>();
        public void AgregarArchivo(Documento nomar)
        {
            string nom;
            int cantp;
            string linea;
            Console.Write("Ingrese el nombre del archivo: ");
            nom = Console.ReadLine();
            lista.Add(nomar);
            Console.Write("Ingrese la cantidad de paginas: ");
            linea = Console.ReadLine();
            cantp = int.Parse(linea);
            lista.Add(cantp);
        }


        static void Main(string[] args)
        {
        }

    }
}
