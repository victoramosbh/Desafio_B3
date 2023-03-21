using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CDB_B3_VICTOR_RAMOS_Domain.Models
{
    public class Cdb : Investimento
    {
        private const double TB = 1.08;
        private const double CDI = 0.009;

        public Cdb(double valorInicial, int prazoResgate) : base(valorInicial, prazoResgate) { }

        public override void Calcular()
        {
            double taxaImposto = CalcularTaxaImposto();

            base.ValorBruto = base.ValorInicial * Math.Pow(1 + (TB * CDI), PrazoResgate);
            base.ValorLiquido = base.ValorBruto - ((base.ValorBruto - base.ValorInicial) * taxaImposto);

        }

        private double CalcularTaxaImposto()
        {
            double taxaImposto;

            if (base.PrazoResgate <= 6)
                taxaImposto = 0.225;
            else if (base.PrazoResgate > 6 && base.PrazoResgate <= 12)
                taxaImposto = 0.20;
            else if (base.PrazoResgate > 12 && base.PrazoResgate <= 24)
                taxaImposto = 0.175;
            else
                taxaImposto = 0.15;

            return taxaImposto;
        }
        
    }
}