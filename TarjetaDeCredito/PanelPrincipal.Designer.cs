namespace TarjetaDeCredito
{
    partial class PanelPrincipal
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
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnAltaTarjeta = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnPago = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.TipoTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limites = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoDolar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimiteDolar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(64, 534);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(160, 38);
            this.btnComprar.TabIndex = 2;
            this.btnComprar.Text = "Realizar una Compra";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // btnAltaTarjeta
            // 
            this.btnAltaTarjeta.Enabled = false;
            this.btnAltaTarjeta.Location = new System.Drawing.Point(850, 206);
            this.btnAltaTarjeta.Name = "btnAltaTarjeta";
            this.btnAltaTarjeta.Size = new System.Drawing.Size(128, 40);
            this.btnAltaTarjeta.TabIndex = 3;
            this.btnAltaTarjeta.Text = "Agregar Tarjeta";
            this.btnAltaTarjeta.UseVisualStyleBackColor = true;
            this.btnAltaTarjeta.Click += new System.EventHandler(this.btnAltaTarjeta_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(767, 534);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(160, 38);
            this.btnDeposito.TabIndex = 4;
            this.btnDeposito.Text = "Realizar un Deposito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            // 
            // btnPago
            // 
            this.btnPago.Location = new System.Drawing.Point(416, 534);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(160, 38);
            this.btnPago.TabIndex = 5;
            this.btnPago.Text = "Realizar un Pago";
            this.btnPago.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-480, -119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "1. Elija un cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "2. Elija la accion deseada";
            // 
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoTarjeta,
            this.Saldo,
            this.Limites,
            this.SaldoDolar,
            this.LimiteDolar,
            this.NumeroTarjeta});
            this.dgvClientes.Enabled = false;
            this.dgvClientes.Location = new System.Drawing.Point(12, 206);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(806, 176);
            this.dgvClientes.TabIndex = 2;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // TipoTarjeta
            // 
            this.TipoTarjeta.HeaderText = "Tipo";
            this.TipoTarjeta.MinimumWidth = 6;
            this.TipoTarjeta.Name = "TipoTarjeta";
            this.TipoTarjeta.Width = 125;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo ARS";
            this.Saldo.MinimumWidth = 6;
            this.Saldo.Name = "Saldo";
            this.Saldo.Width = 125;
            // 
            // Limites
            // 
            this.Limites.HeaderText = "Limite ARS";
            this.Limites.MinimumWidth = 6;
            this.Limites.Name = "Limites";
            this.Limites.Width = 125;
            // 
            // SaldoDolar
            // 
            this.SaldoDolar.HeaderText = "Saldo USD";
            this.SaldoDolar.MinimumWidth = 6;
            this.SaldoDolar.Name = "SaldoDolar";
            this.SaldoDolar.Width = 125;
            // 
            // LimiteDolar
            // 
            this.LimiteDolar.HeaderText = "Limite USD";
            this.LimiteDolar.MinimumWidth = 6;
            this.LimiteDolar.Name = "LimiteDolar";
            this.LimiteDolar.Width = 125;
            // 
            // NumeroTarjeta
            // 
            this.NumeroTarjeta.HeaderText = "Numero de Tarjeta";
            this.NumeroTarjeta.MinimumWidth = 6;
            this.NumeroTarjeta.Name = "NumeroTarjeta";
            this.NumeroTarjeta.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tarjetas asociadas al cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "1. Elija un cliente";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(298, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 589);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.btnAltaTarjeta);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.dgvClientes);
            this.Name = "PanelPrincipal";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnAltaTarjeta;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limites;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoDolar;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimiteDolar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroTarjeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}