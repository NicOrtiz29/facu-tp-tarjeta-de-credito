using entidad;









namespace entidad {
	public class Black : Tarjeta {

		
        public Black(string numeroTarjeta, float saldoPesos, float limite, float saldoUSD,float limiteUSD)
		{
			NumeroTarjeta = numeroTarjeta;
			Categoria = "Black";
			SaldoPesos = saldoPesos;
			LimitePesos = limite;
			SaldoUSD = saldoUSD;
			LimiteUSD = limiteUSD;

		}

		~Black(){

		}

		public float CalcularGastoAdministrativo(){

			return 0;
		}

        public override float CalcularGastoAdministrativo(float monto)
        {
			return (float)(monto * 0.01);
        }

        public float ImpactarMiovimiento(){

			return 0;
		}

        public override string Tipo()
        {
			return Categoria;
        }
    }//end Black

}//end namespace entidad