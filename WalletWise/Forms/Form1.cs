using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WalletWise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool isValueHidden = true;
        private void Lblolho_Click(object sender, EventArgs e)
        {
            isValueHidden = !isValueHidden;
            if (isValueHidden)
            {
                lblSaldo.Text = "R$ *********";
                lblOlho.Image = Properties.Resources.olho_ferchado;
            }
            else
            {
                decimal ValorFinal = CalcularSaldoTotal();
                lblSaldo.Text = "R$ " + ValorFinal.ToString("#,###.00");
                lblOlho.Image = Properties.Resources.olho;
            }
        }

        private void Addtran_Click(object sender, EventArgs e)
        {
            FormCriarTransacao transacao = new FormCriarTransacao();
            transacao.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DalTransacao.CriarBancoSQLite();
            DalTransacao.CriarTabela();
            decimal ValorFinal = CalcularSaldoTotal();
            lblSaldo.Text = "R$ " + ValorFinal.ToString("#,###. 00");
            VerificarUltimaTransacao();
        }
        public decimal CalcularSaldoTotal()
        {
            decimal totalReceitas = 0;
            decimal totalDespesas = 0;
            decimal SaldoTotal = 0;
           
            List<Transacao> transacoes = DalTransacao.GetAll(); 

            foreach (var transacao in transacoes)
            {
                if (transacao.receita_despesa == "Receita")
                {
                    totalReceitas += transacao.Valor;
                }
                else if (transacao.receita_despesa == "Despesa")
                {
                    totalDespesas += transacao.Valor;
                }
            }
            return  SaldoTotal = totalReceitas - totalDespesas;
        }
        private void VerificarUltimaTransacao()
        {
            try
            {
                Transacao ultimaTransacao = DalTransacao.GetUltimaTransacao();

                if (ultimaTransacao != null)
                {
                    if (ultimaTransacao.receita_despesa == "Receita")
                    {
                        lblReceita.Text = "R$ " + ultimaTransacao.Valor.ToString("#,###. 00");
                    }
                    else if (ultimaTransacao.receita_despesa == "Despesa")
                    {
                        lblDespesa.Text = "R$ " + ultimaTransacao.Valor.ToString("#,###. 00");
                    }
                    else
                    {
                        MessageBox.Show("Não há transações registradas no banco.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar a última transação: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTrans_Click(object sender, EventArgs e)
        {
            Graficos graficos = new Graficos();
            graficos.ShowDialog();
            this.Close();
        }
    }
}