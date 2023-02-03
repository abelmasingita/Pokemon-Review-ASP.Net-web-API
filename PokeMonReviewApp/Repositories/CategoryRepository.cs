using PokeMonReviewApp.Data;
using PokeMonReviewApp.Interfaces;
using PokeMonReviewApp.Models;

namespace PokeMonReviewApp.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context;
        }
        public bool CategoryExists(int Id)
        {
            return _context.Categories.Any(c => c.Id == Id);
        }

        public ICollection<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.Where(e => e.Id == id).FirstOrDefault();
        }

        public ICollection<Pokemon> GetPokemonByCategoryId(int categoryId)
        {
            return _context.PokemonCategories.Where(e => e.CategoryId == categoryId).Select(c=> c.Pokemon).ToList();
        }
    }
}
