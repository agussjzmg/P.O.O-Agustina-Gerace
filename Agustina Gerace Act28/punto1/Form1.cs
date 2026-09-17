using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto1
{
    /*1. Calculadora de Promedio de Notas
    ● Consigna: Crear un formulario con tres TextBox para ingresar notas y un Button
    &quot;Calcular&quot;. Convertir los valores con int.Parse() o double.Parse() y mostrar en una
    Label el promedio. Si la nota es mayor o igual a 6, cambiar el color del texto de la
    etiqueta a verde; de lo contrario, a rojo.*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int num3 = int.Parse(textBox3.Text);
            int calculo = (num1 + num2 + num3) / 3;
            if (calculo >= 6)
            {
                label1.BackColor = Color.Green;
                label1.Text = "Tenes un promedio de " + calculo + ", por lo tanto estas aprobado :))";
            }
            else
            {
                label1.BackColor = Color.Red;
                label1.Text = "Estas por debahjo del promedio con un " + calculo + ", por lo tanto estas desaprobado :((";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
