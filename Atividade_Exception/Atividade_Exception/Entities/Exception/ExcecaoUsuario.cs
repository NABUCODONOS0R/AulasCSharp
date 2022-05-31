using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_Exception.Entities.Exception
{
    internal class ExcecaoUsuario : ApplicationException
    {
        public ExcecaoUsuario(string message) : base(message)
        {


        }
        
    }
}
