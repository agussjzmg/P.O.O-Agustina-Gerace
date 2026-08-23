using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    /*9-
    Un instituto de enseñanza registra de forma dinámica a sus estudiantes para
    realizar el seguimiento académico de sus materias.
     Crear la clase Estudiante que contenga como atributos privados:
    nombreCompleto (string) y calificacion (double). Definir sus propiedades
    de solo lectura y un constructor que reciba nom y cal.
     Crear la clase GestionAcademica que administre una lista de objetos
    List.
     Métodos en GestionAcademica:
    o CargarEstudiantes(): Solicitar por teclado nombres y
    calificaciones para agregar estudiantes a la lista mediante .Add(). La
    carga finaliza cuando el usuario ingresa la palabra &quot;FIN&quot; como
    nombre.
    o ListarEstudiantes(): Mostrar en pantalla todos los alumnos
    junto a la cantidad total de inscriptos mediante la propiedad .Count.
    o FiltrarAprobados(): Recorrer la lista e imprimir en consola
    únicamente aquellos estudiantes cuya calificación sea mayor o igual
    a 6.0.
    o DarDeBaja(): Pedir al operador el nombre de un estudiante y,
    utilizando los métodos de búsqueda y remoción de listas, eliminarlo
    de la colección si se encuentra presente.*/
    class Estudiante
    {
        private string nombre;
        private double calificacion;
        public Estudiante(string nom, double cal)
        {
            nombre = nom;
            calificacion = cal;
        }
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public double Calificacion
        {
            set { calificacion = value; }
            get { return calificacion; }
        }
    }
    class gestionAcademica
    {
        private List<Estudiante> estudiantes = new List<Estudiante>();
        public void cargarEstudiantes()
        {
            string nombre;
            do
            {
                Console.Write("ingresa el nombre del estudiante (para finalizar introduzca la palabra ´FIN´): ");
                nombre = Console.ReadLine();
                if (nombre != "FIN")
                {
                    Console.Write("ingresa su calificacion: ");
                    string linea = Console.ReadLine();
                    int calificacion = int.Parse(linea);
                    Estudiante est = new Estudiante(nombre, calificacion);
                    estudiantes.Add(est);
                }
            } while (nombre != "FIN");
        }
        public void ListarEstudiantes()
        {
            foreach (Estudiante est in estudiantes)
            {
                Console.WriteLine(est.Nombre);
                Console.WriteLine();
            }
            Console.WriteLine("cantidad de estudiantes: " + estudiantes.Count());
        }
        public void filtrarAprobados()
        {
            Console.WriteLine("los estudiantes aprobados son: ");
            foreach (Estudiante est in estudiantes)
            {
                if (est.Calificacion > 6)
                {
                    Console.WriteLine(est.Nombre);
                    Console.WriteLine();
                }
            }
        }
        public void DarDeBaja()
        {
            Console.Write("ingresar el nombre del estudiante dado de baja: ");
            string nom = Console.ReadLine();
            for (int a = estudiantes.Count(); a >= 0; a--)
            {
                if (estudiantes[a].Nombre == nom)
                {
                    estudiantes.RemoveAt(a);
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            gestionAcademica gestion = new gestionAcademica();
            gestion.cargarEstudiantes();
            gestion.ListarEstudiantes();
            gestion.filtrarAprobados();
            gestion.DarDeBaja();
            Console.ReadKey();
        }
    }
}