
using PokeMonReviewApp.Data;
using PokeMonReviewApp.Interfaces;
using PokeMonReviewApp.Models;

namespace PokeMonReviewApp.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly DataContext _context;

        public CountryRepository(DataContext context)
        {
            _context = context;

        }
        public bool CountryExists(int Id)
        {
            return _context.Countries.Any(c => c.Id == Id);
        }

        public ICollection<Country> GetCountries()
        {
            return _context.Countries.ToList();
        }

        public Country GetCountry(int Id)
        {
            return _context.Countries.Where(c => c.Id == Id).FirstOrDefault();
        }

        public Country GetCountryByOwnerId(int OwnerId)
        {
            return _context.Owners.Where(o => o.Id == OwnerId).Select(c => c.Country).FirstOrDefault();
        }

        public ICollection<Owner> GetOwnersFromACountry(int countryId)
        {
            return _context.Owners.Where(c => c.Country.Id == countryId).ToList();
        }
    }
}
