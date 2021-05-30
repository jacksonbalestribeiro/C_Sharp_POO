using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_01 {
    class Pessoa {

        public string nome;
        public int idade;

        public int comparador(int numero, int numero2 ) {
            
            int id = numero;
            int id2 = numero2;
            int igual = 1;

            if (id > id2) {
                return id;
            }else if(id < id2) {
                return id2;
            } else {
                return igual;
            }
        }
    }
}
