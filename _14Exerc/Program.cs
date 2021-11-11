using System;
using System.Globalization;
using System.Collections.Generic;
using _14Exerc.Entities;
using _14Exerc.Services;

namespace _14Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/mm/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

          
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());
            Contract myContract = new Contract(number, date, value);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(myContract, months);

            Console.WriteLine("Installments:");
            foreach (Installment installment in myContract.Installments)
            {
                Console.WriteLine(installment);


            }
        }
    }
}
