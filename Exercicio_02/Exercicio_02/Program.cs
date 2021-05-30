using System;

namespace Exercicio_02 {
    class Program {
        static void Main(string[] args) {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("dados da primeira pessoa: (nome e salario)");
            p1.nome = Console.ReadLine();
            p1.salario= double.Parse(Console.ReadLine());
            Console.WriteLine("dados da segunda pessoa: (nome e salario)");
            p2.nome = Console.ReadLine();
            p2.salario = double.Parse(Console.ReadLine());

            double maior = p1.comparador(p1.salario, p2.salario);

            if (p1.salario == maior) {
                Console.WriteLine($"A pessoa {p1.nome} tem o maior salario");
            } else if (p2.salario == maior) {
                Console.WriteLine($"A pessoa {p2.nome} tem o maior salario");
            } else if (maior == 1) {
                Console.WriteLine($"As pessoas tem a mesmo salario");
            }
        }
    }
}
