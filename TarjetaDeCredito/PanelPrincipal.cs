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

        Cliente clienteActivo=null;
        TarjetaFrm tarjetaSeleccionada = null;

        public PanelPrincipal()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            List<Cliente> clientes = ClientesHardCod.CrearCliente();

            foreach (Cliente cliente in clientes)
            {
                comboBox1.Items.Add(cliente.Dni);


            }

        }

        private void btnAltaTarjeta_Click(object sender, EventArgs e)
        {
            TarjetaFrm form = new TarjetaFrm();
            form.Cliente = clienteActivo;
            form.PanelForm = this;
            form.ShowDialog();
            
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dni = comboBox1.Text;

            List<Cliente> clientes = ClientesHardCod.CrearCliente();



            foreach (Cliente cliente in clientes)
            {

                if (dni == cliente.Dni)
                {
                    clienteActivo= cliente;
                    break;
                }             

            }
            actualizarSeccionTarjetas();

        }

        private void actualizarSeccionTarjetas()
        {
            dgvClientes.Columns.Clear();
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Tipo"));
            dt.Columns.Add(new DataColumn("SaldoARS"));
            dt.Columns.Add(new DataColumn("LimiteARS"));
            dt.Columns.Add(new DataColumn("SaldoUSD"));
            dt.Columns.Add(new DataColumn("LimiteUSD"));
            dt.Columns.Add(new DataColumn("Numero de Tarjeta"));

            foreach (entidad.Tarjeta tarjeta in clienteActivo.Tarjetas)
            {
                DataRow dr = dt.NewRow();
                dr[0] = tarjeta.Tipo();
                dr[1] = tarjeta.SaldoPesos;
                dr[2] = tarjeta.LimitePesos;
                dr[3] = tarjeta.SaldoUSD;
                dr[4] = tarjeta.LimiteUSD;
                dr[5] = tarjeta.NumeroTarjeta;
                dt.Rows.Add(dr);

               
            }

            dgvClientes.DataSource = dt;


            btnAltaTarjeta.Enabled = true;

            }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            abrirPantallaMovimiento("comprar");
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            abrirPantallaMovimiento("pagar");
        }

        private void abrirPantallaMovimiento(string accion)
        {
            Movimientosfrm form = new Movimientosfrm();

            form.Cliente(clienteActivo, clienteActivo.Tarjetas[dgvClientes.CurrentRow.Index]);
            form.accion = accion;
            form.ShowDialog();
        }

        public void actualizarPanel(Cliente cliente)
        {
            clienteActivo = cliente;
            actualizarSeccionTarjetas();
        }

        
    }
}