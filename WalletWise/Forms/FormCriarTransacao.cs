using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalletWise
{
    public partial class FormCriarTransacao : Form
    {
        private List<string> itensReceita = new List<string> { "Salário", "Ganhos de investimento", "Aposentadoria/Pensão", "Aluguel recebido", "Outros" };
        private List<string> itensDespesa = new List<string> { "Aluguel", "Transporte", "Alimentação", "Contas (Água, Luz, Internet)", "Saúde", "Lazer", "Impostos"  , "Outros" };

        public FormCriarTransacao()
        {
            InitializeComponent();

            RdbReceita.CheckedChanged += RdbReceita_CheckedChanged;
            RdbDespesa.CheckedChanged += RdbDespesa_CheckedChanged;
        }
       
    
private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

           
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
    
private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string receitaDespesa;
            if (RdbReceita.Checked)
            {
                receitaDespesa = "Receita";
            }
            else if (RdbDespesa.Checked)
            {
                receitaDespesa = "Despesa";
            }
            else
            {
                MessageBox.Show("Selecione 'Receita' ou 'Despesa'");
                return;
            }

            try
            {
                Transacao transacao = new Transacao();
                transacao.Descricao = txtDescricao.Text;
                transacao.tipo_compra = cmbTipo.Text;
                
                transacao.Valor = decimal.Parse(txtValor.Text, new System.Globalization.CultureInfo("pt-BR"));
                transacao.receita_despesa = receitaDespesa;
                transacao.Data = dateTimePicker1.Value;

                DalTransacao.Add(transacao);

                MessageBox.Show("Transação salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescricao.Clear();
                txtValor.Clear();
                cmbTipo.SelectedIndex = -1;
                RdbDespesa.Checked = false;
                RdbReceita.Checked = false; 
            }
            catch (FormatException)
            {
                MessageBox.Show("O valor informado é inválido. Certifique-se de usar vírgula para casas decimais.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar a transação: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void FormCriarTransacao_Load(object sender, EventArgs e)
        {            
            RdbDespesa.Checked = true;  
            AtualizarItensComboBox(itensDespesa);
        }
        private void RdbReceita_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbReceita.Checked)
            {
                AtualizarItensComboBox(itensReceita);
            }
        }
        private void RdbDespesa_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbDespesa.Checked)
            {
                AtualizarItensComboBox(itensDespesa);
            }
        }
        private void AtualizarItensComboBox(List<string> itens)
        {
            cmbTipo.Items.Clear(); // Limpar itens existentes
            cmbTipo.Items.AddRange(itens.ToArray()); // Adicionar novos itens
            cmbTipo.SelectedIndex = -1; // Limpar seleção
        }
    }
}
