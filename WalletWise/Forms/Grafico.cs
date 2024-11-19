using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
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
    public partial class Grafico : Form
    {
        public Grafico()
        {
            InitializeComponent();         
        }

        private void Grafico_Load(object sender, EventArgs e)
        {
            CarregarGrafico();
        }
        private void CarregarGrafico()
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            Title titulo = chart1.Titles.Add("Receitas e Despesas por Mês");
            titulo.Font = new Font("Arial", 16, FontStyle.Bold);
            titulo.ForeColor = Color.DarkGreen;

            var chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea("MainArea");
            chart1.ChartAreas.Add(chartArea);

            var seriesReceitas = new System.Windows.Forms.DataVisualization.Charting.Series("Receitas")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                Color = Color.Green,
                BorderWidth = 2,
                Font = new Font("Arial", 10, FontStyle.Regular),
                IsVisibleInLegend = true
            };

            var seriesDespesas = new System.Windows.Forms.DataVisualization.Charting.Series("Despesas")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                Color = Color.Red,
                BorderWidth = 2,
                Font = new Font("Arial", 10, FontStyle.Regular),
                IsVisibleInLegend = true
            };

            chart1.Series.Add(seriesReceitas);
            chart1.Series.Add(seriesDespesas);

            var dados = DalTransacao.ObterDadosGrafico();

            foreach (var item in dados)
            {
                seriesReceitas.Points.AddXY(item.Mes, item.Receitas);
                seriesDespesas.Points.AddXY(item.Mes, item.Despesas);
            }

            chart1.BackColor = Color.LightGray;

            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "C";

            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10, FontStyle.Regular);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Graficos CriarTrans = new Graficos();
            CriarTrans.ShowDialog();
            this.Close();

        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            this.Hide();
            GraficoPizza graficoPizza = new GraficoPizza();
            graficoPizza.ShowDialog();
            this.Close();
        }
    }    
}
