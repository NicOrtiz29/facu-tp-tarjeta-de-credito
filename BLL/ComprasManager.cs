using entidad;

namespace BLL
{
    public class ComprasManager
    {
        public void HacerCompra(Movimiento compra, Tarjeta tarjeta)
        {
            if (compra.Moneda == "ARS")
            {
                if (tarjeta.LimitePesos < compra.Monto)
                {
                    throw new LimiteNoAlcanzaException("Limite insuficiente");
                }
                else
                {
                    tarjeta.SaldoPesos -= compra.Monto;
                }
            }
            else
            {
                // USD...
                if (tarjeta.LimiteUSD < compra.Monto)
                {
                    throw new LimiteNoAlcanzaException("Limite insuficiente");
                }
                else
                {
                    tarjeta.SaldoUSD -= compra.Monto;
                }

            }

            // actualizar el panel principal!!

        }
    }
}
