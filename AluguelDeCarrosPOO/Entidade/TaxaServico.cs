using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelDeCarrosPOO
{
    interface ITaxaServico
    {
        double Tax(double amount);
    }




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

