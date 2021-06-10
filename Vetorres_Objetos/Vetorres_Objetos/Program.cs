using System;

namespace Vetorres_Objetos {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i < vect.Length; i++) {
                string nome = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Produto { Nome = nome, Preco = price};
            }

            double soma = 0;

            for (int i = 0; i < vect.Length; i++) {
                soma += vect[i].Preco;
            }
            soma = soma / vect.Length;

            Console.WriteLine($"media = {soma.ToString("F2")}");

        }
    }
}
