using DataAccess.Context;
using Domain.Entities;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implementation
{
    public class BiographyRepository :GenericRepository<Biography>, IBiographyRepository
    {
        public BiographyRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
