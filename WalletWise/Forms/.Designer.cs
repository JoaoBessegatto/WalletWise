namespace WalletWise
{
    partial class Graficos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graficos));
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(158)))), ((int)(((byte)(207)))));
            this.dgvDados.ColumnHeadersHeight = 20;
            this.dgvDados.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDados.Location = new System.Drawing.Point(-26, 133);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDados.RowHeadersWidth = 60;
            this.dgvDados.Size = new System.Drawing.Size(661, 330);
            this.dgvDados.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label13.Location = new System.Drawing.Point(71, 491);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 36);
            this.label13.TabIndex = 39;
            this.label13.Text = "Voltar";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = global::WalletWise.Properties.Resources.Voltar;
            this.btnVoltar.Location = new System.Drawing.Point(71, 526);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(122, 57);
            this.btnVoltar.TabIndex = 38;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Image = global::WalletWise.Properties.Resources.layout_Graficos;
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(634, 130);
            this.lblLogo.TabIndex = 36;
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Location = new System.Drawing.Point(419, 482);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 44);
            this.label12.TabIndex = 41;
            this.label12.Text = "Visualizar graficos";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnDados
            // 
            this.btnDados.Image = global::WalletWise.Properties.Resources.graficos;
            this.btnDados.Location = new System.Drawing.Point(419, 526);
            this.btnDados.Name = "btnDados";
            this.btnDados.Size = new System.Drawing.Size(160, 55);
            this.btnDados.TabIndex = 40;
            this.btnDados.UseVisualStyleBackColor = true;
            // 
            // Graficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnDados);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.lblLogo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Graficos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graficos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDados;
    }
}