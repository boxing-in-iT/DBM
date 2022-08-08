using System;
using DBM.DAL.Entities;

namespace DBM.DAL.Interfaces.Repositories
{
	public interface IPhotoRepository : IRepository<Photo>
	{
		Task InsertArrayAsync(int count, List<Photo> photo);
	}
}

