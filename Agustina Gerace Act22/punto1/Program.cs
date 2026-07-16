using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    /*Actividad 1: Control de horarios en un gimnasio
    Problema:
    Crear una clase ClaseGimnasio con atributos: nombreClase, horaInicio y horaFin (usar
    DateTime).
     Implementar un constructor que permita cargar los datos desde consola y otro
    que cargue valores por defecto (sobrecarga de constructores).
     Incluir un método para calcular la duración de la clase usando TimeSpan.
     Crear un vector de 3 clases de gimnasio y mostrar:
    1. La clase que tenga la mayor duración.
    2. El nombre y el horario de inicio de la clase más temprana.*/
    class clasegimnasio
    {
        protected string nombreclase;
        protected DateTime horaInicio;
        private DateTime horaFin;
        public clasegimnasio()
        {
            int hora;
            int minuto;
            string linea;
            Console.Write("ingresar el nombre de la clase: ");
            nombreclase = Console.ReadLine();
            do
            {
                Console.Write("ingresar hora de inicio de la clase: ");
                linea = Console.ReadLine();
                hora = int.Parse(linea);
            } while (hora > 24 && hora < 1);
            do
            {
                Console.Write("ingresar minuto de inicio de la clase: ");
                linea = Console.ReadLine();
                minuto = int.Parse(linea);
            } while (minuto > 60 && hora < 0);
            horaInicio = new DateTime(2026, 7, 13, hora, minuto, 00);
            do
            {
                Console.Write("ingresar hora de finalizacion de la clase: ");
                linea = Console.ReadLine();
                hora = int.Parse(linea);
            } while (hora > 24 && hora < 1);
            do
            {
                Console.Write("ingresar minuto de finalizacion de la clase: ");
                linea = Console.ReadLine();
                minuto = int.Parse(linea);
            } while (minuto > 60 && hora < 0);
            horaFin = new DateTime(2026, 7, 13, hora, minuto, 00);
        }
        public clasegimnasio(string nombreclase, DateTime horaInicio, DateTime horaFin)
        {
            this.nombreclase = nombreclase;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
        }
        public TimeSpan duracion()
        {
            TimeSpan duracion = horaFin - horaInicio;
            Console.WriteLine("la duracion de la clase es de: " + duracion);
            return duracion;
        }
        public string nombre
        {
            set
            {
                nombreclase = value;
            }
            get
            {
                return nombreclase;
            }
        }
        public DateTime hora

        {
            set
            {
                horaInicio = value;
            }
            get
            {
                return horaInicio;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            clasegimnasio[] clases = new clasegimnasio[3];
            TimeSpan may = TimeSpan.Zero;
            string nombre = "";
            for (int t = 0; t < clases.Length; t++)
            {
                clases[t] = new clasegimnasio();
                if (clases[t].duracion() > may)
                {
                    may = clases[t].duracion();
                    nombre = clases[t].nombre;
                }
            }
            Console.WriteLine("la clase con mayor duración es " + nombre);
            DateTime men = clases[0].hora;
            for (int t = 0; t < clases.Length; t++)
            {
                if (clases[t].hora < men)
                {
                    men = clases[t].hora;
                    nombre = clases[t].nombre;
                }
                Console.WriteLine("la clase mas temprana es " + nombre + " y empieza a las " + men);
            }
            Console.ReadKey();
        }
    }

}

