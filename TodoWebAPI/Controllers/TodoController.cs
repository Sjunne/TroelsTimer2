using System.Collections.Generic;
using System.Threading.Tasks;
using TodoWebAPI.Data;
using Microsoft.AspNetCore.Mvc;
using TodoWebAPI.Models;

namespace TodoWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private ITodoService service;

        public TodoController(ITodoService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Todo>>> GetTodos([FromQuery] int? id, [FromQuery] bool? completed)
        {
            IList<Todo> todos = await service.GetTodosAsync(completed, id);
            return Ok(todos);
        }
            
    }

}