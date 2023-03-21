using CDB_B3_VICTOR_RAMOS_Api.DTO;
using CDB_B3_VICTOR_RAMOS_Domain.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CDB_B3_VICTOR_RAMOS_Api.Controllers
{
    public class InvestimentosController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage CalcularCDB(double valor,int meses)
        {

            try
            {
                Investimento investimento = new Cdb(valor, meses);
                investimento.Calcular();

                return  Request.CreateResponse<CdbDto>(HttpStatusCode.OK, new CdbDto { ValorBruto = investimento.ValorBruto, ValorLiquido = investimento.ValorLiquido });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse<CdbDto>(HttpStatusCode.OK, new CdbDto { Mensagem = ex.Message });
            }
        }
    }
}
