///////////////////////////////////////////////////////////
//  Compra.cs
//  Implementation of the Class Compra
//  Generated by Enterprise Architect
//  Created on:      26-jun.-2022 14:42:03
//  Original author: Lenovo
///////////////////////////////////////////////////////////

namespace entidad
{
    public class Compra : Movimiento
    {
        public Compra(Tarjeta tarjeta)
        {

            m_Tarjeta = tarjeta;
        }


        ~Compra()
        {

        }

        public override void actualizarImpuesto(float monto)
        {

        }
    }//end Compra

}//end namespace entidad