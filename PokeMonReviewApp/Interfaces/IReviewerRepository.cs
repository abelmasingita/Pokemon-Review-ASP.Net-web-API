using PokeMonReviewApp.Models;

namespace PokeMonReviewApp.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int reviewerid);
        ICollection<Review> GetReviewsByReviewer(int reviewId);
        bool ReviewerExists(int reviewId);
    }
}
