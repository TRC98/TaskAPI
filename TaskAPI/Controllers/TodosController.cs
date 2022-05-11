using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.Services.Models;
using TaskAPI.Services.Todos;

namespace TaskAPI.Controllers
{
    [Route("api/authors/{authorId}/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todoService;
        private readonly IMapper _mapper;
        public TodosController(ITodoRepository repository , IMapper mapper)
        {
            _todoService = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<ICollection<TodoDto>> GetTodos(int authorId)
        {
            var mytodos = _todoService.AllTodos(authorId);
            if(mytodos == null)
            {
                return NotFound();
            }
            var myTodoDtos = _mapper.Map<ICollection<TodoDto>>(mytodos);
            return Ok(myTodoDtos);
        }
        [HttpGet("{Id}",Name = "GetTodo")]
        public IActionResult GetTodo(int AuthorId, int Id)
        {
            var mytodo = _todoService.GetTodo(AuthorId, Id);
            if (mytodo == null)
            {
                return NotFound();
            }
            var myTodoDto = _mapper.Map<TodoDto>(mytodo);
            return Ok(myTodoDto);
        }
        [HttpPost]
        public ActionResult<TodoDto> CreateTodo(int authorId, CreateTodoDto todo)
        {
            var mappedTodo = _mapper.Map<Todo>(todo);
            var newTodo = _todoService.AddTodo(authorId, mappedTodo);
            var returnTodo = _mapper.Map<TodoDto>(newTodo);
            return CreatedAtRoute(nameof(GetTodo), new { AuthorId=returnTodo.AuthorId, Id =returnTodo.Id }, returnTodo);
        } 
        
    }
}
