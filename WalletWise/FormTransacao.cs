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
    public partial class FormTransacao : Form
    {
        public FormTransacao()
        {
            InitializeComponent();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.' || e.KeyChar == ',') &&
                ((sender as TextBox).Text.IndexOf('.') > -1 ||
                 (sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
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
                transacao.Valor = decimal.Parse(txtValor.Text, System.Globalization.NumberStyles.Currency);
                transacao.receita_despesa = receitaDespesa;
                transacao.Data = dateTimePicker1.Value;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
    }
}
