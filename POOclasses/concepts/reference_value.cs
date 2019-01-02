using System;
using System.Globalization;

namespace Course
{
    struct Point
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);
            // não é necessário fazer New Point.. etc, structs são tipo value. (Tipos referencia NECESSITAM utilizar o new)

            p = new Point(); // Ainda assim, podemos utilizar o new para criar um novo struct.
            Console.WriteLine(p);

            double? x = null; // Declaração de valor nullable, possui os metodos GetValueOrDefault, HasValue e Value.
            // NULLABLE: Recurso do C# para que dados do tipo valor (structs) possam receber o value null. Tem seu uso comum em campos de banco que podem
            // ser nulos ou dados e parâmetros que sejam opcionais.

            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault()); // Pega o valor e, se não exisir, pega o valor padrão da variável (padrão de double = 0)
            Console.WriteLine(y.GetValueOrDefault()); // Aqui, no caso, ele pega o valor (10)

            Console.WriteLine(x.HasValue); // Retorna False, pois não tem valor.
            Console.WriteLine(y.HasValue); // Retorna True, pois tem valor.


            if (x.HasValue)
            {
                Console.WriteLine(x.Value); // Lança uma excessão, pois o valor é Null
            }
            else
            {
                Console.WriteLine("X is null.");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value); // Obtém o valor, que é 10.
            }
            else
            {
                Console.WriteLine("Y is null.");
            }

            // OPERADOR DE COALESCENCIA NULA: Atribui o valor de uma variável a outra, porém se a variável for nula, atribui um outro valor definido.
            y = x ?? 5.0; // No caso, passa o valor 5
            Console.WriteLine(y);
        }
    }
}

// Tipos REFERENCIA e tipos VALOR: Classes, arrays e strings são considerados tipo referencia, e outros tipos como int, double etc,
// são considerados tipo valor, por serem structs. Podemos também criar nosssas próprias structs.
// Tipos valor são armazenados em uma caixa e, ao copiarmos uma variável para outra, passamos uma cópia daquele valor.
// Ou seja, os tipos valor não se relacionam, e quando alteramos a cópia, não alteraremos o outro valor.
// Os tipos referencia por sua vez, não armazenam um valor diretamente, eles fazem referencia para a instancia
// da classe, ou seja, essas variaveis APONTAM para uma instancia da classe definida. Portanto, ao atribuirmos
// para uma variavel uma instancia de uma variavel ja definida, qualquer alteração feita em uma delas, será feita em ambas,
// pois ambas fazem referencia para a mesma instancia.
// Obs: Tipos referencia aceitam o valor NULL, tipos valor não.
// VALORES PADRÃO: Valores padrão criados com o New. Numeros - 0, bool - False, char: cod. 0, objeto: Null. 

// GARBAGE COLLECTOR e Desalocação por ESCOPO LOCAL
// É importante saber que os tipo de memória primitivos (int, double) são armazenados no STACK, e tipos de memória mais
// complexos, como objetos, no HEAP. É importante saber que para cada objeto no heap, temos um PONTEIRO no stack que faz 
// referencia à essa instancia.
// O Garbage Collector monitora os objetos alocados dinamicamente pelo programa (no heap) e desaloca os que não são mais utilizados (perdem referencia).
// A desalocação por escopo local acontece na entrada e na saida de um escopo, onde variáveis são alocadas e desalocadas.