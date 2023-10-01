using Microsoft.EntityFrameworkCore;
using SocialMediaAnalyis.Repository.Contracts;
using System.Linq.Expressions;

namespace SocialMediaAnalyis.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext RepositoryContext;

        protected RepositoryBase(RepositoryContext repositoryContext) => RepositoryContext = repositoryContext;
        public void Create(T entity) => RepositoryContext.Set<T>().Add(entity);
        public void Delete(T entity) => RepositoryContext.Set<T>().Remove(entity);
        public void Update(T entity) => RepositoryContext.Set<T>().Update(entity);

        public void AddOrUpdate(T entity) => _ = !RepositoryContext.Set<T>().Any(e => e == entity) ? RepositoryContext.Set<T>().Add(entity) : RepositoryContext.Set<T>().Update(entity);
        public void RemoveAll(IEnumerable<T> entities) => RepositoryContext.Set<T>().RemoveRange(entities);
        public void AddAll(IEnumerable<T> entities) => RepositoryContext.Set<T>().AddRange(entities);
        public bool Any(Expression<Func<T, bool>> expression) => RepositoryContext.Set<T>().Any(expression);


        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ?
            RepositoryContext.Set<T>().AsNoTracking() :
            RepositoryContext.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges ?
            RepositoryContext.Set<T>().Where(expression).AsNoTracking() :
            RepositoryContext.Set<T>().Where(expression);

    }
}
