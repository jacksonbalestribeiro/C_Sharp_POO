using System;

namespace AreaRetangulo {
    class Program {
        static void Main(string[] args) {

            Retangulo T = new Retangulo();

            Console.WriteLine("Entre com largura e altura do retangulo: ");
            T.Largura = double.Parse(Console.ReadLine());
            T.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"AREA = {T.Area()}");
            Console.WriteLine($"PERIMETRO = {T.Perimetro()}");
            Console.WriteLine($"DIAGONAL = {T.Diagonal()}");


        }
    }
}
