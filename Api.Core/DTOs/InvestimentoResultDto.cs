using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Core.DTOs
{
    public class InvestimentoResultDto
    {
        public double ValorBruto { get; set; }
        public double ValorLiquido { get; set; }
        public string Menssagem { get; set; }

        public InvestimentoResultDto(double valorBruto, double valorLiquido,string menssagem)
        {
            this.ValorBruto = valorBruto;
            this.ValorLiquido = valorLiquido;
            this.Menssagem = menssagem;
        }

        public InvestimentoResultDto()
        {
            ValorBruto = 0;
            ValorLiquido = 0;
            Menssagem = "";
        }
    }
}
