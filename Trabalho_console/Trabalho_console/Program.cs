using System;
using Trabalho_console;

string opcao;
do
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("0) Sair");
    Console.WriteLine("1) Somar números");
    Console.WriteLine("2) Converter de metros para milímetros");
    Console.WriteLine("3) Calcular Fatoriais de 1 até 10");

    opcao = Console.ReadLine();

    try
    {
        if (opcao == "1")
        {
            Console.WriteLine("\nDigite o primeiro número:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo número:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nO resultado da soma é: {SomaN.Somar(num1, num2)}\n");
        }
        else if (opcao == "2")
        {
            Converter conversor = new Converter();
            Console.WriteLine("\nDigite o valor em metros:");
            double metros = Convert.ToDouble(Console.ReadLine());
            double resultadoConversao = conversor.ConverterParaMilimetros(metros);
            Console.WriteLine($"\nO valor em milímetros é: {resultadoConversao}\n");
        }
        else if (opcao == "3")
        {
            Console.WriteLine("\nCalculando fatoriais de 1 até 10:\n");
            Fatorial.Calcular();
        }
        else if (opcao != "0")
        {
            Console.WriteLine("\nOpção inválida. Por favor, escolha uma opção válida.\n");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("\nEntrada inválida. Por favor, insira um número inteiro válido.\n");
    }
} while (opcao != "0");