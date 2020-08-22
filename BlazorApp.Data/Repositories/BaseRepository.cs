using BlazorApp.Data.Interfaces;
using BlazorApp.Model.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : EntityBase
    {
        protected readonly ApplicationDbContext _dbContext;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task AddOrUpdateAsync(TEntity entity)
        {
            var existingEntity = await _dbContext.Set<TEntity>().FindAsync(entity.Id);

            if (existingEntity == null)
            {
                _dbContext.Add(entity);
            }
            else
            {
                _dbContext.Entry(existingEntity).CurrentValues.SetValues(entity);
            }

            await _dbContext.SaveChangesAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(Guid id) => await _dbContext.Set<TEntity>().FindAsync(id);

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync() => await _dbContext.Set<TEntity>().ToListAsync();
    }
}
