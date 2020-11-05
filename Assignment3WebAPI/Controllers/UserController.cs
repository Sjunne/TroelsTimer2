using System;
using System.Threading.Tasks;
using Assignment3WebAPI.Data;
using Assignment3WebAPI.UserService;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserService service;
        
        public UserController(IUserService service)
        {
            this.service = service;
        }
        
        
        [HttpGet]
        public async Task<ActionResult<User>> GetUserValidation([FromQuery]string username, string password)
        {

            try
            {
                User user = await service.ValidateUser(username, password);
                Console.WriteLine(user.Password);
                return user;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}