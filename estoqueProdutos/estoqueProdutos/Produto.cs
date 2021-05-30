using System;
using System.Collections.Generic;
using System.Text;

namespace estoqueProdutos {
    class Produto {

        private string _nome;
        private double _preco;
        private int _qtd;

        public string Nome {
            get { return _nome; }
            set { 
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        public double Preco {
            get { return _preco; }
        }

        public int Qtd {
            get { return _qtd; }
        }

        public Produto() {
            _qtd = 10;
        }

        public Produto(string nome, double preco, int qtd) {
            _nome = nome;
            _preco = preco;
            _qtd = qtd;
        }

        public Produto(string nome, double preco) : this() {
            _nome = nome;
            _preco = preco;
        }

        public double ValorTotalEstoque() {
            return _preco * _qtd;
        }

        public void AddProduto(int qtd) {
            _qtd += qtd;
        }

        public void RemoveProduto(int qtd) {
            _qtd -= qtd;
        }

        public override string ToString() {
            return _nome + 
                   ", $" + _preco.ToString("F2") + 
                   ", estoque: " + _qtd +
                   ", valor do estoque: " + this.ValorTotalEstoque().ToString("F2");
        }



    }
}
