using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Case_study_Fintech.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaController : ControllerBase
    {
      
        private readonly ILogger<ContaController> _logger;

        public ContaController(ILogger<ContaController> logger)
        {
            _logger = logger;
        }

        [HttpPost("ObterSaldoConta")]
        public IActionResult Post(object conta)
        {

            return Ok(new {saldo = 35256663});
        }


    }
}
