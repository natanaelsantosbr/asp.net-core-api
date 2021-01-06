using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Natanael.Aplicacao;
using Natanael.Aplicacao.GestaoDeClientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natanael.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private IServicoDeGestaoDeClientes _servicoDeGestaoDeClientes;

        public ClientesController(IServicoDeGestaoDeClientes servicoDeGestaoDeClientes)
        {
            this._servicoDeGestaoDeClientes = servicoDeGestaoDeClientes;
        }

        [HttpGet]
        public ModeloDeRetornoDaLista Get()
        {
            return this._servicoDeGestaoDeClientes.Listar();
        }
    }
}
