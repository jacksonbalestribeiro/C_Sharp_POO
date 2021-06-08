using System;

namespace CriandoStructs {
    class Program {
        static void Main(string[] args) {

            /* um tipo struct não precisa de construtor 
             * não alocando memoria no heap e não criando ponteiro 
             * sim no stack!
             */

            Struct p;
            p.x = 10;
            p.y = 11;
            Console.WriteLine(p);


        }
    }
}
