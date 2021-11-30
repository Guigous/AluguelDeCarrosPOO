using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelDeCarrosPOO
{
    //Nomeacao da Classe
    class Locacao
    {
        //Construtor 
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }


        private ITaxaServico _taxaServico;
        public Locacao(double precoPorHora, double precoPorDia, ITaxaServico taxaServico)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _taxaServico = taxaServico;
        }

        //Metodo da fatura
        public void ProcessoFatura(AluguelCarro aluguelCarro)
        {
            //Calculos de tempo e apicacao das taxas
            TimeSpan duracao = aluguelCarro.Finish.Subtract(aluguelCarro.Start);
            double basicPayment = 0.0;
            if (duracao.TotalHours <= 12.0)
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
