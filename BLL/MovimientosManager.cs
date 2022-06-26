using entidad;
using System;

namespace BLL
{
    public class MovimientosManager
    {
        public void HacerCompra(Movimiento movimiento, Tarjeta tarjeta)
        {
            if (movimiento.Moneda == "ARS")
            {
                if (tarjeta.LimitePesos < movimiento.Monto)
                {
                    throw new LimiteNoAlcanzaException("Limite insuficiente");
                }
                else
                {
                    tarjeta.SaldoPesos -= movimiento.Monto;
                }
            }
            else
            {
                // USD...
                if (tarjeta.LimiteUSD < movimiento.Monto)
                {
                    throw new LimiteNoAlcanzaException("Limite insuficiente");
                }
                else
                {
                    tarjeta.SaldoUSD -= movimiento.Monto;
                }

            }

            // actualizar el panel principal!!

        }

        public void HacerPago(Movimiento movimiento, Tarjeta tarjeta)
        {
            if (movimiento.Moneda == "ARS")
            {
                tarjeta.SaldoPesos += movimiento.Monto;
            }
            else
            {
                tarjeta.SaldoUSD += movimiento.Monto;
            }

            // actualizar el panel principal!!
        }
    }
}
