using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Services.Todos;

namespace TaskAPI.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todoService;
        public TodosController(ITodoRepository repository)
        {
            _todoService = repository;
        }
        [HttpGet]
        public IActionResult GetTodos()
        {
            var mytodos = _todoService.AllTodos();
            if(mytodos == null)
            {
                return NotFound();
            }
            return Ok(mytodos);
        }
        [HttpGet("{Id}")]
        public IActionResult GetTodo(int Id)
        {
            var mytodo = _todoService.GetTodo(Id);
            if (mytodo == null)
            {
                return NotFound();
            }
            return Ok(mytodo);
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
