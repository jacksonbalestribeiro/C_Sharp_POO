using System;

namespace Exercicio_ClasseEstatica {
    class Program {
        static void Main(string[] args) {
            Console.Write("qual a cotação do dolar?");
            double cotação = double.Parse(Console.ReadLine());
            Console.Write("Quantos dolares você vai comprar?");
            double vlrCompra = double.Parse(Console.ReadLine());
            Console.WriteLine($"Valor pagos em reais {Calculadora(cotação, vlrCompra)}");

        }

        static double Calculadora(double cotacao, double vrlcompra) {
            double IOF = 0.06;
            double resut = cotacao * vrlcompra;
            return resut += resut * IOF;

        }
    }
}
