using System;
using System.Globalization;

namespace Recap
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 10.35784;
            int idade = 32;
            string nome = "Maria";

            // SAÍDA DE DADOS
            // formatação de decimais
            Console.WriteLine(saldo.ToString("F1", CultureInfo.InvariantCulture));

            // placeholders
            Console.WriteLine("{0} tem {1} anos e saldo de {2:F} reais.", nome, idade, saldo);

            // interpolação
            Console.WriteLine($"{nome} tem {idade} anos e saldo de {saldo:F2} reais.");

            // ENTRADA DE DADOS
            // split
            string[] s = Console.ReadLine().Split(' ');
            Console.WriteLine($"{s[0]}, {s[1]}, {s[2]}");

        }
    }
}
