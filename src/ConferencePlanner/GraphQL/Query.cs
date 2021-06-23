using GraphQL.Data;
using GraphQL.Extensions;
using HotChocolate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL
{
    public class Query
    {
        [UseApplicationDbContext]
        public Task<List<Speaker>> GetSpeakers([ScopedService] ApplicationDbContext context) => context.Speakers.ToListAsync();
        //public IQueryable<Speaker> GetSpeakers([Service] ApplicationDbContext context) => context.Speakers; 
    }
}
