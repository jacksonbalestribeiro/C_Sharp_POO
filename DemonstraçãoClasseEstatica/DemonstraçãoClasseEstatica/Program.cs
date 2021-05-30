using System;
using System.Globalization;

namespace DemonstraçãoClasseEstatica {
    class Program {

         

        static void Main(string[] args) {

            

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           
            Console.WriteLine("Circunferencia: " + Calculadora.Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + Calculadora.Volume(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }

        
    }
}
