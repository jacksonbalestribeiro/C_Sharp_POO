using System;
using System.Collections.Generic;
using System.Text;

namespace estoqueProdutos {
    class Produto {

        private string _nome;
        public double Preco { get; private set; }
        public int Qtd { get; private set; }
        
        public Produto() {
            Qtd = 10;
        }

         public Produto(string nome, double preco, int qtd) {
            _nome = nome;
            Preco = preco;
            Qtd = qtd;
        }

        public Produto(string nome, double preco) : this() {
            _nome = nome;
            Preco = preco;
        }

        public string Nome {
            get { return _nome; }
            set { 
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEstoque() {
            return Preco * Qtd;
        }

        public void AddProduto(int qtd) {
            Qtd += qtd;
        }

        public void RemoveProduto(int qtd) {
            Qtd -= qtd;
        }

        public override string ToString() {
            return _nome + 
                   ", $" + Preco.ToString("F2") + 
                   ", estoque: " + Qtd +
                   ", valor do estoque: " + this.ValorTotalEstoque().ToString("F2");
        }



    }
}
