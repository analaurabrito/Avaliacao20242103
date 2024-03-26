using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    internal class PJuridica : Contribuinte
    {
        public string cnpj { get; set; }

        public PJuridica(string cnpj, string nome, float rendaBruta) : base(nome, rendaBruta)
        {
            this.cnpj = cnpj;
        }

        public override float calculaImposto(float rendaBruta)
        {
            float imposto = rendaBruta * 10 / 100;
            return imposto;
        }
    }
}
