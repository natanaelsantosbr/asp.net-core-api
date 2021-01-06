using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Natanael.Aplicacao.GestaoDeUsuarios;
using Natanael.Aplicacao.GestaoDeUsuarios.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natanael.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private IServicoDeGestaoDeUsuarios _servicoDeGestaoDeUsuarios;
        public TokenController(IServicoDeGestaoDeUsuarios servicoDeGestaoDeUsuarios)
        {
            this._servicoDeGestaoDeUsuarios = servicoDeGestaoDeUsuarios;
        }

        [HttpPost]
        public async Task<ActionResult<dynamic>> GerarToken([FromBody] ModeloDeLogin model)
        {
            var token = this._servicoDeGestaoDeUsuarios.GerarToken(model);

            // Retorna os dados
            return new
            {
                user = model,
                token = token
            };
        }
    }
}
