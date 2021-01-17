using System;
using System.Globalization;
namespace ProdutoEstorque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto P = new Produto();
            
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            P.Nome = Console.ReadLine();
            Console.Write("preço: ");
            P.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            P.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();       
            Console.Write("Dados dos Produtos : " + P);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            P.AdicionarProduto(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + P);
            
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser remover Estoque: ");
            qtd = int.Parse(Console.ReadLine());
            P.RemoverProduto(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + P);

        }
    }
}
