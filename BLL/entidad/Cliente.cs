


using entidad;
using System.Collections.Generic;

namespace entidad {
	public class Cliente {

		private string Nombre;
		private string Apellido;
		private string Dni;
		public string Rol;
		private List<Tarjeta> Tarjetas;
		public entidad.Tarjeta m_Tarjeta;

        public Cliente(string nombre, string apellido, string dni, string rol, List<Tarjeta>tarjetas)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Rol = rol;
            Tarjetas = tarjetas;
        }

        

        ~Cliente(){

		}

	}//end Cliente

}//end namespace entidad