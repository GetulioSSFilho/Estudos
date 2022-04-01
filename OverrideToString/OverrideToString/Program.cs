using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;
            Console.WriteLine("Depósito Inicial:");
            conta = new Conta(27012, "Getulio Sergio", 9500.00);
            Console.WriteLine(conta.ToString());

            Console.WriteLine("Saldo Inicial + Depósito de R$5200:");
            conta.Deposito(5200);
            Console.WriteLine(conta.ToString());

            Console.WriteLine("Saldo Anterior - Saque de R$700:");
            conta.Saque(700);
            Console.WriteLine(conta.ToString());
        }
    }
}
