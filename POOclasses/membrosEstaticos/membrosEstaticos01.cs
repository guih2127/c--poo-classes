using System;
using System.Globalization;

namespace Course
{
    class Program 
    {
        static double pi = 3.14;

        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Circunferencia(raio);
            double volume = Volume(raio);
            Console.WriteLine($"Circunferência: {circ:F2}");
            Console.WriteLine($"Volume: {volume:F2}");
            Console.WriteLine($"{pi}");
        }

        // para chamar uma função dentro de uma função estática, essa outra função
        // também deve ser estática. para utilizar qualquer membro dentro de uma classe
        // estática, ele deve ser estático.
        // a diferença entre uma classe estática e uma não estática é apenas que
        // uma CLASSE ESTÁTICA NÃO PODE SER INSTANCIADA.
        // chamamos os metódos da classe estática utilizando o nome da classe.

        static double Circunferencia(double r)
        {
            return 2.0 * pi * r;
        }

        static double Volume(double r)
        {
            return 4.0/3.0 * pi * Math.Pow(r, 3.0);
        }
    }
}