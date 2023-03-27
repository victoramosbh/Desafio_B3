using Api.Core.Business.Cdb.Calcular;
using Api.Core.DTOs;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CdbController : BaseController
    {
        public CdbController(IMediator mediator, IMapper mapper) : base(mediator, mapper) { }

        [HttpPost]
        public async Task<ActionResult<InvestimentoResultDto>> Calcular([FromBody] InvestimentoDto investimentoDto)
        {
            InvestimentoResultDto investimentoResultDto;

            try
            {
                investimentoResultDto = await _mediator.Send(new CalcularCdbRequest(investimentoDto));
            }
            catch (Exception ex)
            {
                return new ObjectResult(new { message = ex.Message }) { StatusCode = Convert.ToInt32(HttpStatusCode.InternalServerError) };
            }

            return Ok(investimentoResultDto);
        }
    }
}