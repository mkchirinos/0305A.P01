using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(conversiones));
        }

        double cifra=0;
        string resultado = "";
        int tipoConversion=0;

        enum conversiones
        {
            Celcius_a_Fahrenheit,
            Celcius_a_Kelvin,
            Fahrenheit_a_Celcius,
            Fahrenheit_a_Kelvin,
            Kelvin_a_Celcius,
            Kelvin_a_Fahrenheit
        };

        private string convertor(double cifra, int tipoConversion)
        {
            switch (tipoConversion)
            {
                case 0:
                    resultado = Convert.ToString((cifra * 9.0 / 5.0) + 32) + " °F";
                    break;
                case 1:
                    resultado = Convert.ToString(cifra + 273) + " °K";
                    break;
                case 2:
                    resultado = Convert.ToString((cifra - 32) * (5.0 / 9.0)) +" °C";             
                    break;
                case 3:
                    resultado = Convert.ToString((cifra + 459.67) * 5.0/9.0) + " °K";
                    break;
                case 4:
                    resultado = Convert.ToString(cifra - 273) + " °C";
                    break;
                case 5:
                    resultado = Convert.ToString((9.0/5.0 * cifra)  - 459.67) + "°F";
                    break;
            }
            return resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                cifra = double.Parse(textBox1.Text);
                tipoConversion = Convert.ToInt32(comboBox1.SelectedIndex);
                label3.Text = "Resultado: " + convertor(cifra, tipoConversion);
            }
            else
                label3.Text = "Ingrese un valor a convertir!";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
