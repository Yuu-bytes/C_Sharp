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
            conta.CorrentistaConta = new Correntista(1, "Michael");
            Console.WriteLine(conta.Saldo);
            conta.Depositar(200);
            conta.Sacar(50);

            ContaBancaria conta2 = new ContaBancaria();
            conta2.CorrentistaConta = new Correntista(2, "João");
            conta2.Numero = 222;
            conta2.Depositar(1222);
            Console.WriteLine(conta.VerSaldo());
            Console.WriteLine(conta2.VerSaldo());

            ContaInvestimento contaInvestimento = new ContaInvestimento();
            contaInvestimento.Numero = 3;
            contaInvestimento.CorrentistaConta = new Correntista(3, "Marcos");
            contaInvestimento.Depositar(100);

            Console.WriteLine(contaInvestimento.VerSaldo());
        }
    }
}
