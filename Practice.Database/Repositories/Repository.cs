using Practice.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Practice.Database.Repositories
{
    /// <summary>Generic Repository</summary>
    /// <typeparam name="C"></typeparam>
    /// <typeparam name="T"></typeparam>
    public abstract class Repository<C, T> : IDisposable, IRepository<T>
        where T : class
        where C : DbContext, new()
    {

        private C _entities = new C();
        public C Context
        {

            get { return _entities; }
            set { _entities = value; }
        }

        /// <summary>Gets all.</summary>
        /// <returns>Query</returns>
        public virtual IQueryable<T> GetAll() => _entities.Set<T>();

        /// <summary>Finds the by.</summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns>Query</returns>
        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate) => _entities.Set<T>().Where(predicate);

        /// <summary>Adds the specified entity.</summary>
        /// <param name="entity">The entity.</param>
        public virtual void Add(T entity) => _entities.Set<T>().Add(entity);

        /// <summary>Deletes the specified entity.</summary>
        /// <param name="entity">The entity.</param>
        public virtual void Delete(T entity) => _entities.Set<T>().Remove(entity);

        /// <summary>Edits the specified entity.</summary>
        /// <param name="entity">The entity.</param>
        public virtual void Edit(T entity) => _entities.Entry(entity).State = EntityState.Modified;

        /// <summary>Saves this instance.</summary>
        public virtual void Save() => _entities.SaveChanges();

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        public void Dispose() => _entities?.Dispose();
    }
}
