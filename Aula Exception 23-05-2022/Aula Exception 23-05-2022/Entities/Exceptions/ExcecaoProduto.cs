using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_Exception_23_05_2022.Entities.Exceptions
{
    internal class ExcecaoProduto : ApplicationException
    {
        public ExcecaoProduto(string message) : base(message)
        {

        }

    }
}
