using System;
using AutoMapper;
using DBM.BLL.DTO.Requests;
using DBM.BLL.DTO.Responces;
using DBM.BLL.Interfaces.Services;
using DBM.DAL.Entities;
using DBM.DAL.Interfaces;
using DBM.DAL.Interfaces.Repositories;

namespace DBM.BLL.Services
{
	public class MovieService : IMovieService
	{
		private readonly IUnitOfWork unitOfWork;

		private readonly IMapper mapper;

		private readonly IMovieRepository movieRepository;

		public async Task<IEnumerable<MovieShortResponce>> GetAsync()
        {
			var movies = await movieRepository.GetAsync();
			return movies?.Select(mapper.Map<Movie, MovieShortResponce>);
        }

		public async Task<MovieResponce> GetById(int id)
        {
			var movie = await movieRepository.GetByIdAsync(id);
			return mapper.Map<Movie, MovieResponce>(movie);
        }

		public async Task InsertAsync(MovieRequest movieRequest)
        {
			var movie = mapper.Map<MovieRequest, Movie>(movieRequest);
			await movieRepository.InsertAsync(movie);
			await unitOfWork.SaveChangesAsync();
        }

		public async Task UpdateAsync(MovieRequest movieRequest)
        {
			var movie = mapper.Map<MovieRequest, Movie>(movieRequest);
			await movieRepository.UpdateAsync(movie);
			await unitOfWork.SaveChangesAsync();
        }

		public async Task DeleteAsync(int id)
        {
			await movieRepository.DeleteAsync(id);
			await unitOfWork.SaveChangesAsync();
        }

        public MovieService(IUnitOfWork unitOfWork, IMapper mapper)
        {
			this.unitOfWork = unitOfWork;
			this.mapper = mapper;
			movieRepository = this.unitOfWork.MovieRepository;
		}
	}
}

