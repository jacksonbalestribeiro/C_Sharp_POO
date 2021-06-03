using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Banco {
    class ContaCorrente {

        private int NConta { get; set; }
        private string Usuario { get; set; }
        private double Saldo { get; set; }

        public ContaCorrente(int nconta, string usuario) {
            Saldo = 0.0;
            NConta = nconta;
            Usuario = usuario;
        }
        public ContaCorrente(int nconta, string usuario, double saldo) {
            Saldo = saldo;
            NConta = nconta;
            Usuario = usuario;
        }

        public string Deposito(double valor) {
            Saldo += valor; 
            return "Deposito realizado com sucesso";
        }
        public string Saque(double valor) {
            if (Saldo >= (valor + 5) ) {
                Saldo -= (valor + 5);
                return "Saque realizado com sucesso";
            } else {
                return "Saldo insuficiente";
            }
        }

        public override string ToString() {
            return $"\n\nDados da conta:\nConta: N° {NConta}, Titular: {Usuario}, Saldo: R$ {Saldo.ToString("F2")}\n\n";
        }

    }
}
