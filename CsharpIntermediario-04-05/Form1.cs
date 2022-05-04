using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpIntermediario_04_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double b = double.Parse(txtBase.Text);
            double altura = double.Parse(txtAltura.Text);

            Triangulo triangulo = new Triangulo();

            triangulo.Altura = altura;
            triangulo.Base = b;
           

            lblResultado.Text = triangulo.CalcTriangulo().ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblQuadrado.Text = quadrado.CalcQuadrado().ToString();
        }
    }
}
