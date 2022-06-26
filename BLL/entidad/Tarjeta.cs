///////////////////////////////////////////////////////////
//  Tarjeta.cs
//  Implementation of the Class Tarjeta
//  Generated by Enterprise Architect
//  Created on:      26-jun.-2022 14:42:03
///////////////////////////////////////////////////////////




namespace entidad {
	public abstract class Tarjeta {

		public string NumeroTarjeta;
		public string Categoria;
		public float SaldoPesos;
		public float LimitePesos;
		public float SaldoUSD;
		public float LimiteUSD;
		abstract public string Tipo();
    

        ~Tarjeta(){

		}

		public abstract float CalcularGastoAdministrativo(float monto);

		public float ImpactarMiovimiento(){

			return 0;
		}

	}//end Tarjeta

}//end namespace entidad