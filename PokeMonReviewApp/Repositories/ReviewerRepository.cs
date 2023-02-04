using Microsoft.EntityFrameworkCore;
using PokeMonReviewApp.Data;
using PokeMonReviewApp.Interfaces;
using PokeMonReviewApp.Models;

namespace PokeMonReviewApp.Repositories
{
    public class ReviewerRepository : IReviewerRepository
    {
        private readonly DataContext _dataContext;

        public ReviewerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public Reviewer GetReviewer(int reviewerid)
        {
            return _dataContext.Reviewers.Where(r => r.Id == reviewerid).Include(e => e.Reviews).FirstOrDefault();
        }

        public ICollection<Reviewer> GetReviewers()
        {
            return _dataContext.Reviewers.ToList();
        }

        public ICollection<Review> GetReviewsByReviewer(int reviewId)
        {
            return _dataContext.Reviews.Where(r=>r.Reviewer.Id == reviewId).ToList();
        }

        public bool ReviewerExists(int reviewId)
        {
            return _dataContext.Reviewers.Any(r => r.Id == reviewId);
        }
    }
}
