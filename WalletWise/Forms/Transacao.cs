using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalletWise.Forms;

namespace WalletWise
{
    public partial class Graficos : Form
    {
        public Graficos()
        {
            InitializeComponent();
            ExibirDados();
        }
        private void ExibirDados()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DalTransacao.GetTransacoes();
                dgvDados.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void btnGraficos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Grafico grafico = new Grafico();    
            grafico.ShowDialog();
            this.Close();
        }
    }
}
