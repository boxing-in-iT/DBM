using System;
using DBM.DAL.Entities;
using DBM.DAL.Interfaces.Repositories;

namespace DBM.DAL.Data.Repositories
{
	public class PhotoRepository : GenericRepository<Photo>, IPhotoRepository
	{
		public async Task InsertArrayAsync(int count, List<Photo> photo)
        {

        }

		public PhotoRepository(AppDbContext dbContext) : base(dbContext)
		{
		}
	}
}

