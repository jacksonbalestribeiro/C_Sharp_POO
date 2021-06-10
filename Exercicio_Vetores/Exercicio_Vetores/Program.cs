using System;

namespace Exercicio_Vetores {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Quantos quartos ser alugados?");
            int n = int.Parse(Console.ReadLine());
            int quarto;
            string email;
            string nome;
            
            Alugueis[] vet = new Alugueis[9];
            for (int i = 0; i< vet.Length; i++) {
                vet[i] = new Alugueis(i);
            }

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"rent #{i+1}");
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Quarto: ");
                quarto = int.Parse(Console.ReadLine());
                vet[quarto].Nome = nome;
                vet[quarto].Email = email;
            }

            Console.WriteLine("Quartos ocupados:");

            
            for (int i = 0; i < vet.Length; i++) {

                if (!vet[i].Nome.Equals("vazio")) {
                    Console.WriteLine(vet[i]);
                }

            }



        }
    }
}
