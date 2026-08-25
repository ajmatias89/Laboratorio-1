using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1_Controles
{
    public partial class Practica1Controles : Form
    {
        public Practica1Controles()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(txtDia.Text !="" && txtMes.Text !="" && txtAnno.Text!="" && txtDia.Text != " " && txtMes.Text != " " && txtAnno.Text != " ")
            {
                lblFecha.Text = "La fecha es: "+ txtDia.Text + "/" +txtMes.Text + "/" + txtAnno.Text;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese los datos solicitados.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cerrará la ventana");
            MessageBox.Show("Cerrando");
            this.Close();
        }
    }
}
