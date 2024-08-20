using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Carro
    {
        public string Marca { get; set; };
        public string Modelo { get; set; };
        public int Velocidade { get; set; };
        public void Acelerar()
        {
            this.Velocidade = +5
                Console.WriteLine("A velocidade Atual é " + this.Velocidade + " km");
        }
    }
}
