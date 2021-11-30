using System;
using System.Globalization;

namespace AluguelDeCarrosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input e processamento de dados
            Console.WriteLine("Entre com os dados da locação:");
            Console.Write("modelo: ");
            string model = Console.ReadLine();
            Console.Write("Check -in (dd / MM / yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Check -out (dd / MM / yyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Entre com o preço por hora: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com preço por dia: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            AluguelCarro aluguel = new AluguelCarro(start, finish, new Veiculo(model));
            Locacao rentalService = new Locacao(hour, day, new TaxaServicoBR());
            rentalService.ProcessInvoice(aluguel);

            //Output de dados
            Console.WriteLine("FATURA: ");
            Console.WriteLine(aluguel.Fatura);

        }
    }
}
