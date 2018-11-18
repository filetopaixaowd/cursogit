using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd;
            Produto P;

                        Console.WriteLine("Digite os dados do produto:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );

            Console.Write("Qtd em estoque: ");
            int qtdEstoque = int.Parse(Console.ReadLine());

            P = new Produto(nome, preco, qtdEstoque);

            


            Console.ReadLine();
        }
    }
}
