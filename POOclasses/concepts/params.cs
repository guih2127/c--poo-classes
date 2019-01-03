using System;
using System.Globalization;

namespace Course
{
	class Calculator
	{
		public static int Sum(params int[] numbers) // Utilizamos o Params, que aceita um numero variável de parametros.
		{
			int sum = 0;
			for (int i = 0; i < numbers.Length; i++)
			{
				sum += numbers[i];
			}
			return sum;
		}

		public static void Triple(ref int x) // Utilizamos o Ref, que permite que a gente modifique diretamente a variável.
		// A partir de uma função, pois estamos fazendo com que o parametro se torne uma referencia para a variavel original.
		{
			x = x * 3;
		}
		public static void Triple2(int origin, out int result) // Com o out, iremos guardar o resultado em um outro parametro de saída.
		{
			result = origin * 3;
		}
	}

	class Program 
	{
		static void Main(string[] args)
		{
			int s1 = Calculator.Sum(2, 3, 4, 5);
			Console.WriteLine(s1);

			int a = 10; // Devemos iniciar a variável, quando utilizamos o Ref.
			Calculator.Triple(ref a); // Quando utilizamos o Ref, precisamos chamar a função com o Ref também.
			Console.WriteLine(a);

			int b = 10;
			int triple; // Quando vamos passar uma variavel para o parametro Out, a variavel nao precisa ser inicializada.

			Calculator.Triple2(b, out triple); // Dessa forma, a variável out result, definida como parametro, será uma referncia para triple.
			Console.WriteLine(triple);
		} 
	}
}