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
    public class LoginController : ControllerBase
    {
      
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Post(string login, string password)
        {

            return Ok(ValidarLogin(login, password));
        }

        private string ValidarLogin(string login, string password){

                if(login.Equals("edivaa") && password.Equals("1345")) {
                    return  "Login relizado com sucesso";
                }

               throw new  Exception("Login nao realizado");
        }

    }
}
