using Api.Core.DTOs;
using Api.Domain.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Core.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile() {
            CreateMap<InvestimentoDto, Investimento>();
            CreateMap<Investimento, InvestimentoResultDto>();
        }    
    }
}
