using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WalletWise.Forms
{
    public partial class GraficoPizza : Form
    {
        public GraficoPizza()
        {
            InitializeComponent();
            CarregarGraficoDespesas();
        }
        private void CarregarGraficoDespesas()
        {
            try
            {
                
                DataTable dadosDespesas = DalTransacao.GetDespesasAgrupadasPorTipo();

                
                chartDespesas.Series.Clear();
                chartDespesas.Titles.Clear();
                chartDespesas.Legends.Clear();

                
                Title titulo = chartDespesas.Titles.Add("Distribuição de Despesas por Tipo");
                titulo.Font = new Font("Arial", 16, FontStyle.Bold);

                
                Series serie = chartDespesas.Series.Add("Despesas");
                serie.ChartType = SeriesChartType.Pie;

                
                serie.Font = new Font("Tahoma", 12, FontStyle.Regular);
                serie.Label = "#PERCENT{P0}";
                serie.LegendText = "#VALX";

                
                foreach (DataRow row in dadosDespesas.Rows)
                {
                    string tipo = row["tipo_compra"].ToString();
                    decimal valor = Convert.ToDecimal(row["total"]);
                    serie.Points.AddXY(tipo, valor);
                }

                
                Legend legenda = new Legend("Legenda");
                legenda.Font = new Font("Verdana", 10, FontStyle.Italic);
                chartDespesas.Legends.Add(legenda);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o gráfico: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Grafico grafico = new Grafico();
            grafico.ShowDialog();
            this.Close();
        }
    }
}
