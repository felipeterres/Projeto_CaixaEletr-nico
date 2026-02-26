// Sistema de Caixa Eletrônico Simples //
using System;
namespace CaixaEletrônico;
public class Program
{
    public static void Main()
    {
        while (true)
        {

            const string login = "felipe";
        const int senha = 1234;

        string enteredLogin = "";
        int enteredPassword = 0;

        Console.WriteLine("\n____________________________________\n===Caixa Eletrônico Banco Terres===");

       

        while (enteredLogin != login || enteredPassword != senha)
        {
            
            Console.WriteLine("\nDigite seu login:");
            enteredLogin = Console.ReadLine();
            Console.WriteLine("\nDigite sua senha:");
            enteredPassword = int.Parse(Console.ReadLine());
            if (enteredLogin != login || enteredPassword != senha)
            {
                Console.WriteLine("\nLogin ou senha incorreto.Digite novamente!");
            }
        }
        Console.WriteLine("\nLogin realizado com sucesso!");
        double saldo = 1000;
        int menu = 0;

        while (menu != 4)
        {
            Console.WriteLine("____________________________________\n\nMenu de opções");
            Console.WriteLine("\n1.Ver saldo");
            Console.WriteLine("2.Depositar");
            Console.WriteLine("3.Sacar");
            Console.WriteLine("4.Sair");
            Console.WriteLine("\nDigite a opção desejada:");
            menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine($"\nSeu saldo é: R$ {saldo}");
                    break;

                case 2:
                    Console.WriteLine("\nDigite o valor do depósito:");
                    double deposito = Convert.ToDouble(Console.ReadLine());
                    saldo += deposito;
                    Console.WriteLine("\nDepósito realizado!");
                    break;

                case 3:
                    Console.WriteLine("\nDigite o valor do saque:");
                    double saque = Convert.ToDouble(Console.ReadLine());
                    if(saque <= saldo)
                    {
                        saldo -= saque;
                        Console.WriteLine("\nSaque realizado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("\nValor insuficiente!");
                    }
                    break;
                case 4:
                    Console.WriteLine("\nSaindo......");
                    break;

                default:
                    Console.WriteLine("\nOpção Inválida! Tente novamente");
                    break;

                
            }
        }
        Console.WriteLine("Até a próxima!");
        }

    }
}