using System;
using System.Globalization;

namespace Course
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {

        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 0; // Essa linha é dispensável, automaticamente, a quantidade seria 0
            // de qualquer forma.
        }
        // Utilizamos o conceito de SOBRECARGA para o nosso construtor. Sobrecarga consiste em
        // permitir, dentro de uma mesma classe, mais de um metódo com o mesmo nome, porém, ambos
        // devem possuir argumentos diferentes para funcionar.
        // No nosso caso, queremos um modo de permitir que o usuário digite apenas o nome e o preço
        // do produto, e inicializá-lo automaticamente com a quantidade 0.

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }
        // Definição do CONSTRUTOR da nossa classe. Definimos que para criar uma instância
        // da classe Produto, precisamos passar estes três parâmetros.
        // Com a palavra THIS, que faz referência ao próprio objeto, conseguimos reaproveitar construtores.
        // Inves de colocarmos as variáveis dentro do construtor de três argumentos, aproveitamos as variáveis
        // já definidas no construtor que leva dois argumentos, utilizando a palavra this e passando os parâmetros.

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return _preco;
        }

        public double GetQuantidade()
        {
            return _quantidade;
        }

        public double ValorTotalEstoque()
        {
            return (_quantidade * _preco);
        }

        public void AdicionarProdutos(int qte)
        {
            _quantidade += qte;
        }

        public void RemoverProdutos(int qte)
        {
            _quantidade -= qte;
        }
        
        public override string ToString()
        {
            return _nome + 
            ", $" + 
            _preco + 
            ", " + 
            _quantidade + 
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

            /*             
            Produto p3 = new Produto
            {
                Nome = "Nuggets",
                Preco = 30.00,
                Quantidade = 20,
            }; */
            // Sintaxe alternativa para instanciar uma classe. Podemos instanciá-la
            // assim se a classe não tiver nenhum construtor definido (ou seja, apenas o padrão). Porém,
            // se tivermos um construtor definido, precisaremos de criar um que leve 0 argumentos para poder
            // utilizar essa sintaxe.

            Console.WriteLine("Dados do produto: {0}, {1}, {2}", p.GetNome(), p.GetPreco(), p.GetQuantidade());

            p.SetNome("TV 4K"); // Alterando o nome da instância da classe, com o metódo SetNome()

            p.AdicionarProdutos(5);
            Console.WriteLine(p.GetNome());

            p.RemoverProdutos(5);
            Console.WriteLine(p.GetNome());

            // Como nossa quantidade está como public, um usuário pode tranquilamente
            // digitar p.Quantidade = -10 e isso irá funcionar. Para impedir isso, utilizamos
            // o conceito de ENCAPSULAMENTO, que consiste em não expôr os dados internos
            // para o usuário. Para efetuar o processo de encapsulamento, os atributos desejados
            // devem ser definidos como PRIVATE. Para acessar os modificadores é necessário
            // utilizar SET e GET.

            // Portanto, como não é mais possível acessar os atributos da instância diretamente,
            // criamos um metódo que retorna o nome, o GetNome() e outro metódo para definir e mudar o 
            // nome, SetNome(). Temos várias vantagens utilizando metódos para definir e modificar valores,
            // por exemplo, podemos incluir uma lógica no metódo, como fizemos em SetNome().
            // Supondo que não queremos que o preço possa ser modificados, é só definir apenas um metódo GET
            // e não definir um SET, assim começamos a ter mais controle da nossa classe.
        }
    }
}