using System;
using System.Collections.Generic;

namespace Exercice
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Informe o numero de funcionarios a serem adicionados: ");
			int n = Convert.ToInt32(Console.ReadLine());
			List<Funcionario> funcionarios = new List<Funcionario>();

			for (int i = 0; i < n; i++)
			{
				Console.WriteLine($"Informe os dados do funcionário {i}");

				Console.Write("Digite o ID do funcionário: ");
				int id = Convert.ToInt32(Console.ReadLine());

				Console.Write("Digite o nome do funcionário: ");
				string nome = Console.ReadLine();

				Console.Write("Digite o salário do Funcionário: ");
				double salario = double.Parse(Console.ReadLine());

				Funcionario f = new Funcionario(id, nome, salario);
				funcionarios.Add(f);
			}

			foreach (Funcionario funcionario in funcionarios)
			{
				Console.WriteLine(funcionario);
			}

			Console.Write("Informe o ID do funcionário que você deseja aumentar o salário: ");
			int n2 = Convert.ToInt32(Console.ReadLine());

			Funcionario fun = funcionarios.Find(funcionario => funcionario.Id == n2);

			if (fun != null)
			{
				Console.Write("Informe o valor em que deseja aumentar: ");
				double valor = double.Parse(Console.ReadLine());
				fun.AumentarSalario(valor);				
			}
			else
			{
				Console.WriteLine("ID inexistente.");
			}


			foreach (Funcionario funcionario in funcionarios)
			{
				Console.WriteLine(funcionario);
			}
		}
	}

	class Funcionario
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public double Salario { get; private set; }

		public Funcionario (int id, string nome, double salario)
		{
			Id = id;
			Nome = nome;
			Salario = salario;
		}

		public void AumentarSalario (double valor)
		{
			Salario = Salario + valor;
		}

		public override String ToString()
		{
			return $"Nome: {Nome}, Id: {Id}, Salario: {Salario}";
		}
	}
}