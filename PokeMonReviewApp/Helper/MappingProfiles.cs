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
            CreateMap<Owner, OwnerDto>();
            CreateMap<Review, ReviewsDto>();
            CreateMap<Reviewer, ReviwerDto>();
        }
    }
}
