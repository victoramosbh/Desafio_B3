using Api.Core.DTOs;
using FluentValidation;

namespace Api.Core.Business.Cdb.Calcular
{
    public class InvestimentoDtoValidator : AbstractValidator<InvestimentoDto>
    {

        public InvestimentoDtoValidator()
        {
            //se valorInicial maior que 0, nao dá menssagen
            RuleFor(i => i.ValorInicial).GreaterThan(0).WithMessage("O Valor Inicial deve ser positivo.");
            //se Prazo maior que 1, nao dá menssagen
            RuleFor(i => i.Prazo).GreaterThan(1).WithMessage("O prazo para resgate (em meses) deve ser maior que 1.");
        }
    }
}
