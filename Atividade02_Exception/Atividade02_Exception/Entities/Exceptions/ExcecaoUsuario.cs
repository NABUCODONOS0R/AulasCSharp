using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade02_Exception.Entities.Exceptions
{
    internal class ExcecaoUsuario : ApplicationException
    {
        public ExcecaoUsuario(string message) : base(message)
        {

        }
    }
}
