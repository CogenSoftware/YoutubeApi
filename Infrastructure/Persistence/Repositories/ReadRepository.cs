using System.Linq.Expressions;
using Core.Application.Interfaces.Repositories;
using Core.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Infrastructure.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : class, IEntityBase, new()
    {
        private readonly DbContext _dbContext;

        public ReadRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private DbSet<T> table => _dbContext.Set<T>();

        public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            bool enableTracking = false)
        {
            IQueryable<T> query = table;

            if (!enableTracking)
                query = query.AsNoTracking();

            if (predicate != null)
                query = query.Where(predicate);

            if (include != null)
                query = include(query);

            if (orderBy != null)
                return await orderBy(query).ToListAsync();

            return await query.ToListAsync();
        }

        public async Task<IList<T>> GetAllByPagingAsync(Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            bool enableTracking = false,
            int currentPage = 1,
            int pageSize = 3)
        {
            IQueryable<T> query = table;

            if (!enableTracking)
                query = query.AsNoTracking();

            if (predicate != null)
                query = query.Where(predicate);

            if (include != null)
                query = include(query);

            if (orderBy != null)
                query = orderBy(query);

            return await query.Skip((currentPage - 1) * pageSize).Take(pageSize).ToListAsync();
        }

        public async Task<IList<T>> GetAsync(Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            bool enableTracking = false)
        {
            IQueryable<T> query = table;

            if (!enableTracking)
                query = query.AsNoTracking();

            if (predicate != null)
                query = query.Where(predicate);

            if (include != null)
                query = include(query);

            return await query.ToListAsync();
        }

        public IQueryable<T> Find(Expression<Func<T, bool>>? predicate = null)
        {
            IQueryable<T> query = table;

            if (predicate != null)
                query = query.Where(predicate);

            return query;
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null)
        {
            IQueryable<T> query = table;

            if (predicate != null)
                query = query.Where(predicate);

            return await query.CountAsync();
        }
    }
}