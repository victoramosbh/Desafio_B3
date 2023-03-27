using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Domain.Entity
{
    public class Investimento
    {
        public double ValorInicial { get; set; }
        public int Prazo { get; set; }
        public double ValorBruto { get; set; }
        public double ValorLiquido { get; set; }
        public double TaxaImposto { get; set; }
    }
}
