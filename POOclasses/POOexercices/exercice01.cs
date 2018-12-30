/*
Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver
este problema. 
*/

using System;

namespace Exercice01
{
    class Aluno
    {
        public string nome;
        public double nota1 = 0, nota2 = 0, nota3 = 0;

        public double notaFinal()
        {
            double notaFinal = nota1 + nota2 + nota3;
            return notaFinal;
        }
        
        public bool passou()
        {
            double notaFinal = nota1 + nota2 + nota3;

            if (this.notaFinal() < 60)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1;
            aluno1 = new Aluno();

            Console.WriteLine("Informe o seu nome:");
            aluno1.nome = Console.ReadLine();

            Console.WriteLine("Informe sua nota do primeiro semestre:");
            aluno1.nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua nota do primeiro semestre:");
            aluno1.nota2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe sua nota do primeiro semestre:");
            aluno1.nota3 = double.Parse(Console.ReadLine());

            if (aluno1.passou() == true)
            {
                Console.WriteLine("Você passou!");
            }
            else
            {
                Console.WriteLine("Você não passou!");
            }

            double notaFinal = aluno1.notaFinal();
            Console.WriteLine("Sua nota final foi {0}.", notaFinal);
        }
    }
}