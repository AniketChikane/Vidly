using AutoMapper;
using Vidly1.Dtos;
using Vidly1.Models;

namespace Vidly1.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customers, CustomersDto>();
            Mapper.CreateMap<Movie, MoviesDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();
        }
    }
}