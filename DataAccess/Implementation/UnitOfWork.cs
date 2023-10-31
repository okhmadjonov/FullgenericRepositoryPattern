using DataAccess.Context;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Actor = new ActorRepository(_context);
            Movie = new MovieRepository(_context);
            Genre = new GenreRepository(_context);
            Biography = new BiographyRepository(_context);
        }

        public IActorRepository Actor { get; private set; }
        public IMovieRepository Movie { get; private  set; }
        public IBiographyRepository Biography { get; private set; }
        public IGenreRepository Genre { get; private set; }

        public int Save() {

            return _context.SaveChanges();
        }

        public void Dispose() { 
        
            _context.Dispose(); 
        
        }
    }
}
