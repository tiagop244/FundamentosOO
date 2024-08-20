using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Produto
    {
        public int Estoque { get; set; };
        public double Preco { get; set; };
        public int Codigo { get; set; };
        public string Nome { get; set; };

        public void QuantidadeEstoque()
        {
            Console.WriteLine("A quantidade em estoque é: " + this.Estoque
        }
    }
}
