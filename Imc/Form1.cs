using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = 0;
            double altura = 0;
            double imc = 0;
            peso = double.Parse(txtPeso.Text);
            altura = double.Parse(txtAltura.Text);
            imc = peso / Math.Pow(altura, 2);

            if (imc >= 1 && imc <= 18.5)
            {
                lblValor.Text = imc.ToString();
                lblStatus.Text = "Abaixo do Peso";
                lblStatus.ForeColor = Color.Red;
            }
            else if (imc > 18.5 && imc <= 24.9)
            {
                lblValor.Text = imc.ToString();
                lblStatus.Text = "Peso Ideal";
                lblStatus.ForeColor= Color.Green;
            }
            else if (imc > 25 && imc <= 29.9)
            {
                lblValor.Text= imc.ToString();
                lblStatus.Text = "Levemente Acima do Peso";
                lblStatus.ForeColor = Color.Orange;
            }
            else if (imc > 30 && imc <= 34.9)
            {
                lblValor.Text = imc.ToString();
                lblStatus.Text = "Obesidade Grau I";
                lblStatus.ForeColor = Color.Red;
            }
            else if (imc > 35 && imc <= 39.9)
            {
                lblValor.Text = imc.ToString();
                lblStatus.Text = "Obesidade Grau II(Severa)";
                lblStatus.ForeColor = Color.Red;
            }
            else 
            {
                lblValor.Text = imc.ToString();
                lblStatus.Text = "Obesidade III(Mórbida)";
                lblStatus.ForeColor = Color.Red;
            }
            
        }
    }
}
