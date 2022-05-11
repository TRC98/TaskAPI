using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.Services.Models;

namespace TaskAPI.Services.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorDto>()
                .ForMember(dest => dest.Adderess,
                opt => opt.MapFrom(src => $"{src.AdderessNo}, {src.Street}, {src.City}"));
            CreateMap<CreateAuhtorDto, Author>();
        }
    }
}
