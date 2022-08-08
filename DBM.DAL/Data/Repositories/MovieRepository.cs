using System;
using DBM.DAL.Entities;
using DBM.DAL.Interfaces.Repositories;

namespace DBM.DAL.Data.Repositories
{
	public class MovieRepository : GenericRepository<Movie>, IMovieRepository
	{
        public MovieRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
	}
}

