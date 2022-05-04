using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_7._1_WindowForms_ExercicioIMC_04_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;

            peso = double.Parse(txtPeso.Text);
            altura = double.Parse(txtAltura.Text);

            imc = (peso / (altura * altura));
            imc = double.Parse(string.Format("{0:N2}", imc));

            lblResultado.Text = Convert.ToString(imc);

            if (imc < 17)
            {
                MessageBox.Show($"Seu IMC: " + imc + ": Muito abaixo do peso");
            }

            if ((imc >= 17) && (imc <= 18.49))
            {
                MessageBox.Show($"Seu IMC: " + imc + ": Abaixo do peso");
            }

            if ((imc >= 18.5) && (imc <= 24.99))
            {
                MessageBox.Show("Seu IMC: " + imc + ": Peso normal");
            }

            if ((imc >= 25) && (imc <= 29.99))
            {
                MessageBox.Show($"Seu IMC: " + imc + ": Acima do peso");
            }

            if ((imc >= 30) && (imc <= 34.99))
            {
                MessageBox.Show($"Seu IMC: " + imc + ": Obesidade I");
            }

            if ((imc >= 35) && (imc <= 39.99))
            {
                MessageBox.Show($"Seu IMC: " + imc + ": Obesidade II(severa)");
            }

            if (imc > 40)
            {
                MessageBox.Show($"Seu IMC: " + imc + ": Obesidade III(mórbida)");
            }
            
            
        }
    }
}
