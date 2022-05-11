using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.Services.Authors;
using TaskAPI.Services.Models;

namespace TaskAPI.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _services;
        private readonly IMapper _mapper;
        public AuthorsController(IAuthorRepository services, IMapper mapper)
        {
            _services = services;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<ICollection<AuthorDto>> GetAuthors(string job,string search)
        {
            var authors = _services.GetAllAuthors(job,search);
            if (authors == null)
            {
                return NotFound();
            }
            var authorDto = _mapper.Map<ICollection<AuthorDto>>(authors);
            
            return Ok(authorDto);
        }
        [HttpGet("{Id}", Name = "GetAuthor")]
        public ActionResult<AuthorDto> GetAuthor(int Id)
        {
            var author = _services.GetAuthor(Id);
            if (author == null)
            {
                return NotFound();
            }
            var authorDto = _mapper.Map<AuthorDto>(author);
            return Ok(authorDto);
        }
        [HttpPost]
        public ActionResult<AuthorDto> CreateAuthor(CreateAuhtorDto author)
        {
            var mapedAuthor = _mapper.Map<Author>(author);
            var newAuthor = _services.AddAuthor(mapedAuthor);
            var AuthorForReturn = _mapper.Map<AuthorDto>(newAuthor);
            return CreatedAtRoute(nameof(GetAuthor), new { Id = AuthorForReturn.Id }, AuthorForReturn);
        }
    }
}
