using Api.Core.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Core.Business.Cdb.Calcular
{
    public class CalcularCdbRequest : IRequest<InvestimentoResultDto>
    {
        public InvestimentoDto Request { get; set; }

        public CalcularCdbRequest(InvestimentoDto request)
        {
            Request = request;
        }
    }
}
