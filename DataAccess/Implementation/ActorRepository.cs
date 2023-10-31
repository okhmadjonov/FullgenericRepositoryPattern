using DataAccess.Context;
using Domain.Entities;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implementation
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
       
        public ActorRepository(ApplicationDbContext context): base(context)
        {
          
        }

        public IEnumerable<Actor> GetActorWithMovies()
        {
            var actorsWithMovies =  _context.Actors.Include(u=> u.Movies).ToList();
            return actorsWithMovies;
        }
    }
}
