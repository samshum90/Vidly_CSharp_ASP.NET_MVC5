using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            CreateMap<Customer, CustomerDto>();
            CreateMap<Movie, MovieDto>();


            // Dto to Domain
            CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            CreateMap<MovieDto, Movie>()
                .ForMember(c => c.Id, opt => opt.Ignore());

        }
    }
}
