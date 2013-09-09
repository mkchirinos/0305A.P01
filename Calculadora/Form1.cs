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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string operador = "+";
        
        
        string cifra1;
        double result = 0;
        bool digitando = false;
        bool unpunto = false;

        private double operacion (string operador)
        {
            switch (operador)
            {
                case "+": 
                    result = result + double.Parse(cifra1);
                    break;

                case "-": 
                    result = result - double.Parse(cifra1);
                    break;

                case "*": 
                    result = result * double.Parse(cifra1);
                    break;

                case "/": 
                    result = result / double.Parse(cifra1);
                    break;
            }
            return result;
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            cifra1 = textBox1.Text;

            result = operacion(operador);

            textBox1.Text = result.ToString();
            
            digitando = false;
            unpunto = false;
            
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            cifra1 = textBox1.Text;
            
            if (digitando == false)
                textBox1.Text = cifra1;
            else
            {
                result = operacion(operador);
                textBox1.Text = result.ToString();
            }
            operador = "+";
            digitando = false;
            unpunto = false;
        }
        private void btnResta_Click(object sender, EventArgs e)
        {
            cifra1 = textBox1.Text;

            if (digitando == false)
                textBox1.Text = cifra1;
            else
            {
                result = operacion(operador);
                textBox1.Text = result.ToString();
            }
            operador = "-";
            digitando = false;
            unpunto = false;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            cifra1 = textBox1.Text;
            if (digitando == false)
                textBox1.Text = cifra1;
            else
            {
                result = operacion(operador);
                textBox1.Text = result.ToString();
            }
            operador = "*";
            digitando = false;
            unpunto = false;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            cifra1 = textBox1.Text;

            if (digitando == false)
                textBox1.Text = cifra1;
            else
            {
                result = operacion(operador);
                textBox1.Text = result.ToString();
            }
            operador = "/";
            digitando = false;
            unpunto = false;
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            
            if (digitando == false)
            {
                textBox1.Text = "0";
                
            }
            else
                textBox1.Text = textBox1.Text + "0";
                    
        }

        private void btn1_Click(object sender, EventArgs e)
        {
             if (digitando == false)
            {
                textBox1.Text = "1";
                digitando = true;
            }
            else
                textBox1.Text = textBox1.Text + "1";
                
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (digitando == false)
            {
                textBox1.Text = "2";
                digitando = true;
            }
            else
                textBox1.Text = textBox1.Text + "2";
        }
      

        private void btn3_Click(object sender, EventArgs e)
        {
            if (digitando == false)
            {
                textBox1.Text = "3";
                digitando = true;
            }
            else
                textBox1.Text = textBox1.Text + "3";
            
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (digitando == false)
            {
                textBox1.Text = "4";
                digitando = true;
            }
            else
                textBox1.Text = textBox1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (digitando == false)
            {
                textBox1.Text = "5";
                digitando = true;
            }
            else
                textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (digitando == false)
            {
                textBox1.Text = "6";
                digitando = true;
            }
            else
                textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (digitando == false)
            {
                textBox1.Text = "7";
                digitando = true;
            }
            else
                textBox1.Text = textBox1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (digitando == false)
            {
                textBox1.Text = "8";
                digitando = true;
            }
            else
                textBox1.Text = textBox1.Text + "8";
            
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (digitando == false)
            {
                textBox1.Text = "9";
                digitando = true;
            }
            else
                textBox1.Text = textBox1.Text + "9";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (digitando == false)
            {
                textBox1.Text = "0.";
                unpunto = true;
                digitando = true;
            }
            else
            {
                 if (unpunto == false)
                 {
                    textBox1.Text = textBox1.Text + ".";
                    unpunto = true;
                 }
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            operador = "+";
            result = 0;
            digitando = false;
            unpunto = false;
        }

       

     

       

        
        }
    }

