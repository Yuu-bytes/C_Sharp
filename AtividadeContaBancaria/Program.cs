using System;
using System.Collections.Generic;

namespace Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            List<Conta> listaContas = new List<Conta>();
            while (true) // MENU
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1    - Criar Conta");
                Console.WriteLine("2    - Listar Contas");
                Console.WriteLine("5    - Depositar");
                Console.WriteLine("6    - Sacar");
                Console.WriteLine("9    - Fechar");
                string opcaoMenu = Console.ReadLine();
                switch (opcaoMenu)
                {
                    case "1": // Cirar uma Conta
                        num++;
                        Console.WriteLine("Que tipo de Conta?");
                        Console.WriteLine("1    - Conta Corrente");
                        Console.WriteLine("2    - Conta de Investimento");
                        string opcao = Console.ReadLine();
                        if (opcao.Equals("1")) // Conta Corrente
                        {
                            ContaCorrente contaCorrente = new ContaCorrente();
                            contaCorrente.DonoDaConta = new Correntista();
                            contaCorrente.tipo = "corrente";
                            Console.WriteLine("Seu número de cliente é " + num);
                            contaCorrente.Numero = num;
                            Console.WriteLine("Qual o nome do cliente?");
                            contaCorrente.DonoDaConta.Nome = Console.ReadLine();
                            Console.WriteLine("Qual o limite do Saldo?");
                            contaCorrente.SaldoLimite = Convert.ToDouble(Console.ReadLine());
                            listaContas.Add(contaCorrente);
                            Console.WriteLine("Conta criada com sucesso");
                        }
                        else if (opcao.Equals("2")) // Conta Investimento
                        {
                            ContaInvestimento contaInvestimento = new ContaInvestimento();
                            contaInvestimento.DonoDaConta = new Correntista();
                            contaInvestimento.tipo = "investimento";
                            Console.WriteLine("Seu número de cliente é " + num);
                            contaInvestimento.Numero = num;
                            Console.WriteLine("Qual o nome do cliente?");
                            contaInvestimento.DonoDaConta.Nome = Console.ReadLine();
                            Console.WriteLine("Qual o limite do Saldo?");
                            contaInvestimento.SaldoLimite = Convert.ToDouble(Console.ReadLine());
                            listaContas.Add(contaInvestimento);
                            Console.WriteLine("Conta criada com sucesso");
                        }
                        break;
                    case "2": // Listar as contas
                        Console.Clear();
                        foreach (Conta conta in listaContas)
                        {
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("Número da conta: " + conta.Numero);
                            Console.WriteLine("Nome da conta: " + conta.DonoDaConta.Nome);
                            Console.WriteLine("Tipo da conta: " + conta.tipo);
                            Console.WriteLine("Saldo da conta: " + conta.Saldo);
                            Console.WriteLine("Saldo limite: " + conta.SaldoLimite);
                        }
                        break;
                    case "5": // Depositar em uma conta
                        Console.Clear();
                        Console.WriteLine("Qual o número do cliente?");
                        int numCliente = int.Parse(Console.ReadLine());
                        foreach (Conta s in listaContas)
                        {
                            if (numCliente.Equals(s.Numero))
                            {
                                Console.WriteLine("Localizamos a conta no nome de: " + s.DonoDaConta.Nome + " do tipo " + s.tipo);
                                Console.WriteLine("Quanto deseja depositar? ");
                                if (s.tipo.Equals("corrente"))
                                { // Depositar em conta corrente
                                    s.Saldo = Double.Parse(Console.ReadLine());
                                }
                                else
                                { // Depositar em conta investimento
                                    s.Saldo += Double.Parse(Console.ReadLine()) * 1.10;
                                }
                                Console.WriteLine("Depósito realizado com sucesso!");
                                goto end;
                            }
                        }
                        Console.WriteLine("[ERRO] Não foi possível localizar a conta.");
                    end:
                        break;
                    case "6": // Sacar de uma conta
                        Console.Clear();
                        Console.WriteLine("Qual o número do cliente?");
                        int numC = int.Parse(Console.ReadLine());
                        foreach (Conta s in listaContas)
                        {
                            if (numC.Equals(s.Numero))
                            {
                                Console.WriteLine("Localizamos a conta no nome de: " + s.DonoDaConta.Nome + " do tipo " + s.tipo);
                                Console.WriteLine("Quanto deseja sacar? ");
                                double sacar = Double.Parse(Console.ReadLine());
                                if (sacar > s.Saldo)
                                {
                                    Console.WriteLine("[ERRO] Saldo Insuficiente");
                                    goto ENDOFLOOPS;
                                }
                                else if (s.SaldoLimite >= sacar)
                                {
                                    s.Saldo -= sacar;
                                    Console.WriteLine("Saldo retirado com sucesso");
                                    goto ENDOFLOOPS;
                                }
                                else
                                {
                                    Console.WriteLine("Limite de saldo insuficiente");
                                    goto ENDOFLOOPS;
                                }
                            }
                        }
                        Console.WriteLine("[ERRO] Não foi possível localizar a conta.");
                    ENDOFLOOPS:
                        break;
                    case "9":
                        Environment.Exit(0); // Sair do programa
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
