using PokeMonReviewApp.Models;

namespace PokeMonReviewApp.Dto
{
    public class ReviwerDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}
