using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class LimiteNoAlcanzaException : Exception
    {
        public LimiteNoAlcanzaException(string message) : base(message)
        {
        }
    }
}
