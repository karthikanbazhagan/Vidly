namespace Vidly.App_Start
{
    using AutoMapper;
    using Vidly.Dtos;
    using Vidly.Models;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();

            // Dto to Domain
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<MovieDto, Movie>();
        }
    }
}