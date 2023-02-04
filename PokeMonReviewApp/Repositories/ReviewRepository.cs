﻿using AutoMapper;
using PokeMonReviewApp.Data;
using PokeMonReviewApp.Interfaces;
using PokeMonReviewApp.Models;

namespace PokeMonReviewApp.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly DataContext _dataContext;


        public ReviewRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
      
        }
        public Review GetReview(int reviewId)
        {
            return _dataContext.Reviews.Where(r => r.Id == reviewId).FirstOrDefault();
        }

        public ICollection<Review> GetReviews()
        {
            return _dataContext.Reviews.ToList();
        }

        public ICollection<Review> GetReviewsOfAPokemon(int pokeId)
        {
            return _dataContext.Reviews.Where(r => r.Pokemon.Id == pokeId).ToList();
        }

        public bool ReviewExists(int reviewId)
        {
            return _dataContext.Reviews.Any(r => r.Id == reviewId);
        }
    }
}