using entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class ClientesHardCod 
    {
        public static List<Cliente> CrearCliente()
        {

            List<Cliente> clientes = new List<Cliente>(); 
            List<Tarjeta> tarjetas = new List<Tarjeta>();   

            
            tarjetas.Add(new Platinium("1234567890123456", 0, 0));
            tarjetas.Add(new Black("1234567890123456", 0, 0, 0, 0)); 
            clientes.Add(new Cliente("Nicolas", "Ortiz", "34812934", "algo",tarjetas));

            
            
           
            return clientes;

            

        }

    }
}
