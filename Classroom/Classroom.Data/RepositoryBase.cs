using Classroom.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;
using Classroom.Data.Entities;

namespace Classroom.Data
{

    public abstract class RepositoryBase<TEntity, TKey> : IRepository<TEntity, TKey>, IDisposable
        where TEntity : EntityBase<TKey>
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;
        private bool _dispossed;

        public RepositoryBase(DbContext dbContext)
        {
            _dbContext = dbContext;
            //dbsetini dönderiyor
            _dbSet = _dbContext.Set<TEntity>();
        }
        #region IRepository members
        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            SaveChangeAsync();
        }

        public async void Delete(TKey id)
        {
            var entity = await GetAsync(id);

            Delete(entity);
        }

        public void Delete(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Deleted;
        }



        public IQueryable<TEntity> GetAll(int skip, int take)
        {
            return _dbSet.OrderBy(x => x.Id).Skip(skip).Take(take);
        }

        public IQueryable<TEntity> GetAll(int skip, int take, Expression<Func<TEntity, bool>> predicate)
        {
            return GetAll(skip, take).Where(predicate);
        }

        public Task<TEntity> GetAsync(TKey id)
        {
            return _dbSet.FindAsync(id);
        }

        public Task SaveChangeAsync()
        {
            return _dbContext.SaveChangesAsync();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
        #endregion
        #region IDispossible members
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing && !_dispossed)
            {
                _dbContext.Dispose();
            }

        }

        public IQueryable<TEntity> Include(params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = null; if (includes.Length > 0) { query = _dbSet.Include(includes[0]); }
            for (int queryIndex = 1; queryIndex < includes.Length; ++queryIndex) { query = query.Include(includes[queryIndex]); }
            return query == null ? _dbSet : (IQueryable<TEntity>)query;
        }

        ~RepositoryBase()
        {
            Dispose(false);
        }
        #endregion
    }
}
