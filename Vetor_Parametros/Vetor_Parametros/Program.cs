using System;

namespace Vetor_Parametros {
    class Program {
        static void Main(string[] args) {

            int soma = calc.Calculadora(1,2,3);
            Console.WriteLine(soma);

        }
    }
    class calc {
        public static int Calculadora(params int[] numero) {
            int soma = 0;
            for (int i = 0; i< numero.Length; i++) {
                soma += numero[i];
            }
            return soma;
        }
    }
}
