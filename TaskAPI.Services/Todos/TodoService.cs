using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public class TodoService : ITodoRepository
    {
        public Todo AddTodo(int authorId, Todo todo)
        {
            throw new NotImplementedException();
        }

        //Get Todos
        public List<Todo> AllTodos(int AuthorId)
        {
            var todos = new List<Todo>();
            var todo1 = new Todo
            {
                Id = 1,
                Title = "Get books for school",
                Description = "Get some text books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.Now
            };
            todos.Add(todo1);
            var todo2 = new Todo
            {
                Id = 2,
                Title = "Get Vegitables",
                Description = "Get vegitable for week",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.Now
            };
            todos.Add(todo2);
            var todo3 = new Todo
            {
                Id = 3,
                Title = "Water the plants",
                Description = "Water All the plants quikly",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                Status = TodoStatus.Now
            };
            todos.Add(todo3);

            return todos;
        }

        public void deleteTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public Todo GetTodo(int AuthorId, int Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTodo(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}
