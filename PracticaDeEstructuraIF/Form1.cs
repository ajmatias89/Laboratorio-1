using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaDeEstructuraIF
{
    public partial class Form1 : Form
    {
        decimal Valor1 = 0.0m;
        decimal Valor2 = 0.0m;
        decimal Resultado = 0.0m;

        public Form1()
        {
            InitializeComponent();
        }

        private bool Valores()
        {
            if(decimal.TryParse(txtValor1.Text, out Valor1) && decimal.TryParse(txtValor2.Text, out Valor2))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos");
                return false;
            }
        }

        private void btnSuma_CheckedChanged(object sender, EventArgs e)
        {
            if (Valores()) {
                lblOperacion.Text = "+";
            Resultado = Valor1 + Valor2;
            txtResultado.Text = Resultado.ToString();
            }
        }

        private void btnResta_CheckedChanged(object sender, EventArgs e)
        {
            if (Valores())
            {
                lblOperacion.Text = "-";
                Resultado = Valor1 - Valor2;
                txtResultado.Text = Resultado.ToString();
            }
        }

        private void btnMultiplicacion_CheckedChanged(object sender, EventArgs e)
        {
            if (Valores())
            {
                lblOperacion.Text = "*";
                Resultado = Valor1 * Valor2;
                txtResultado.Text = Resultado.ToString();
            }
        }

        private void btnDivision_CheckedChanged(object sender, EventArgs e)
        {
            if (Valores())
            {
                if (Valor2 != 0) {
                 lblOperacion.Text = "/";
                 Resultado = Valor1 / Valor2;
                txtResultado.Text = Resultado.ToString();
                }
                else
                {
                    MessageBox.Show("No se puede dividir entre 0");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
 
        }
    }
}
