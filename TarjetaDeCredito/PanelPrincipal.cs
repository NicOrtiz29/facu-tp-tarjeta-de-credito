using BLL;
using entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TarjetaDeCredito
{
    public partial class PanelPrincipal : Form
    {
        public PanelPrincipal()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            List<Cliente> clientes = ClientesHardCod.CrearCliente();

            foreach (Cliente cliente in clientes)
            {
                comboBox1.Items.Add(cliente.Nombre + " " + cliente.Apellido + " (" + cliente.Dni + ")");


            }

        }

        private void btnAltaTarjeta_Click(object sender, EventArgs e)
        {
            new Tarjeta().Show();
            this.Close();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}