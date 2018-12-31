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
        // Definição do construtor da nossa classe. Definimos que para criar uma instância
        // da classe Produto, precisamos passar estes três parâmetros.

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

            Console.Write("Digite a quantidade de estoque do produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);
            // Quando executamos esse comando, instanciamos um valor p com os atributos
            // vazios, ou seja, nome é null e o preço e a quantidade são zero.
            // Isso não faz sentido. Devemos fazer com que a inserção destes valores
            // seja obrigatória, para que não haja produtos sem nome e sem preço. Para isso,
            // utilizamos um CONSTRUTOR.

            // Portanto, agora, para criarmos a instância, precisamos passar os argumentos necessários.

            Console.WriteLine("Dados do produto: {0}", p);

            p.AdicionarProdutos(5);
            Console.WriteLine(p);

            p.RemoverProdutos(5);
            Console.WriteLine(p);
        }
    }
}