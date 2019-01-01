using System;
using System.Globalization;

namespace Course
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

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
        
        // O metódo ToString é chamado quando chamamos o objeto com Console.WriteLine,
        // aqui, sobrescrevemos o metódo ToString padrão da classe Object.
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
            Produto p = new Produto();

            Console.Write("Digite o nome do produto: ");
            p.Nome = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            p.Preco = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de estoque do produto: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: {0}", p);

            p.AdicionarProdutos(5);
            Console.WriteLine(p);

            p.RemoverProdutos(5);
            Console.WriteLine(p);
        }
    }
}