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
    }
}
