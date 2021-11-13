using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProprio1
{
    class Cartao
    {
        public string Nome { get; set; }
        public string Bandeira { get; set; }
        public double ValorCartao { get; set; }
        public double PesoCartao { get; set; }
        public double ProducaoCartao { get; set; }
        

        public double CalculoCartao(double valor, double peso)
        {
            double calculo = valor * peso;
            this.ProducaoCartao += calculo;
            return calculo;
        }

        public double ConsultarProducaoCartao()
        {
           return ProducaoCartao;
        }

    }
}
