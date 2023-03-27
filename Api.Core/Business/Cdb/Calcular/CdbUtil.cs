using Api.Domain.Entity;
using Api.Domain.Models;

namespace Api.Core.Business.Cdb.Calcular
{
    public static class CdbUtil
    {
        public static Investimento Calcular(Investimento investimento)
        {
            CalcularValorBruto(investimento);
            CalcularTaxaImposto(investimento);
            CalcularValorLiquido(investimento);

            return investimento;
        }
        private static void CalcularValorBruto(Investimento investimento)
        {
            investimento.ValorBruto = investimento.ValorInicial * Math.Pow(1 + (CdbParametros.TB * CdbParametros.CDI), investimento.Prazo);
        }

        private static void CalcularValorLiquido(Investimento investimento)
        {
            investimento.ValorLiquido = investimento.ValorBruto - ((investimento.ValorBruto - investimento.ValorInicial) * investimento.TaxaImposto);
        }
        private static void CalcularTaxaImposto(Investimento investimento)
        {
            if (investimento.Prazo <= 6)
                investimento.TaxaImposto = CdbParametros.TAXA_SEIS_MESES;
            else if (investimento.Prazo > 6 && investimento.Prazo <= 12)
                investimento.TaxaImposto = CdbParametros.TAXA_DOZE_MESES;
            else if (investimento.Prazo > 12 && investimento.Prazo <= 24)
                investimento.TaxaImposto = CdbParametros.TAXA_VINTE_QUATRO_MESES;
            else
                investimento.TaxaImposto = CdbParametros.TAXA_ACIMA;
        }
    }
}
