using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    internal class Contribuinte
    {
        private string nome { get; set; }
        private float rendaBruta { get; set; }

        public Contribuinte(string nome, float rendaBruta)
        {
            this.nome = nome;
            this.rendaBruta = rendaBruta;
        }

        public Contribuinte()
        {

        }

        public float getRendaBruta()
        {
            return rendaBruta;
        }

        public string getNome()
        {
            return nome;
        }

        public virtual float calculaImposto(float rendaBruta)
        {
            float imposto;
            if (rendaBruta <= 1400.00)
            {
                imposto = 0;
            }
            else if (rendaBruta <= 2100.00)
            {
                imposto = (rendaBruta * 10 / 100);
            }
            else if (rendaBruta <= 2800.00)
            {
                imposto = (rendaBruta * 15 / 100);
            }
            else if (rendaBruta <= 3600.00)
            {
                imposto = (rendaBruta * 25 / 100);
            }
            else
            {
                imposto = (rendaBruta * 30 / 100);
            }
            return imposto;
        }
    }
}
