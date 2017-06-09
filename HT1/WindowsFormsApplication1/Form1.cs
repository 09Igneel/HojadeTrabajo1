using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(in1.Text);
            double num2 = Convert.ToDouble(in2.Text);
            double raiz = Math.Sqrt(Math.Pow(num1, 2) + Math.Pow(num2, 2));

            Resultado.Text = "El resultado es: " + Convert.ToString(raiz);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String string1 = in1.Text;
            int[] valores = new int[5] { 0, 0, 0, 0, 0 };

            for (int i = 0; i < string1.Length; i++)
            {
                if ((Convert.ToChar(string1[i])) == 'a' || (Convert.ToChar(string1[i])) == 'A' || (Convert.ToChar(string1[i])) == 'á' || (Convert.ToChar(string1[i])) == 'Á')
                {
                    valores[0] = 1;

                }
                else if ((Convert.ToChar(string1[i])) == 'e' || (Convert.ToChar(string1[i])) == 'E' || (Convert.ToChar(string1[i])) == 'é' || (Convert.ToChar(string1[i])) == 'É')
                {
                    valores[1] = 2;

                }
                else if ((Convert.ToChar(string1[i])) == 'i' || (Convert.ToChar(string1[i])) == 'I' || (Convert.ToChar(string1[i])) == 'í' || (Convert.ToChar(string1[i])) == 'Í')
                {
                    valores[2] = 3;

                }
                else if ((Convert.ToChar(string1[i])) == 'o' || (Convert.ToChar(string1[i])) == 'O' || (Convert.ToChar(string1[i])) == 'ó' || (Convert.ToChar(string1[i])) == 'Ó')
                {
                    valores[3] = 4;

                }
                else if ((Convert.ToChar(string1[i])) == 'u' || (Convert.ToChar(string1[i])) == 'U' || (Convert.ToChar(string1[i])) == 'ú' || (Convert.ToChar(string1[i])) == 'Ú')
                {
                    valores[4] = 5;

                }
            }

            int suma = 0;
            foreach (int c in valores)
            {
                suma += c;
            }

            if (suma == 15)
            {
                Resultado.Text = "Resultado: Cumple";
            }
            else
            {
                Resultado.Text = "Resultado: No Cumple";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String invertida = "";
            String string1 = in1.Text + " " + in2.Text;

            for (int i = string1.Length - 1; i >= 0; i--)
            {
                invertida = invertida + string1.Substring(i, 1);
            }

            Resultado.Text = "Resultado: " + invertida.ToString();
        }
    }
}
