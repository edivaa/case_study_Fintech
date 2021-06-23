using System;
using Case_study_Fintech.Models;
using Case_study_Fintech.Services.Implementations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Case_study_Fintech.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
      
        private readonly ILogger<UserController> _logger;
        private readonly UserService UserService; 

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
            UserService = new  UserService();
        }

        [HttpPost]
        public IActionResult Post(string login, string password)
        {

            return Ok(UserService.Authentication(new User() { Email= login, Password = password }));
        }

    }
}
