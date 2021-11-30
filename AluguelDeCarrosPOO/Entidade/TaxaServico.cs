using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelDeCarrosPOO
{
    //Interface
    interface ITaxaServico
    {
        double Tax(double amount);
    }



    //classe de taxas usando a interface
    class TaxaServicoBR : ITaxaServico
    {
        public double Tax(double amount)
        {
            if (amount <= 100.00)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}

