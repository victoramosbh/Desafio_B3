using Api.Core.DTOs;
using Api.Domain.Entity;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Core.Business.Cdb.Calcular
{
    public class CalcularCdbHandler : IRequestHandler<CalcularCdbRequest, InvestimentoResultDto>
    {
        private readonly InvestimentoDtoValidator _investimentoDtoValidator;
        private IMapper _mapper;

        public CalcularCdbHandler(InvestimentoDtoValidator investimentoDtoValidator, IMapper mapper) => (_investimentoDtoValidator,_mapper) = (investimentoDtoValidator,mapper);

        public async Task<InvestimentoResultDto> Handle(CalcularCdbRequest request, CancellationToken cancellationToken)
        {
            InvestimentoResultDto InvestimentoResultDto;
            var validationResult = await _investimentoDtoValidator.ValidateAsync(request.Request);

            if (!validationResult.IsValid)
                InvestimentoResultDto = new InvestimentoResultDto() { ValorBruto = 0, ValorLiquido = 0, Menssagem = validationResult.ToString() };
            else
            {
                var investimento = _mapper.Map<Investimento>(request.Request);
                CdbUtil.Calcular(investimento);
                InvestimentoResultDto = _mapper.Map<InvestimentoResultDto>(investimento);
            }               

            return InvestimentoResultDto;
        }


    }
}
