// ENUMERAÇÕES
// Serve para especificar de forma literal um conjunto de constantes relacionadas.
// Enum: É do tipo valor.
// Tem melhor semântica, código mais legível e auxiliado pelo compilador.
using System;

namespace Course
{
	class Program
	{
		static void Main(string[] args)
		{
			Order order = new Order
			{
				Id = 1080,
				Moment = DateTime.Now,
				Status = OrderStatus.PendingPayment,
			};

			Console.WriteLine(order);

			string txt = OrderStatus.PendingPayment.ToString(); // Conversao de um enum para um string.
			OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // Conversao de um string para um enum.
		}	
	}

	class Order
	{
		public int Id { get; set;}
		public DateTime Moment { get; set; }
		public OrderStatus Status { get; set; } // Utilizamos a nossa enum para criar uma propriedade em nossa entidade.

		public override string ToString()
		{
			return $"{Id}, {Moment}, {Status}";
		}
	}

	enum OrderStatus : int // Criação da nossa enum.
	{
		PendingPayment = 0,
		Processing = 1,
		Shipped = 2,
		Delivered = 3,
	}
}