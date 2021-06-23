using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Case_study_Fintech.Models;
using Case_study_Fintech.Services.Implementations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Case_study_Fintech.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
      
        private readonly ILogger<AccountController> _logger;
        private readonly AccountService AccountService;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
            AccountService = new AccountService();
        }

        [HttpPost("Create account")]
        public IActionResult Post(Account account)
        {

            return Ok(AccountService.CreateAnAccount(account));
        }

        [HttpGet("Get account")]
        public IActionResult Get(int id)
        {
            return Ok(AccountService.GetAccount(id));
        }

        [HttpGet("Get accounts")]
        public IActionResult Gets()
        {
            return Ok(AccountService.GetAccounts());
        }



    }
}
