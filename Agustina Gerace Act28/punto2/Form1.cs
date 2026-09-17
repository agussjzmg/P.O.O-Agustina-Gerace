using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto2
{
    /*2. Conversor de Temperatura
    ● Consigna: Disponer un TextBox para el ingreso numérico y dos RadioButton:
    &quot;Celsius a Fahrenheit&quot; y &quot;Fahrenheit a Celsius&quot;. Al presionar un Button, realizar la
    fórmula correspondiente y mostrar el resultado en un Label.*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
private void button1_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(textBox1.Text);
            if (radioButton1.Checked == true)
            {
                double cal = (num1 * 9 / 5) + 32;
                label1.Text = " " + cal;
            }
            if (radioButton2.Checked == true)
            {
                double cal = (num1 - 32) * 5 / 9;
                label1.Text = " " + cal;
            }
        }
            
        }
    }

