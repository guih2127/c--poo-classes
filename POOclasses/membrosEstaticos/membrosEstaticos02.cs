using System;

namespace Course
{
    class Calculadora
    // Resolvemos o mesmo exercício anterior, porém utilizando uma
    // instância da classe Calculadora, na função Main.
    {
        public static double pi = 3.14;

        public static double Circunferencia(double r)
        {
            return 2.0 * pi * r;
        }

        public static double Volume(double r)
        {
            return 4.0/3.0 * pi * Math.Pow(r, 3.0);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);
            Console.WriteLine($"Circunferência: {circ:F2}");
            Console.WriteLine($"Volume: {volume:F2}");
            Console.WriteLine($"{Calculadora.pi}");
        }
    }
}

// No caso dos triângulos, ou do exercício de alunos e funcionários, cada um deles
// possui suas características. Porém a calculadora possui características que não mudam, ou seja,
// Se criassemos calc1 e calc2, instânciando Calculadora, não haveria nenhuma diferença entre elas.

// O pi é um valor estático, ele não muda. Se chamarmos a Circunferência de 3.0 em qualquer uma das
// instâncias, ela também sempre será a mesma.

// Então, chegamos a conclusão que, ao definir todos os membros da classe como estáticos, tornamos
// ela uma classe estática. Por causa disso, não precisamos instanciá-la para chamar seus metódos,
// então trocamos todos os calc por Calculadora, diretamente, fazendo o código ter muito mais sentido.