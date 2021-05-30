using System;

namespace Exercicio_01 {
    class Program {
        static void Main(string[] args) {

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("dados da primeira pessoa: (nome e idade)");
            p1.nome = Console.ReadLine();
            p1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("dados da segunda pessoa: (nome e idade)");
            p2.nome = Console.ReadLine();
            p2.idade = int.Parse(Console.ReadLine());

            int maior = p1.comparador(p1.idade, p2.idade);

            if (p1.idade == maior) {
                Console.WriteLine($"A pessoa {p1.nome} é mais velha");
            }else if(p2.idade == maior) {
                Console.WriteLine($"A pessoa {p2.nome} é mais velha");
            } else if(maior == 1){
                Console.WriteLine($"As pessoas tem a mesma idade!");
            }
        }
    }
}
