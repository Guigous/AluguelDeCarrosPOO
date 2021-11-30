using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelDeCarrosPOO
{
    class Fatura
    {
        public double basicPayment { get; set; }
        public double Taxa { get; set; }
        public Fatura(double aluguel, double taxa)
        {
            basicPayment = aluguel;
            Taxa = taxa;
        }
        public double PagamentoTotal
        {
            get { return basicPayment + Taxa; }
        }
        public override string ToString()
        {
            return "Basic payment: "
            + basicPayment.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTaxa: "
            + Taxa.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTotal payment: "
            + PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
