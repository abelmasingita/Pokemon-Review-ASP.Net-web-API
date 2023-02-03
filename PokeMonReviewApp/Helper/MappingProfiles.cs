using AutoMapper;
using PokeMonReviewApp.Dto;
using PokeMonReviewApp.Models;

namespace PokeMonReviewApp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Country, CountryDto>();
        }
    }
}
