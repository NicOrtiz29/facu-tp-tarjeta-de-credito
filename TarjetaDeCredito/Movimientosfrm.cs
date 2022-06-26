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
    public partial class Movimientosfrm : Form
    {
        float impuesto=0;
        private Cliente ClienteActivo;
        private entidad.Tarjeta Tarjeta;

        Movimiento movimiento;
        internal string accion;

        public Movimientosfrm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                new ComprasManager().HacerCompra(movimiento, Tarjeta);
            }
            catch (LimiteNoAlcanzaException)
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            movimiento.Moneda = comboBox1.Text;
        }

        private void Movimientosfrm_Load(object sender, EventArgs e)
        {
            switch (accion)
            {
                case "comprar":
                    movimiento = new Compra(Tarjeta);
                    break;
                case "pagar":
                    movimiento = new Pago();
                    break;
            }
            

            comboBox1.Items.Add("ARS");
            
            if (Tarjeta.Tipo() == "Black")
            {
                comboBox1.Items.Add("USD");
            }
        }

        internal void Cliente(Cliente clienteActivo, entidad.Tarjeta tarjeta)
        {
            ClienteActivo = clienteActivo;
            Tarjeta = tarjeta;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            float monto = 100;// tryparse! textBox2.Text);

            float gastosAdministrativos = 0;
            if (accion == "comprar")
            { 
            gastosAdministrativos=Tarjeta.CalcularGastoAdministrativo(monto);
            }

            movimiento.Monto = monto;
            movimiento.actualizarImpuesto(monto);
            textBox5.Text = "" + movimiento.Impuesto + "";
            textBox3.Text = "" + gastosAdministrativos + "";

            float total = monto + gastosAdministrativos;
            textBox4.Text = ""+total+"";
            movimiento.Monto = total;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            movimiento.Concepto = textBox1.Text;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
