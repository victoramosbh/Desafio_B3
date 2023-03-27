using Api.Core.DTOs;
using MediatR;

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
