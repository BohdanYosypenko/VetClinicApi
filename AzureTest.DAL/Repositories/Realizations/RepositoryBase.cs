using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VetClinic.DAL.Repositories.Interfaces;

namespace VetClinic.DAL.Repositories.Realizations
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected ApplicationContext Context { get; }

        protected RepositoryBase(ApplicationContext context)
        {
            Context = context;
        }

        public async Task<ICollection<TEntity>> GetAsync(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            int? pageNumber = null, int? pageSize = null,
            bool asNoTracking = false)
        {
            IQueryable<TEntity> query = GetQuery(filter, include, asNoTracking);

            if (orderBy != null)
                query = orderBy(query);

            if (pageNumber != null && pageSize != null)
                query = query.Skip((pageNumber.Value - 1) * pageSize.Value).Take(pageSize.Value);

            return await query.ToListAsync();
        }

        public Task<TEntity> GetFirstOrDefaultAsync(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
            bool asNoTracking = false)
        {
            IQueryable<TEntity> query = GetQuery(filter, include, asNoTracking);
            return query.FirstOrDefaultAsync();
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void Update(TEntity entity)
        {
            Context.Set<TEntity>().Update(entity);
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter != null)
                return await Context.Set<TEntity>().Where(filter).CountAsync();

            return await Context.Set<TEntity>().CountAsync();
        }

        public async Task<bool> IsAnyAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> query = Context.Set<TEntity>();

            if (filter != null)
                query = query.Where(filter);

            return await query.AnyAsync();
        }

        private IQueryable<TEntity> GetQuery(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
            bool asNoTracking = false)
        {
            IQueryable<TEntity> query = Context.Set<TEntity>();

            if (asNoTracking)
                query = query.AsNoTracking();

            if (include != null)
                query = include(query);

            if (filter != null)
                query = query.Where(filter);

            return query;
        }
    }
}