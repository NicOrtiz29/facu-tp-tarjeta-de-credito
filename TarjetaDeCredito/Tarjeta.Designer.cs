namespace TarjetaDeCredito
{
    partial class Tarjeta
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
            this.btnCrearTarjeta = new System.Windows.Forms.Button();
            this.lblNumeroDeTarjeta = new System.Windows.Forms.Label();
            this.lblTipoTarjeta = new System.Windows.Forms.Label();
            this.lblLimiteARS = new System.Windows.Forms.Label();
            this.txtNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblLimiteUSD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtBlack = new System.Windows.Forms.RadioButton();
            this.rbtPlatinum = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnCrearTarjeta
            // 
            this.btnCrearTarjeta.Location = new System.Drawing.Point(207, 397);
            this.btnCrearTarjeta.Name = "btnCrearTarjeta";
            this.btnCrearTarjeta.Size = new System.Drawing.Size(277, 64);
            this.btnCrearTarjeta.TabIndex = 0;
            this.btnCrearTarjeta.Text = "Generar Tarjeta";
            this.btnCrearTarjeta.UseVisualStyleBackColor = true;
            // 
            // lblNumeroDeTarjeta
            // 
            this.lblNumeroDeTarjeta.AutoSize = true;
            this.lblNumeroDeTarjeta.Location = new System.Drawing.Point(39, 131);
            this.lblNumeroDeTarjeta.Name = "lblNumeroDeTarjeta";
            this.lblNumeroDeTarjeta.Size = new System.Drawing.Size(120, 16);
            this.lblNumeroDeTarjeta.TabIndex = 1;
            this.lblNumeroDeTarjeta.Text = "Numero de Tarjeta";
            this.lblNumeroDeTarjeta.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTipoTarjeta
            // 
            this.lblTipoTarjeta.AutoSize = true;
            this.lblTipoTarjeta.Location = new System.Drawing.Point(39, 196);
            this.lblTipoTarjeta.Name = "lblTipoTarjeta";
            this.lblTipoTarjeta.Size = new System.Drawing.Size(100, 16);
            this.lblTipoTarjeta.TabIndex = 3;
            this.lblTipoTarjeta.Text = "Tipo de Tarjeta";
            // 
            // lblLimiteARS
            // 
            this.lblLimiteARS.AutoSize = true;
            this.lblLimiteARS.Location = new System.Drawing.Point(369, 304);
            this.lblLimiteARS.Name = "lblLimiteARS";
            this.lblLimiteARS.Size = new System.Drawing.Size(73, 16);
            this.lblLimiteARS.TabIndex = 4;
            this.lblLimiteARS.Text = "Limite ARS";
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(191, 131);
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(277, 22);
            this.txtNumeroTarjeta.TabIndex = 5;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(521, 298);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(130, 22);
            this.txtLimite.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Titual de la tarjeta";
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(191, 70);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.ReadOnly = true;
            this.txtTitular.Size = new System.Drawing.Size(277, 22);
            this.txtTitular.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 304);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 22);
            this.textBox1.TabIndex = 10;
            // 
            // lblLimiteUSD
            // 
            this.lblLimiteUSD.AutoSize = true;
            this.lblLimiteUSD.Location = new System.Drawing.Point(39, 304);
            this.lblLimiteUSD.Name = "lblLimiteUSD";
            this.lblLimiteUSD.Size = new System.Drawing.Size(74, 16);
            this.lblLimiteUSD.TabIndex = 9;
            this.lblLimiteUSD.Text = "Limite USD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Limites";
            // 
            // rbtBlack
            // 
            this.rbtBlack.AutoSize = true;
            this.rbtBlack.Location = new System.Drawing.Point(207, 194);
            this.rbtBlack.Name = "rbtBlack";
            this.rbtBlack.Size = new System.Drawing.Size(62, 20);
            this.rbtBlack.TabIndex = 12;
            this.rbtBlack.TabStop = true;
            this.rbtBlack.Text = "Black";
            this.rbtBlack.UseVisualStyleBackColor = true;
            // 
            // rbtPlatinum
            // 
            this.rbtPlatinum.AutoSize = true;
            this.rbtPlatinum.Location = new System.Drawing.Point(389, 194);
            this.rbtPlatinum.Name = "rbtPlatinum";
            this.rbtPlatinum.Size = new System.Drawing.Size(79, 20);
            this.rbtPlatinum.TabIndex = 13;
            this.rbtPlatinum.TabStop = true;
            this.rbtPlatinum.Text = "Platinum";
            this.rbtPlatinum.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Titular y tarjeta";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(45, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(562, 3);
            this.label4.TabIndex = 15;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(191, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 59);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 488);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbtPlatinum);
            this.Controls.Add(this.rbtBlack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblLimiteUSD);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLimite);
            this.Controls.Add(this.txtNumeroTarjeta);
            this.Controls.Add(this.lblLimiteARS);
            this.Controls.Add(this.lblTipoTarjeta);
            this.Controls.Add(this.lblNumeroDeTarjeta);
            this.Controls.Add(this.btnCrearTarjeta);
            this.Controls.Add(this.groupBox1);
            this.Name = "Tarjeta";
            this.Text = "AltaTarjeta";
            this.Load += new System.EventHandler(this.Tarjeta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearTarjeta;
        private System.Windows.Forms.Label lblNumeroDeTarjeta;
        private System.Windows.Forms.Label lblTipoTarjeta;
        private System.Windows.Forms.Label lblLimiteARS;
        private System.Windows.Forms.TextBox txtNumeroTarjeta;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblLimiteUSD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtBlack;
        private System.Windows.Forms.RadioButton rbtPlatinum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}