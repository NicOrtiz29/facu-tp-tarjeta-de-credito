using entidad;
using System;
using System.Windows.Forms;

namespace TarjetaDeCredito
{
    public partial class TarjetaFrm : Form
    {
        internal Cliente Cliente;
        internal PanelPrincipal PanelForm;

        public TarjetaFrm()
        {
            InitializeComponent();
        }

        private void Tarjeta_Load(object sender, EventArgs e)
        {
            txtTitular.Text = Cliente.Nombre + " " + Cliente.Apellido;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNumeroTarjeta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearTarjeta_Click(object sender, EventArgs e)
        {
            string numeroTarjeta = txtNumeroTarjeta.Text;

            if (numeroTarjeta.Length != 16)
            {
                MessageBox.Show("Debe tener 16 digitos numericos");
            }
            // Validar tambien que sean solo numeros!!



            float limiteARS = 1000; // try parse! textBox1.Text;
            float limiteUSD = 1000;// try parse! txtLimite.Text;

            Tarjeta tarjeta;
            if (rbtBlack.Checked)
            {
                tarjeta = new Black(numeroTarjeta, 0, limiteARS, 0, limiteUSD);
            }
            else
            {
                tarjeta = new Platinium(numeroTarjeta, 0, limiteARS);
            }

            Cliente.Tarjetas.Add(tarjeta);

            PanelForm.actualizarPanel(Cliente);
            this.Close();
        }

        private void rbtBlack_CheckedChanged(object sender, EventArgs e)
        {
            rbtPlatinum.Checked = false;
        }

        private void rbtPlatinum_CheckedChanged(object sender, EventArgs e)
        {
            rbtBlack.Checked = false;
        }
    }
}
