﻿namespace WalletWise
{
    partial class FormCriarTransacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCriarTransacao));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdbDespesa = new System.Windows.Forms.RadioButton();
            this.RdbReceita = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 187);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(408, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(95, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 44);
            this.label11.TabIndex = 15;
            this.label11.Text = "Selecione a data";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(95, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 44);
            this.label6.TabIndex = 18;
            this.label6.Text = "Descrição";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(97, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 44);
            this.label7.TabIndex = 19;
            this.label7.Text = "Selecione o tipo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(95, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 44);
            this.label8.TabIndex = 21;
            this.label8.Text = "Valor da transação";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Alimentação",
            "Fixo",
            "Transporte ",
            "Saúde ",
            "Lazer"});
            this.cmbTipo.Location = new System.Drawing.Point(114, 322);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(408, 21);
            this.cmbTipo.TabIndex = 23;
            this.cmbTipo.Text = "Selecione o tipo de compra";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(114, 395);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(408, 20);
            this.txtDescricao.TabIndex = 24;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(114, 471);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(408, 20);
            this.txtValor.TabIndex = 25;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Location = new System.Drawing.Point(95, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 44);
            this.label12.TabIndex = 29;
            this.label12.Text = "Receita ou Despesa";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.RdbDespesa);
            this.groupBox1.Controls.Add(this.RdbReceita);
            this.groupBox1.Location = new System.Drawing.Point(114, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 20);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // RdbDespesa
            // 
            this.RdbDespesa.AutoSize = true;
            this.RdbDespesa.Location = new System.Drawing.Point(335, 2);
            this.RdbDespesa.Name = "RdbDespesa";
            this.RdbDespesa.Size = new System.Drawing.Size(67, 17);
            this.RdbDespesa.TabIndex = 1;
            this.RdbDespesa.TabStop = true;
            this.RdbDespesa.Text = "Despesa";
            this.RdbDespesa.UseVisualStyleBackColor = true;
            // 
            // RdbReceita
            // 
            this.RdbReceita.AutoSize = true;
            this.RdbReceita.Location = new System.Drawing.Point(2, 2);
            this.RdbReceita.Name = "RdbReceita";
            this.RdbReceita.Size = new System.Drawing.Size(62, 17);
            this.RdbReceita.TabIndex = 0;
            this.RdbReceita.TabStop = true;
            this.RdbReceita.Text = "Receita";
            this.RdbReceita.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label13.Location = new System.Drawing.Point(101, 507);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 36);
            this.label13.TabIndex = 33;
            this.label13.Text = "Salvar";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label15.Location = new System.Drawing.Point(400, 507);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 36);
            this.label15.TabIndex = 35;
            this.label15.Text = "Cancelar";
            this.label15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::WalletWise.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(400, 542);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 57);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label10
            // 
            this.label10.Image = global::WalletWise.Properties.Resources.input__1_;
            this.label10.Location = new System.Drawing.Point(94, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(445, 40);
            this.label10.TabIndex = 28;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::WalletWise.Properties.Resources.salvar__1_;
            this.btnSalvar.Location = new System.Drawing.Point(101, 542);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(122, 57);
            this.btnSalvar.TabIndex = 26;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label9
            // 
            this.label9.Image = global::WalletWise.Properties.Resources.input__1_;
            this.label9.Location = new System.Drawing.Point(94, 461);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(445, 40);
            this.label9.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Image = global::WalletWise.Properties.Resources.input__1_;
            this.label5.Location = new System.Drawing.Point(94, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(445, 40);
            this.label5.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Image = global::WalletWise.Properties.Resources.input__1_;
            this.label4.Location = new System.Drawing.Point(96, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(445, 40);
            this.label4.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Image = global::WalletWise.Properties.Resources.input__1_;
            this.label3.Location = new System.Drawing.Point(94, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 40);
            this.label3.TabIndex = 5;
            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Image = global::WalletWise.Properties.Resources.layout_transação;
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(634, 130);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
            // 
            // FormCriarTransacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCriarTransacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Criar transação";
            this.Load += new System.EventHandler(this.FormCriarTransacao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdbReceita;
        private System.Windows.Forms.RadioButton RdbDespesa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
    }
}