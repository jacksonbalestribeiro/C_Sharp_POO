using System;
using System.Globalization;

namespace Exercicio_Banco {
    class Program {
        static void Main(string[] args) {

            ContaCorrente c;

            Console.WriteLine("Entre com numero da conta:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o nome do titular da conta:");
            string nome = Console.ReadLine();
            double valor;

            Console.WriteLine("Haverá deposito inicial? ");
            string resp = Console.ReadLine();
            if (resp.Equals("s")) {
                Console.WriteLine("Entre como valor de deposito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new ContaCorrente(n, nome, valor);
            } else {
                c = new ContaCorrente(n, nome);
            }

            Console.WriteLine(c);

            Console.WriteLine("Entre com valor de deposito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(c.Deposito(valor));

            Console.WriteLine(c);

            Console.WriteLine("Entre com valor de Saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(c.Saque(valor));

            Console.WriteLine(c);

        }
    }
}
