using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Localizador.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalizadorController : ControllerBase
    {
        [Authorize("Bearer")]
        [HttpGet("Localizacao/{posicao}")]
        public object Localizacao()
        {
            return new { };
        }
    }
}