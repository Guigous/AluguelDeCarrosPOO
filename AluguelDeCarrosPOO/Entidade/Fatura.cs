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
        //Construtor
        public double Pagamento { get; set; }
        public double Taxa { get; set; }
        public Fatura(double pagamento, double taxa)
        {
            Pagamento = pagamento;
            Taxa = taxa;
        }
       
        public double PagamentoTotal
        {
            get { return basicPayment + Taxa; }
        }
        public override string ToString()
        {
            //retorno da fatura
            return "Basic payment: "
            + Pagamento.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTaxa: "
            + Taxa.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTotal payment: "
            + PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
