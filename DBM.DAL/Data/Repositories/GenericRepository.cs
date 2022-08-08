using System;
using DBM.DAL.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DBM.DAL.Data.Repositories
{
	public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
	{
		protected readonly AppDbContext dbContext;
		protected readonly DbSet<TEntity> table;

		public virtual async Task<IEnumerable<TEntity>> GetAsync() => await table.ToListAsync();

		public virtual async Task<TEntity> GetByIdAsync(int id)
        {
			return await table.FindAsync(id);
			// Exception!!@@@@@@@@@@@@@
        }

		public virtual async Task InsertAsync(TEntity entity) => await table.AddAsync(entity);

		public virtual async Task UpdateAsync(TEntity entity) =>
			await Task.Run(() => table.Update(entity));

		public virtual async Task DeleteAsync(int id)
        {
			var entity = await GetByIdAsync(id);
			await Task.Run(() => table.Remove(entity));
        }

        public GenericRepository(AppDbContext appDbContext)
        {
			dbContext = appDbContext;
			table = this.dbContext.Set<TEntity>();
        }

	}
}

