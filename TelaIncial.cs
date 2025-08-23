using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeOvni
{
    public partial class TelaIncial : Form
    {
        public TelaIncial()
        {
            InitializeComponent();

            cmbOrigem.Items.AddRange(BibliotecaOVNI.OVNI.PlanetasValidos);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if(txbTripulantes.Text == "")
            {
                MessageBox.Show("Informe o maximo de tripulantes!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txbAbduzidos.Text == "")
            {
                MessageBox.Show("Informe os abduzidos!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cmbOrigem.Text == "")
            {
                MessageBox.Show("Informe o maximo de tripulantes!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int maxTripulantes = int.Parse(txbTripulantes.Text);
                int maxAbduzidos = int.Parse(txbAbduzidos.Text);
                string planetaOrigem = cmbOrigem.Text;

                BibliotecaOVNI.OVNI ovni = new BibliotecaOVNI.OVNI(maxTripulantes, maxAbduzidos, planetaOrigem);
            }
        }
    }
}
