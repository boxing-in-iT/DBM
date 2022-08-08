using System;
namespace DBM.DAL.Interfaces.Repositories
{
	public interface IRepository<TEntity> where TEntity : class
	{
		Task<IEnumerable<TEntity>> GetAsync();
		Task<TEntity> GetByIdAsync(int id);
		Task InsertAsync(TEntity entity);
		Task UpdateAsync(TEntity entity);
		Task DeleteAsync(int id);
	}
}

