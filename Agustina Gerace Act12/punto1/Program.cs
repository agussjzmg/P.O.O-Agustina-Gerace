using System;

namespace punto1
{
    /*1. Sistema de Logística: Envíos por Sucursal
    Una empresa de correo tiene 3 sucursales principales. Cada sucursal procesa una
    cantidad diferente de paquetes por día dependiendo de su demanda.
    ● Definir un vector de tipo string para los nombres de las 3 sucursales.
    ● Definir una matriz irregular donde cada fila sea una sucursal y cada columna
    represente el peso (en kg) de cada paquete enviado.
    ● Métodos:
    1. Cargar los nombres de las sucursales y, para cada una, preguntar cuántos
    paquetes se enviaron hoy para definir el tamaño de su fila.
    2. Cargar el peso de cada paquete.
    3. Imprimir el peso de todos los paquetes organizados por sucursal.
    4. Calcular e informar el peso total despachado por cada sucursal.
    5. Informar cuál es el paquete más pesado de toda la empresa y a qué sucursal
    pertenece.*/
    class matriz1 
    {
        private int[][] mat;
        private string[] nombres; 

        public void Cargar()
        {
            nombres = new string[3];
            mat = new int[3][]; 
            string linea;

            for (int t = 0; t < nombres.Length; t++)
            { 
                Console.Write("Nombre de la sucursal: ");
                nombres[t] = Console.ReadLine();
                Console.Write("Cuantos paquetes se enviaron hoy?: "); 
                linea = Console.ReadLine();
                int cantidad = int.Parse(linea); 
                mat[t] = new int[cantidad]; 

                for (int a = 0; a < mat[t].Length; a++) 
                { 
                    Console.Write("Cuanto pesaba el paquete (en kg): ");
                    linea = Console.ReadLine();
                    int peso = int.Parse(linea);
                    mat[t][a] = int.Parse(linea);
                } 
            } 
        }

        public void SucuYPeso() { 

            for (int t = 0; t < mat.Length; t++) 
            {
                Console.Write(nombres[t] + ": "); 
               
                for (int a = 0; a < mat[t].Length; a++) 
                {
               
                    Console.Write(mat[t][a] + " "); 

                } 

                Console.WriteLine(); 
            } 
        }

        public void PesoTotalSucursal() {

            for (int t = 0; t < mat.Length; t++)
            {
                int suma = 0;
           
                for (int a = 0; a < mat[t].Length; a++)
                {
                    suma = suma + mat[t][a];
                }

                Console.WriteLine("Peso total de " + nombres[t] + ": " + suma + " kg");
            }
        }

        public void MasPesado()
        {
            int mayor = mat[0][0];
            string sucu = nombres[0];

            for (int t = 0; t < mat.Length; t++)
            {
                for (int a = 0; a < mat[t].Length; a++)
                {
                    if (mat[t][a] > mayor)
                    {
                        mayor = mat[t][a];
                        sucu = nombres[t];
                    }
                }
            }

            Console.WriteLine("El paquete mas pesado es de " + mayor + " kg");
            Console.WriteLine("Pertenece a la sucursal: " + sucu);
        }
        static void Main(string[] args)
        {
            matriz1 m1 = new matriz1();
            m1.Cargar();
            m1.SucuYPeso();
            m1.PesoTotalSucursal();
            m1.MasPesado();
            Console.ReadKey();
        }
    }
}