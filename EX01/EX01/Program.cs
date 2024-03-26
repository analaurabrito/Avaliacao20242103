using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> contribuinte = new List<Contribuinte>();

            PFisica pf1 = new PFisica("12345678900", "Vivian", 2700.02f);
            PFisica pf2 = new PFisica("09876543211", "Carlos", 1800.67f);
            PFisica pf3 = new PFisica("11122233344", "Francis", 3820.99f);
            PFisica pf4 = new PFisica("78778258688", "Eustáquio", 1600.20f);
            PFisica pf5 = new PFisica("45612388800", "Beatriz", 210.99f);

            PJuridica pj1 = new PJuridica("678543", "Doces Adoçados", 5700.80f);
            PJuridica pj2 = new PJuridica("902345", "Franguinho Frito", 16050.90f);
            PJuridica pj3 = new PJuridica("442312", "Lolly Brinquedos", 39100.00f);
            PJuridica pj4 = new PJuridica("086745", "Tech Tudo", 80080.80f);
            PJuridica pj5 = new PJuridica("123456", "Tapa where?", 32456.00f);

            Controladoria controladoria = new Controladoria();

            contribuinte.Add(pf1);
            contribuinte.Add(pf2);
            contribuinte.Add(pf3);
            contribuinte.Add(pf4);
            contribuinte.Add(pf5);
            contribuinte.Add(pj1);
            contribuinte.Add(pj2);
            contribuinte.Add(pj3);
            contribuinte.Add(pj4);
            contribuinte.Add(pj5);

            foreach(Contribuinte c in contribuinte)
            {
                Console.WriteLine("Imposto de " +c.getNome()+ ": R$ " + c.calculaImposto(c.getRendaBruta()));
            }
            Console.WriteLine("Total de impostos: R$ " +controladoria.totalizaImpostos(contribuinte));
        }
    }
}
