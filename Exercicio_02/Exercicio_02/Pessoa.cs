using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_02 {
    class Pessoa {

        public string nome;
        public double salario;

        public double comparador(double numero, double numero2) {

            double id = numero;
            double id2 = numero2;
            double igual = 1;

            if (id > id2) {
                return id;
            } else if (id < id2) {
                return id2;
            } else {
                return igual;
            }
        }
    }
}
