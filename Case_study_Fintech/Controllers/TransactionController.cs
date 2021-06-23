using Case_study_Fintech.Models;
using Case_study_Fintech.Services;
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
        private readonly ITransactionService TransactionService;

        public TransactionController(ILogger<AccountController> logger, ITransactionService transactionService)
        {
            _logger = logger;
            TransactionService = transactionService;
        }

        [HttpPost("Create transaction")]
        public IActionResult Post(AccountTransaction transacao)
         {
            return Ok(TransactionService.TransferByPix(transacao.AccountNumber, transacao.TransactionValue));
        }

        [HttpGet("Get transactions")]
        public IActionResult Get(int accountNumber)
        {
            return Ok(TransactionService.TransferHistory(accountNumber));
        }

        //[HttpGet("Get accounts")]
        //public IActionResult Gets()
        //{
        //    return Ok(transactionService.GetAccounts());
        //}



    }
}
