using System;

namespace Course
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] vect = new string[] { "Maria", "Alex", "Bob"};

			foreach (string nome in vect)
			{
				Console.WriteLine(nome); // Sintaxe simplificada de um loop, utilizando o foreach.
			}
		}
	}
}