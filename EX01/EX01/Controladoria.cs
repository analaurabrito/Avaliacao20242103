using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    internal class Controladoria
    {
        private double totalDeImpostos { get; set; }
        private double totalDeImpostosPFisica { get; set; }
        private float totalDeImpostosPJuridica { get; set; }

        public float gerenciaImpostos(Contribuinte contribuinte)
        {
            float log =+ contribuinte.getRendaBruta();
            return log;
        }

        public double totalizaImpostos(List<Contribuinte> c)
        {
            foreach(Contribuinte contribuinte in c)
            {
                if (c.GetType() == typeof(PFisica))
                {
                    totalDeImpostosPFisica += contribuinte.calculaImposto(contribuinte.getRendaBruta());
                }

                else
                {
                    totalDeImpostosPJuridica += +contribuinte.calculaImposto(contribuinte.getRendaBruta());
                }

                totalDeImpostos += (totalDeImpostosPFisica + totalDeImpostosPJuridica);
            }

            return totalDeImpostos;
        }
    }
}
