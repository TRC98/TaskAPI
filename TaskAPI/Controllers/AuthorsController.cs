using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Services.Authors;

namespace TaskAPI.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _services;
        public AuthorsController(IAuthorRepository services)
        {
            _services = services;
        }
        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authors = _services.GetAllAuthors();
            if (authors == null)
            {
                return NotFound();
            }
            return Ok(authors);
        }
        [HttpGet("{Id}")]
        public IActionResult GetAuthor(int Id)
        {
            var author = _services.GetAuthor(Id);
            if (author == null)
            {
                return NotFound();
            }
            return Ok(author);
        }
    }
}
