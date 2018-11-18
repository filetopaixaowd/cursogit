using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace aula02
{
    class Produto
    {
        public string nome { get; private set; };
        private double preco { get; private set; };
        private int qtdEstoque { get; private set; };



        public Produto(string nome, double preco , int qtdEstoque)
        {
            this.nome = nome;
            this.preco = preco;
            this.qtdEstoque = qtdEstoque;
        }

        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
            this.qtdEstoque = 0;
        }

        public double valorTotalEmEstoque()
        {
            return preco * qtdEstoque;
        }

        public void realizarEntrada(int quantidade)
        {
            qtdEstoque = qtdEstoque + quantidade;
        }

        public void realizarSaida(int quantidade)
        {
            qtdEstoque = qtdEstoque - quantidade;
        }

        public override string ToString()
        {
            return nome 
                + ", R$" 
                + preco.ToString("F2",CultureInfo.InvariantCulture) 
                + ", " 
                + qtdEstoque
                +" unidades, total em estoque: R$"
                + valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
