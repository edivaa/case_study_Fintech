using Case_study_Fintech.Models;
using Case_study_Fintech.Services.Implementations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Case_study_Fintech.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
      
        private readonly ILogger<AccountController> _logger;
        private readonly TransactionService transactionService;

        public TransactionController(ILogger<AccountController> logger)
        {
            _logger = logger;
            transactionService = new TransactionService();
        }

        [HttpPost("Create transaction")]
        public IActionResult Post(AccountTransaction transacao)
         {
            return Ok(transactionService.TransferByPix(transacao.AccountNumber, transacao.TransactionValue));
        }

        [HttpGet("Get transactions")]
        public IActionResult Get(int accountNumber)
        {
            return Ok(transactionService.TransferHistory(accountNumber));
        }

        //[HttpGet("Get accounts")]
        //public IActionResult Gets()
        //{
        //    return Ok(transactionService.GetAccounts());
        //}



    }
}
