using System;

namespace Exercicio_Funcionario {
    class Program {
        static void Main(string[] args) {
            
            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f.Salario = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"Funcionario: {f}");

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double a = double.Parse(Console.ReadLine());
            f.AumentoSalario(a);

            Console.WriteLine($"Dados atualizados: {f}");

        }
    }
}
