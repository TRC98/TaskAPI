using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.DataAccess;
using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public class TodoSqlServerService : ITodoRepository
    {
        private readonly TodoDbContext _context = new TodoDbContext();
        public List<Todo> AllTodos(int AuthorId)
        {
            return _context.Todos.Where(t=>t.AuthorId==AuthorId).ToList();
        }

        public Todo GetTodo(int AuthorId, int Id)
        {
            return _context.Todos.Where(t=>t.Id==Id && t.AuthorId==AuthorId).FirstOrDefault();
        }
        public Todo AddTodo(int authorId, Todo todo)
        {
            todo.AuthorId = authorId;
            _context.Todos.Add(todo);
            _context.SaveChanges();
            return _context.Todos.Find(todo.Id);
        }
    }
}
