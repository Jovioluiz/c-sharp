using System;
using System.Globalization;
using ExercicioInterfaceContrato.Entities;
using ExercicioInterfaceContrato.Services;

namespace ExercicioInterfaceContrato {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numero, data, valor);

            ServicoContrato contractService = new ServicoContrato(new ServicoPaypal());
            contractService.ProcessaContrato(contrato, months);

            Console.WriteLine("Installments:");
            foreach (Parcelas parcela in contrato.Parcelas)
            {
                Console.WriteLine(parcela);
            }
        }
    }
}
