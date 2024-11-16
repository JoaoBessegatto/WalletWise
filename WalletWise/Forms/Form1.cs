﻿using System;
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
                lblSaldo.Text = "R$ 1.200.00,00";
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

        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            Graficos graficos = new Graficos();
            graficos.ShowDialog();
            this.Close();
        }
    }
}