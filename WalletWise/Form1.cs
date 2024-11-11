using System;
using System.Windows.Forms;

namespace WalletWise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int acionado = 0;
        private bool isValueHidden = true;
        private void Lblolho_Click(object sender, EventArgs e) {
            isValueHidden = !isValueHidden;
            if (isValueHidden) {
                lblSaldo.Text = "R$ *********"; 
                lblOlho.Image = Properties.Resources.olho_ferchado;
            }
            else
            {
                lblSaldo.Text = "R$ 1.200.00,00";
                lblOlho.Image = Properties.Resources.olho;
            }
        }

        private void Addtran_Click(object sender, EventArgs e)
        {
            Transacao transacao = new Transacao();
            transacao.ShowDialog();
        }
    }
}
