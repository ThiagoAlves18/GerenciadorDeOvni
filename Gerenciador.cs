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
        public void checarPlaneta()
        {
            if(ovni.PlanetaAtual == "Terra")
            {
                pibTerra.Show();
                pibTerra.Image = Properties.Resources.Captura_de_tela_2025_08_26_194832;

            }
            else
            {
                pibTerra.Hide();
            }
        }
        public void AtualizarInformacoes()
        {
            lblTripulantes.Text = $"Tripulantes: {ovni.QtdTripulantes}";
            lblAbduzidos.Text = $"Abduzidos: {ovni.QtdAbduzidos}";
            lblSituacao.Text = $"Situação: {(ovni.Situacao ? "ligado" : "desligado")}";
            lblPlanetaAt.Text = $"Planeta: {ovni.PlanetaAtual}";
            cmbPlanetas.Text = ovni.PlanetaAtual;
            pibTerra.Hide();

            btnOff.Enabled = ovni.Situacao;
            btnOn.Enabled = !ovni.Situacao;

            grbAbduzidos.Enabled = ovni.Situacao;
            grbPlaneta.Enabled = ovni.Situacao;
            grbAddTripulantes.Enabled = ovni.Situacao;
            checarPlaneta();

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
                MessageBox.Show("A nave ja esta cheia ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            AtualizarInformacoes();
        }

        private void btnRemoverTripulantes_Click(object sender, EventArgs e)
        {
            if (ovni.RemoverTripulante())
            {
                MessageBox.Show("Tripulante removido ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Nao é possivel mais remover tripulantes ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            AtualizarInformacoes();
        }

        private void btnAdicionarAbduzidos_Click(object sender, EventArgs e)
        {
            if (ovni.Abduzir())
            {
                MessageBox.Show("ABDUZINDO", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Ja abduziu gente demais", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            AtualizarInformacoes();
        }

        private void btnRemoverAbduzidos_Click(object sender, EventArgs e)
        {
            if (ovni.Desabduzir())
            {
                MessageBox.Show("Pessoa ejetada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Não tem mais pessoas para jogar da nave", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            AtualizarInformacoes();
        }

        private void btnMudarDePlaneta_Click(object sender, EventArgs e)
        {
            if (ovni.MudarPlaneta(cmbPlanetas.Text))
            {
                MessageBox.Show("Mudamos de planeta !", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao viajar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            AtualizarInformacoes();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            if (ovni.RetornarAoPlanetaDeOrigem())
            {
                MessageBox.Show("Retornamos ao nosso planta natal", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Erro ao voltar para casa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            AtualizarInformacoes();


        }
    }
}
