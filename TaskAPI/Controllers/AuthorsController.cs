using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public ActionResult<ICollection<AuthorDto>> GetAuthors()
        {
            var authors = _services.GetAllAuthors();
            if (authors == null)
            {
                return NotFound();
            }
            var authorDto = _mapper.Map<ICollection<AuthorDto>>(authors);
            
            return Ok(authorDto);
        }
        [HttpGet("{Id}")]
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
    }
}
