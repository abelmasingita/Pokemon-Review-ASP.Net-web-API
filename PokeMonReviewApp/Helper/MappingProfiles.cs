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
            CreateMap<PokemonDto, Pokemon>();
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<Country, CountryDto>();
            CreateMap<CountryDto, Country>();
            CreateMap<Owner, OwnerDto>();
            CreateMap<OwnerDto, Owner>();
            CreateMap<Review, ReviewsDto>();
            CreateMap<ReviewsDto, Review>();
            CreateMap<Reviewer, ReviwerDto>();
            CreateMap<ReviwerDto, Reviewer>();
        }
    }
}
