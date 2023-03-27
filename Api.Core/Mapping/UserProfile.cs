using Api.Core.DTOs;
using Api.Domain.Entity;
using AutoMapper;

namespace Api.Core.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<InvestimentoDto, Investimento>();
            CreateMap<Investimento, InvestimentoResultDto>();
        }
    }
}
