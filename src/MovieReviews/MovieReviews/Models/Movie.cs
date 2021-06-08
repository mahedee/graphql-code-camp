﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieReviews.Models
{
    public class Movie
    {
        public IList<Review> Reviews { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }

        public void AddReview(Review review)
        {
            Reviews.Add(review);
        }
    }
}
