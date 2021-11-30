using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelDeCarrosPOO
{
    class Locacao
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        private ITaxaServico _taxaServico;
        public Locacao(double pricePerHour, double pricePerDay, ITaxaServico taxaServico)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxaServico = taxaServico;
        }
        public void ProcessInvoice(AluguelCarro aluguelCarro)
        {
            TimeSpan duration = aluguelCarro.Finish.Subtract(aluguelCarro.Start);
            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }
            double tax = _taxaServico.Tax(basicPayment);
            aluguelCarro.Fatura = new Fatura(basicPayment, tax);
        }
    }
}
