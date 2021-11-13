using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProprio1
{
    class Crediario
    {
        public string NomeCrediario { get; set; }
        public double ValorCrediario { get; set; }
        public double PesoCrediario { get; set; }
        public double SeguroCrediario { get; set; }
        public double ProducaoCrediario { get; set; }
        public bool SeguroPrestamista { get; set; }

        public bool IncluirSeguro(int sim)
        {
            if (sim == 1)
            {
                return SeguroPrestamista = true;
            }
            else
            {
                return SeguroPrestamista = false;         

            }
        }

        public double CalculoCrediario(double valor, double peso)
        {
            if (SeguroPrestamista == true)
            {
                double calculo = (valor * peso) + ((peso * valor) * 0.3);
                ProducaoCrediario += calculo;
                return calculo;
            }
            else
            {
                double calculo = valor * peso;
                ProducaoCrediario += calculo;
                return calculo;
            }
        }

        public double ConsultarProducaoCrediario()
        {
            return ProducaoCrediario;
        }




    }
}
