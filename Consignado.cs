using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProprio1
{
    class Consignado
    {
        public string Nome { get; set; }
        public double ValorConsignado { get; set; }
        public double PesoConsignado { get; set; }
        public double ProducaoConsignado { get; set; }


        public double CalculoConsignado(double valor, double peso)
        {
            double calculo = valor * peso;
            ProducaoConsignado += calculo;
            return calculo;
        }
                   

        public double ConsultarProducaoConsignado()
        {
            return ProducaoConsignado;
        }



    }
}
