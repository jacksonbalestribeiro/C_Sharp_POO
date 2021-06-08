using System;

namespace Revicao_Vetores {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
            double resposta = 0;
            double[] vet = new double[n];

            for (int i = 0; i < vet.Length; i++) {
                vet[i] = double.Parse(Console.ReadLine()); 
            }
            for (int i = 0; i < vet.Length; i++) {
                resposta += vet[i];
            }

            resposta = resposta / vet.Length;

            Console.WriteLine($"media de altura = {resposta.ToString("F2")}");

        }
    }
}
