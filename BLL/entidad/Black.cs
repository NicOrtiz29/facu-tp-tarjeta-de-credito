using entidad;









namespace entidad {
	public class Black : Tarjeta {

		private float SaldoUSD;
        private float LimiteUSD;

        public Black(string numeroTarjeta, float saldoPesos, float limite, float saldoUSD,float limiteUSD)
		{
			NumeroTarjeta = numeroTarjeta;
			Categoria = "Black";
			SaldoPesos = saldoPesos;
			Limite = limite;
			SaldoUSD = saldoUSD;
			LimiteUSD = limiteUSD;

		}

		~Black(){

		}

		public float CalcularGastoAdministrativo(){

			return 0;
		}

		public float ImpactarMiovimiento(){

			return 0;
		}

	}//end Black

}//end namespace entidad