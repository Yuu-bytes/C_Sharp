using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();
            conta.Numero = 1;
            conta.Agencia = 2;
            conta.Correntista = 3;
            Console.WriteLine(conta.Saldo);
            conta.Depositar(200);
            conta.Sacar(50);
            Console.WriteLine(conta.Saldo);
        }
    }
}
