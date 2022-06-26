using System;

namespace BLL
{
    public class LimiteNoAlcanzaException : Exception
    {
        public LimiteNoAlcanzaException(string message) : base(message)
        {
        }
    }
}
