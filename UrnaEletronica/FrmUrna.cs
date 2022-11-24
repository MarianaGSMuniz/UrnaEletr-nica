using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica
{
    public partial class FrmUrna : Form
    {
        public FrmUrna()
        {
            InitializeComponent();
        }

        // Para guardar a quantidade de votos de cada candidato.
        int mario, batman, barbie,branco = 0;

        void NovoDigito(string digito)
        {
            if (txtNumero1.Text == "")
                txtNumero1.Text = digito;
            else
            {
                txtNumero2.Text = digito;
                ValidarVoto();
            }
        }

        void ValidarVoto()
        {
            switch (txtNumero1.Text + txtNumero2.Text)
            {
                case "15":
                    pcbCandidato.BackgroundImage = Image.FromFile("barbie.png");
                    lblNomeCandidato.Text = "Barbie";
                    lblNomeCandidato.Visible = true;
                    break;
                case "22":
                    pcbCandidato.BackgroundImage = Image.FromFile("batman.png");
                    lblNomeCandidato.Text = "Batman";
                    lblNomeCandidato.Visible = true;
                    break;
                case "11":
                    pcbCandidato.BackgroundImage = Image.FromFile("mario.png");
                    lblNomeCandidato.Text = "Mario";
                    lblNomeCandidato.Visible = true;
                    break;
                
                default:
                    MessageBox.Show("Candidato Inválido!");
                    txtNumero1.Clear();
                    txtNumero2.Clear();
                    break;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            NovoDigito("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            NovoDigito("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            NovoDigito("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            NovoDigito("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            NovoDigito("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            NovoDigito("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            NovoDigito("7");
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        void Limpar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            pcbCandidato.BackgroundImage = null;
            lblNomeCandidato.Visible = false;
            lblNomeCandidato.Text = "";
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            lblNomeCandidato.Visible = true;
            lblNomeCandidato.Text = "Voto em Branco";
            pcbCandidato.BackgroundImage = null;
            txtNumero1.Clear();
            txtNumero2.Clear();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (lblNomeCandidato.Text == "Voto em Branco")
            {
                branco++;
                lblNomeCandidato.Text = "";
                TocarSom();
                Limpar();
            }
            else
            {
                switch (txtNumero1.Text + txtNumero2.Text)
                {
                    case "15":
                        mario++;
                        TocarSom();
                        Limpar();
                        break;
                    case "22":
                        batman++;
                        TocarSom();
                        Limpar();
                        break;
                    case "31":
                        barbie++;
                        TocarSom();
                        Limpar();
                        break;
                   default:
                        MessageBox.Show("Você precisa informar um voto válido!");
                        break;
                }
            }
        }

        private void btnEncerrarVotacao_Click(object sender, EventArgs e)
        {
            FrmResultado frmResultado = new FrmResultado(mario, batman, barbie, branco);
            frmResultado.ShowDialog();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            NovoDigito("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            NovoDigito("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            NovoDigito("0");
        }

        void TocarSom()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("som_urna.wav");
            player.Play();
        }
    }
}
