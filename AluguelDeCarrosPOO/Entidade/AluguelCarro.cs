using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelDeCarrosPOO
{
    class AluguelCarro
    {
        //cosntrutor
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Veiculo Veiculo { get; private set; }
        public Fatura Fatura { get; set; }
        
        
        
        
        public AluguelCarro(DateTime checkin, DateTime checkout, Veiculo veiculo)
        {

            Checkin = checkin;
            checkout = checkout;
            Veiculo = veiculo;
            Fatura = null;

        }
    }
}
