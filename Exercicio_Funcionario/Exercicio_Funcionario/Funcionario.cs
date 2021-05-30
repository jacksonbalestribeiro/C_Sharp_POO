using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Funcionario {
    class Funcionario {

        public string Nome;
        public double Salario;
        public double Imposto;

        public override string ToString() {
            return Nome + ", $" + (Salario - Imposto);  
        }

        public void AumentoSalario(double aumento) {
            aumento = Salario * (aumento / 100);
            Salario += aumento;
        }




    }
}
