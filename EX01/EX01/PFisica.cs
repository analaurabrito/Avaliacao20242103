using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    internal class PFisica : Contribuinte
    {
        private string cpf { get; set; }

        public PFisica(string cpf, string nome, float rendaBruta) : base(nome, rendaBruta)
        {
            this.cpf = cpf;
        }

        public override float calculaImposto(float rendaBruta)
        {
            return base.calculaImposto(rendaBruta);
        }
    }
}
