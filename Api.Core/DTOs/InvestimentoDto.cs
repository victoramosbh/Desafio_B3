using Api.Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Core.DTOs
{
    public class InvestimentoDto
    {
        public int Prazo { get; set; }  
        public double ValorInicial { get; set; }
                
        //[Range(minimum: 2, maximum: int.MaxValue, ErrorMessage = "O prazo para resgate (em meses) deve ser maior que 1.")]
        //public int Prazo
        //{
        //    get => _prazo;
        //    set
        //    {
        //        if (value < 2)
        //            throw new ErroNegocio("O prazo para resgate (em meses) deve ser maior que 1.");
            
        //        _prazo = value;
        //    }
        //}

        //[Range(minimum: 0.01, maximum: double.MaxValue, ErrorMessage = "O valor inicial deve ser positivo.")]
        //public double ValorInicial
        //{
        //    get => _valorInicial;
        //    set
        //    {
        //        if (value <= 0)
        //            throw new ErroNegocio("O valor inicial deve ser positivo.");

        //        _valorInicial = value;
        //    }
        //}
    }
}
