using System;
using DBM.BLL.DTO.Requests;
using DBM.BLL.DTO.Responces;

namespace DBM.BLL.Interfaces.Services
{
	public interface IMovieService
	{
		Task<IEnumerable<MovieShortResponce>> GetAsync();
		Task<MovieResponce> GetById(int id);
		Task InsertAsync(MovieRequest movieRequest);
		Task UpdateAsync(MovieRequest movieRequest);
		Task DeleteAsync(int id);
	}
}

