using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieReviews.Models
{
    public class Review
    {
        public int Id { get; set; }
        public Guid MovieId { get; set; }
        public string Reviewer { get; set; }
        public int Stars { get; set; }
    }
}
