using System;
using System.Globalization;

namespace Course
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        // Definição do CONSTRUTOR da nossa classe. Definimos que para criar uma instância
        // da classe Produto, precisamos passar estes três parâmetros.

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0; // Essa linha é dispensável, automaticamente, a quantidade seria 0
            // de qualquer forma.
        }
        // Utilizamos o conceito de SOBRECARGA para o nosso construtor. Sobrecarga consiste em
        // permitir, dentro de uma mesma classe, mais de um metódo com o mesmo nome, porém, ambos
        // devem possuir argumentos diferentes para funcionar.
        // No nosso caso, queremos um modo de permitir que o usuário digite apenas o nome e o preço
        // do produto, e inicializá-lo automaticamente com a quantidade 0.

        public double ValorTotalEstoque()
        {
            return (Quantidade * Preco);
        }

        public void AdicionarProdutos(int qte)
        {
            Quantidade += qte;
        }

        public void RemoverProdutos(int qte)
        {
            Quantidade -= qte;
        }
        
        public override string ToString()
        {
            return Nome + 
            ", $" + 
            Preco + 
            ", " + 
            Quantidade + 
            " unidades, Total: $" + 
            ValorTotalEstoque();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco);
            // Quando executamos esse comando, instanciamos um valor p com os atributos
            // vazios, ou seja, nome é null e o preço e a quantidade são zero.
            // Isso não faz sentido. Devemos fazer com que a inserção destes valores
            // seja obrigatória, para que não haja produtos sem nome e sem preço. Para isso,
            // utilizamos um CONSTRUTOR.

            // Portanto, agora, para criarmos a instância, precisamos passar os argumentos necessários.

            // Com a sobrecarga que fizemos na classe, utilizando 2 construtores, podemos agora
            // instanciar a classe informando apenas nome e preço.

            Console.WriteLine("Dados do produto: {0}", p);

            p.AdicionarProdutos(5);
            Console.WriteLine(p);

            p.RemoverProdutos(5);
            Console.WriteLine(p);
        }
    }
}