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
     class ClaseGimnacio
    {
        private string nomclase;
        DateTime horaInicio = new DateTime ();
        DateTime horaFin = new DateTime();

        public ClaseGimnacio()
        {
            string linea;
            Console.Write("Ingrese el nombre de la clase: ");
            nomclase = Console.ReadLine();
            Console.Write("Ingrese el nombre de la clase: ");
            linea = Console.ReadLine();
            horaInicio = 

        }
        static void Main(string[] args)
        {
        }
    }
}
