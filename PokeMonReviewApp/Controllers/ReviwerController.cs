﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokeMonReviewApp.Dto;
using PokeMonReviewApp.Interfaces;
using PokeMonReviewApp.Models;
using PokeMonReviewApp.Repositories;

namespace PokeMonReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviwerController : Controller
    {
        private readonly IReviewerRepository _reviewerRepository;
        private readonly IMapper _mapper;

        public ReviwerController(IReviewerRepository reviewerRepository, IMapper mapper)
        {
            _reviewerRepository = reviewerRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Reviewer>))]
        public IActionResult GetReviewers()
        {
            var reviewers = _mapper.Map<List<ReviwerDto>>(_reviewerRepository.GetReviewers());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(reviewers);
        }


        [HttpGet("reviewerId")]
        [ProducesResponseType(200, Type = typeof(Reviewer))]
        [ProducesResponseType(400)]
        public IActionResult GetReviewer(int reviwerId)
        {
            if (!_reviewerRepository.ReviewerExists(reviwerId))
            {
                return NotFound();
            }

            var reviwer = _mapper.Map<ReviwerDto>(_reviewerRepository.GetReviewer(reviwerId));
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(reviwer);
        }

        [HttpGet("{reviewerId}/reviews")]
        public IActionResult GetReviewsByAReviwer(int reviwerId)
        {
            if (!_reviewerRepository.ReviewerExists(reviwerId))
            {
                return NotFound();
            }

            var reviews = _mapper.Map<List<ReviwerDto>>(_reviewerRepository.GetReviewsByReviewer(reviwerId));

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(reviews);
        }

    }
}
