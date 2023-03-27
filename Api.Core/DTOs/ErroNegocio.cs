using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Core.DTOs
{
    public class ErroNegocio : Exception
    {
        public ErroNegocio(string mensagem) : base(mensagem) { }
}
}
