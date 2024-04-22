using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace C_sharp_constructors_this_overloading_encapsulation
{
    public class Operation
    {
        public int _number { get; private set; }
        public string Name;
        public double _initialDeposit { get; private set; }
        private double _deposit;
        private double _withdraw;

        public Operation()
        {

        }

        public Operation(int number, string nome)
        {
            _number = number;
            Name = nome;
            _initialDeposit = 0.0;
        }

        public Operation(int number, string nome, double initialDeposit) : this(number, nome)
        {
            _initialDeposit = initialDeposit;
        }

        public void Show()
        {
            Console.WriteLine("Dados da conta:");
            Console.WriteLine($"Conta {_number}, Titular: {Name}, Saldo: R$ {_initialDeposit.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public double Sum(double deposit)
        {
            return _initialDeposit += deposit;
        }

        public double Remove(double deposit)
        {
            return _initialDeposit = _initialDeposit -5.00 - deposit;
        }
    }
}
