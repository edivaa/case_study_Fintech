using System;
using Case_study_Fintech.Models;
using Case_study_Fintech.Services;
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
        private readonly IUserService UserService; 

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            UserService = userService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            try
            {
                return Ok(UserService.Authentication(user));
            }
            catch (ArgumentNullException)
            {
                return BadRequest();

            }
            catch (EntryPointNotFoundException)
            {
                return NotFound();
            }
            catch (Exception e)
            {

                throw new Exception("Erro no Servidor :"+e.Message);
            }
        }

    }
}
