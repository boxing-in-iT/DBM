using System;
using DBM.DAL.Interfaces.Repositories;

namespace DBM.DAL.Interfaces
{
	public interface IUnitOfWork
	{
		IMovieRepository MovieRepository { get; }
		IPhotoRepository PhotoRepository { get; }
		Task SaveChangesAsync();
	}
}

