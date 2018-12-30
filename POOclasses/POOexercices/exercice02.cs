using System;

namespace Exercice02
{
    class Funcionario
    {
        public string nome;
        public double salario;
        public double imposto;

        public override string ToString()
        {
            return $"{nome}, $ {SalarioLiquido()}";
        } 

        public double SalarioLiquido()
        {
            return (salario - imposto);
        }

        public void AumentarSalario(double porcentagem)
        {
            salario = salario + (salario * (porcentagem / 100));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();

            funcionario1.nome = Console.ReadLine();
            funcionario1.salario = double.Parse(Console.ReadLine());
            funcionario1.imposto = double.Parse(Console.ReadLine());

            Console.Write("Digite a porcentagem para aumentar o salário:");
            double porcentagem = double.Parse(Console.ReadLine());

            funcionario1.AumentarSalario(porcentagem);
            Console.Write(funcionario1);
        }
    }
}