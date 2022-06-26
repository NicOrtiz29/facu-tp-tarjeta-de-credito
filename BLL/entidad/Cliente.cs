using System.Collections.Generic;

namespace entidad
{
    public class Cliente
    {

        public string Nombre;
        public string Apellido;
        public string Dni;
        public string Rol;
        public List<Tarjeta> Tarjetas;


        public Cliente(string nombre, string apellido, string dni, string rol, List<Tarjeta> tarjetas)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Rol = rol;
            Tarjetas = tarjetas;
        }



        ~Cliente()
        {

        }

    }//end Cliente

}//end namespace entidad