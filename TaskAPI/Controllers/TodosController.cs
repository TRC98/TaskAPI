using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Services;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todoService;
        public TodosController(ITodoRepository repository)
        {
            _todoService = new TodoService();
        }
        [HttpGet("{id?}")]
        public IActionResult GetTodos(int? id)
        {
            var mytodos = _todoService.AllTodos();

            if (id == null) return Ok(mytodos);

            mytodos = mytodos.Where(t => t.Id == id).ToList();
            return Ok(mytodos);
        }

        [HttpPut]
        public IActionResult UpdateTask()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteTask()
        {
            var somethingWrong = true;
            if (somethingWrong)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
