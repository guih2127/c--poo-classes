using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExercice01
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c;

            Console.WriteLine("Vamos criar a sua conta! Deseja fazer um depósito inicial? Digite 1 se Sim ou outro número se não.");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                Console.Write("Informe o número da conta: ");
                int numero = int.Parse(Console.ReadLine());

                Console.Write("Informe seu nome: ");
                string nome = Console.ReadLine();

                Console.Write("Agora, informe o valor do depósito inicial: ");
                double valor = double.Parse(Console.ReadLine());

                c = new Conta(valor, numero, nome);
            }

            else
            {
                Console.Write("Informe o número da conta: ");
                int numero = int.Parse(Console.ReadLine());

                Console.Write("Informe seu nome: ");
                string nome = Console.ReadLine();

                c = new Conta(numero, nome);
            }

            Console.WriteLine(c);

            Console.Write("Agora, vamos fazer um depósito, digite o valor: ");
            double valorDep = double.Parse(Console.ReadLine());
            c.Deposito(valorDep);
            Console.WriteLine(c);

            Console.Write("Agora, vamos fazer um saque, digite o valor: ");
            double valorSaq = double.Parse(Console.ReadLine());
            c.Saque(valorSaq);
            Console.WriteLine(c);
        }
    }
}
