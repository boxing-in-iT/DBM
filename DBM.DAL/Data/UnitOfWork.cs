using System;
using DBM.DAL.Interfaces;
using DBM.DAL.Interfaces.Repositories;

namespace DBM.DAL.Data
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly AppDbContext _appDbContext;

        public IMovieRepository MovieRepository { get; }
		public IPhotoRepository PhotoRepository { get; }

		public async Task SaveChangesAsync()
        {
			await _appDbContext.SaveChangesAsync();
        }

		public UnitOfWork(
			AppDbContext appDbContext,
			IMovieRepository movieRepository,
			IPhotoRepository photoRepository)
		{
			_appDbContext = appDbContext;
			MovieRepository = movieRepository;
			PhotoRepository = photoRepository;
		}
	}
}

