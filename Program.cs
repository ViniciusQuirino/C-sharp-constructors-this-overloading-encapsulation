using System;
using System.Globalization;
using C_sharp_constructors_this_overloading_encapsulation;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Nome do titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)?");
            string question = Console.ReadLine().ToLower();

            Operation o = new Operation();

            while (question != "s" && question != "n")
            {

                Console.WriteLine("INVALIDO");
                Console.Write("Haverá depósito inicial (s/n)?");
                question = Console.ReadLine().ToLower();
            }
            if (question == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                o = new Operation(number, nome, initialDeposit);
                o.Show();
            }
            else if (question == "n")
            {
                o = new Operation(number, nome);
                o.Show();
            }

            Console.Write("Entre um valor para depósito: ");
            double deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            o.Sum(deposit);
            o.Show();

            Console.Write("Entre um valor para saque: ");
            double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            o.Remove(withdraw);
            o.Show();
        }

    }
}
