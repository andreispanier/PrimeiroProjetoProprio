using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProprio1
{
    public class PicTipos : Capitalizacao
    {
        public double Pic30 { get; set; }
        public double Pic60 { get; set; }
        public double Pic90 { get; set; }

        public double EscolhaPIC30(Capitalizacao capitalizacao)
        {
            return ValorPic = 30;
        }
        public double EscolhaPIC60()
        {
            return ValorPic = 60;
        }
        public double EscolhaPIC90()
        {
            return ValorPic = 90;
        }


    }
}
