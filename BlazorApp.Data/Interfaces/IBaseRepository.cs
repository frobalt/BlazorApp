using Shared.Model.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Data.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : EntityBase
    {
        Task AddOrUpdateAsync(TEntity entity);
        Task<TEntity> GetByIdAsync(Guid id);
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
