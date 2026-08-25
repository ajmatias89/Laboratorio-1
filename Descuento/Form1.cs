using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerEnClase2
{
    public partial class lab1Descuento : Form
    {
        public lab1Descuento()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal VentasTotales;
            decimal ValorVenta;
            decimal DescuentoVenta;
            decimal DescuentoPorcentaje;

            if (!decimal.TryParse(txtValorVenta.Text, out ValorVenta))
            {
                MessageBox.Show("No hay valor ponderado.");
            }
            else
            {
                if (ValorVenta >= 500)
                {
                    DescuentoPorcentaje = 0.3m;
                }
                else if (ValorVenta >= 300 && ValorVenta <= 499)
                {
                    DescuentoPorcentaje = 0.20m;

                }
                else if (ValorVenta >= 100 && ValorVenta <= 299)
                {
                    DescuentoPorcentaje = 0.10m;
                }
                else DescuentoPorcentaje = 0;

                DescuentoVenta = ValorVenta * DescuentoPorcentaje;
                VentasTotales = ValorVenta - DescuentoVenta;

                txtVentaFinal.Text = VentasTotales.ToString();
                txtDescuentoPorcentaje.Text = DescuentoPorcentaje.ToString();
                txtDescuento.Text = DescuentoVenta.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValorVenta.Text = "";
            txtDescuento.Text = "";
            txtDescuentoPorcentaje.Text = "";
            txtVentaFinal.Text = "";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cerraráel programa.");
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
