using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    /*4. Cadena de Herramientas (Herencia Multinivel y Orden de Constructores)
    Armar una estructura jerárquica compuesta por tres clases consecutivas en una línea de
    herencia: Material, Herramienta y Martillo.
     La clase Material (base) debe tener un atributo TipoMaterial (ej: Madera, Acero,
    Plástico).
     La clase Herramienta (que hereda de Material) debe añadir el atributo
    FuncionPrincipal.
     La clase Martillo (que hereda de Herramienta) debe añadir el atributo PesoGramos.
    Cada una de las tres clases debe contar con un constructor encargado de recibir sus datos
    correspondientes. Al momento de ejecutarse, cada constructor debe realizar la asignación y,
    acto seguido, imprimir un mensaje en consola indicando a qué clase pertenece
    (ejemplo: &quot;Constructor de la clase Material ejecutado&quot;).
    En el método Main, crear únicamente un objeto de la clase final Martillo pasándole todos los
    parámetros requeridos. Observar y verificar en la consola el orden secuencial de ejecución
    en cadena de los constructores (desde la raíz hasta la clase derivada).*/
     class Material
    {
        protected string tipoMaterial;
        public string TipoMaterial
        {
            set { tipoMaterial = value; }
            get { return tipoMaterial; }
        }
        public Material(string tipoMaterial)
        {
            Console.WriteLine("Constructor de la clase Material");
            TipoMaterial = tipoMaterial;
        }
        }
     class Herramienta : Material
    {
        protected string funcionPrincipal;
        public string FuncionPrincipal
        {
            set { funcionPrincipal = value; }
            get { return funcionPrincipal; }
        }
        public Herramienta (string tipoMaterial, string funcionPrincipal) : base (tipoMaterial)
        {
            Console.WriteLine("Constructor de la clase Herramienta");
            FuncionPrincipal = funcionPrincipal;
        }
       }
        class Martillo : Herramienta
        {
        protected float pesoGramos;
        public float PesoGramos
        {
            get { return pesoGramos; }
            set { pesoGramos = value; }
        }
        public Martillo (string tipoMaterial, string funcionPrincipal, float pesoGramos) : base(tipoMaterial, funcionPrincipal)
        {
            Console.WriteLine("Constructor de la clase Martillo");
            PesoGramos = pesoGramos;
        }
        static void Main(string[] args)
        {
            Martillo m = new Martillo("Madera y Metal", "clavar clavos", 35);
            Console.ReadKey();
        }
    }
}
