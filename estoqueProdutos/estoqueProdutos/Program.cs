using System;
using System.Globalization;

namespace estoqueProdutos {
    class Program {
        static void Main(string[] args) {

            /*
            Console.WriteLine("Entre com nome do Produto:");
            Console.Write("Nome: ");
            string Nome = Console.ReadLine();
            Console.Write("Preço: ");
            double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(Nome, Preco);
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a serem adicionados: ");
            int qte = int.Parse(Console.ReadLine());
            p.AddProduto(qte);
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("Digite o numero de produtos a serem removidos: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoveProduto(qte);
            Console.WriteLine("Dados do produto: " + p);
            */

            Produto p = new Produto("TV", 500.00, 10);
            Console.WriteLine(p.Nome);
            Console.WriteLine(p);

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p);

        }
    }
}
