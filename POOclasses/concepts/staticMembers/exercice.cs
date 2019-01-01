using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dólar?");
            double cotacaoDolar = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você vai comprar?");
            double quantia = double.Parse(Console.ReadLine());

            double valor = ConversaoDeMoeda.Calculo(cotacaoDolar, quantia);
            Console.WriteLine($"Valor a ser pago em reais = {valor:F2}");
        }

        class ConversaoDeMoeda
        {   
            static public double Calculo(double cotacao, double quantia)
            {
                double total = quantia * cotacao;
                return (total + (quantia * 0.06));
            }
        }
    }
}