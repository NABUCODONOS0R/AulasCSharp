using System;
using System.Collections.Generic;
using System.Text;
using InterfacesAula_26_05_2022.Services;


namespace InterfacesAula_26_05_2022.Services
{
    internal class ImpostoEstacionamento : ITaxas
    {
        public double ImpostoEst(double valor)//valor = pagamento base
        {
            if (valor <= 50.00)
            {
                return valor * 0.05;
            }
            else
            {
                return valor * 0.10;
            }
        }
    }
}
