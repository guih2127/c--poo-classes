using System;
using System.Collections.Generic;

namespace Course
{
	class Program
	{
		static void Main(string[] args)
		{
			HashSet<int> A = new HashSet<int>(); // Criação de um novo conjunto vazio.
			HashSet<int> B = new HashSet<int>();

			A.Add(5);
			A.Add(8);
			A.Add(9);
			A.Add(3);

			B.Add(3);
			B.Add(4);
			B.Add(5);

			// Não podemos imprimir os elementos de um conjunto utilizando um FOR comum, porque os
			// elementos de um conjunto não possuem posicões. Então utilizamos o foreach.

			B.Add(4); // Conjunto não aceita elementos repetidos, então essa instrução não irá funcionar.

			foreach(int num in A)
			{
				Console.WriteLine(num);
			}

			foreach(int num in B)
			{
				Console.WriteLine(num);
			}

			B.Remove(3); // Remove um elemento do conjunto.

			A.ExceptWith(B); // Faz a diferença entre o conjunto A menos o conjunto B.
			// Ou seja, os elementos de A que não estão em B aparecerão.

			A.UnionWith(B); // Une o A com o B, ou seja, os elementos de B que não estão em A serão adicionados no A.

			A.IntersectWith(B); // Mostra os elementos comuns aos dois conjuntos.

			Console.WriteLine("Digite um valor: ");
			int n = int.Parse(Console.ReadLine());

			if (A.Contains(n)) // Testa se um elemento está no conjunto.
			{
				Console.WriteLine("Este valor esta na lista A");
			}
			else
			{
				Console.WriteLine("Este valor não esta na lista A");
			}
		}
	}
}