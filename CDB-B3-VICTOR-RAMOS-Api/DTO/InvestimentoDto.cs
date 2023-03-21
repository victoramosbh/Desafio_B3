using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CDB_B3_VICTOR_RAMOS_Api.DTO
{
    public class InvestimentoDto : BaseDto
    {
        public double ValorBruto { get; set; }
        public double ValorLiquido { get; set; }
    }
}