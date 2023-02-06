using PokeMonReviewApp.Models;

namespace PokeMonReviewApp.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int Id);

        Country GetCountryByOwnerId(int OwnerId);
        ICollection<Owner> GetOwnersFromACountry(int countryId);

        bool CountryExists(int Id);
        bool CreateCountry(Country country);
        bool UpdateCountry(Country country);
        bool DeleteCountry(Country country);
        bool Save();
    }
}
