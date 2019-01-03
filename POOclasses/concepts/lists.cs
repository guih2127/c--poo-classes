// Listas são compostas por dados do mesmo tipo e são ordenadas.
// Porém, diferente de matrizes e vetores, os elementos são alocados sob demanda,
// e não definidos inicialmente. A lista começa vazia e os elementos são adicionados gradualmente.
// Classe: List, Namespace: System.Collections.Generic.

using System;
using System.Collections.Generic;

namespace Course
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> list = new List<string>(); // Declaração de uma lista e instanciação da mesma.
			List<string> list2 = new List<string> { "Maria", "Alex" };

			// Vantagens da lista: Tamanho variável. Começa vazia e vamos adicionando valores. 
			// Também é bem facil inserir e remover elementos.
			// Ou seja, os pontos fracos do vetor são os pontos fortes da lista.
			// A principal desvantagem é o acesso sequencial de elementos. Ou seja, o acesso é bem mais lento que
			// o acesso direto dos vetores.

			list.Add("João"); // Adiciona no final da lista.
			list.Insert(0, "Maria"); // Adiciona em uma posição específica.
			list.Add("Monstro");

			Console.WriteLine(list.Count); // Contagem da lista.

			string s1 = list.Find(Test); // Find recebe uma função e nos dará o primeiro item que seja == True.
			Console.WriteLine($"First M: {s1}");

			string s2 = list.Find(x => x[0] == 'M'); // Podemos utilizar o find também com expressões Lambda.
			Console.WriteLine(s2);

			string s3 = list.FindLast(x => x[0] == 'M'); // FindLast encontra o último resultado que condiz com a expressão.
			Console.WriteLine(s3);

			int pos1 = list.FindIndex(x => x[0] == 'M'); // Dessa forma, achamos o primeiro índice do resultado que condiz com a expressão.
			Console.WriteLine(pos1);

			int pos2 = list.FindLastIndex(x => x[0] == 'M'); // Dessa forma, achamos o último índice do resultado que condiz com a expressão.
			Console.WriteLine(pos2);

			List<string> list3 = list.FindAll(x => x[0] == 'M'); // Filtramos a lista, criando uma nova lista em que todos os elementos comecem com M.
			foreach (string nome in list3)
			{
				Console.WriteLine("Lista Filtrada - M:" + nome);
			}

			foreach (string nome in list)
			{
				Console.WriteLine(nome);
			}

			list.Remove("João"); // Remove um certo elemento da lista.
			list.RemoveAll(x => x[0] == 'M'); // Remove todos os elementos que condizem com a expressão.
			list3.RemoveAt(2); // Remove o elemento que esteja em uma certa posição.
			list3.RemoveRange(0, 2); // Remove uma contagem de elementos a partir de uma posição
		}

		static bool Test(string s)
		{
			return s[0] == 'M';
		}

	}
}