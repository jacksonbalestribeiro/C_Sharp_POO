using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Vetores {
    class Alugueis {

        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public Alugueis( int quarto) {
            Nome = "vazio";
            Email = "vazio"; 
            Quarto = quarto;
        }

        public Alugueis(string nome, string email, int quarto) {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public override string ToString() {
            return $"{Quarto}: {Nome}, {Email}";
        }

    }
}
