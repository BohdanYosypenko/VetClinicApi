using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace VetClinic.DAL.Repositories.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task<ICollection<TEntity>> GetAsync(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            int? pageNumber = null, int? pageSize = null,
            bool asNoTracking = false);

        Task<TEntity> GetFirstOrDefaultAsync(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
            bool asNoTracking = false);

        void Add(TEntity entity);
        void Remove(TEntity entity);
        void Update(TEntity entity);
        Task<int> CountAsync(Expression<Func<TEntity, bool>> filter = null);
        Task<bool> IsAnyAsync(Expression<Func<TEntity, bool>> filter = null);
    }
}