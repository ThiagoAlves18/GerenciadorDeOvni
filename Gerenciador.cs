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

    public partial class Gerenciador : Form
    {
        BibliotecaOVNI.OVNI ovni;

        public Gerenciador(BibliotecaOVNI.OVNI ovni)
        {
            InitializeComponent();
            this.ovni = ovni;

            AtualizarInformacoes();

            cmbPlanetas.Items.AddRange(BibliotecaOVNI.OVNI.PlanetasValidos);
        }
        public void AtualizarInformacoes()
        {
            lblTripulantes.Text = $"Tripulantes: {ovni.QtdTripulantes}";
            lblAbduzidos.Text = $"Abduzidos: {ovni.QtdAbduzidos}";
            lblSituacao.Text = $"Situação: {(ovni.Situacao ? "ligado" : "desligado")}";
            lblPlanetaAt.Text = $"Planeta: {ovni.PlanetaAtual}";
            cmbPlanetas.Text = ovni.PlanetaAtual;

            btnOff.Enabled = ovni.Situacao;
            btnOn.Enabled = !ovni.Situacao;

            grbAbduzidos.Enabled = ovni.Situacao;
            grbPlaneta.Enabled = ovni.Situacao;
            grbAddTripulantes.Enabled = ovni.Situacao;
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            if (ovni.Ligar())
            {
                MessageBox.Show("O OVNI foi ligado ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("O OVNI ja foi ligado ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            AtualizarInformacoes();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            if (ovni.Desligar())
            {
                MessageBox.Show("O OVNI foi desligado ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("O OVNI ja foi desligado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
              AtualizarInformacoes(); 
        }

        private void btnAddTripulantes_Click(object sender, EventArgs e)
        {
            if (ovni.AdicionarTripulante())
            {
                MessageBox.Show("Tripulante adcionado ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("S nsve ja esta cheia ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            AtualizarInformacoes();
        }
    }
}
