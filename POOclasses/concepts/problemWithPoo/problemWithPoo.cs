using System;

namespace Course
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        // criação de um metódo para a classe Triangulo, que calcula a Area.
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt((p) * (p - A) * (p - B) * (p - C));
        }
    }

    class Program 
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            // quando criamos classes, podemos instanciá-las quando quisermos
            // atribuindo as instâncias de uma classe à uma variável.

            Console.WriteLine("Informe as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine($"Área de x = {areaX:F4}");
            Console.WriteLine($"Área de y = {areaY:F4}");

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}
