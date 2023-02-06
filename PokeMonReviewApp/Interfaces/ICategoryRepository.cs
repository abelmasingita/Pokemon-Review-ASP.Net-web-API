using PokeMonReviewApp.Models;

namespace PokeMonReviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();

        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonByCategoryId(int categoryId);
        bool CategoryExists(int Id);
        bool CreateCategory(Category category);
        bool Save();

    }
}
