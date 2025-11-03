using LibraryManagementSystem.DataAccess.Abstract;
using LibraryManagementSystem.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LibraryManagementSystem.DataAccess.Concrete.EntityFramework
{
    public class EfRepositoryBase<T> : IRepository<T> where T : class
    {
        public void Add(T entity)
        {
            using var context = new LibraryContextFactory().CreateDbContext(null);
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            using var context = new LibraryContextFactory().CreateDbContext(null);
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            using var context = new LibraryContextFactory().CreateDbContext(null);
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using var context = new LibraryContextFactory().CreateDbContext(null);
            return context.Set<T>().FirstOrDefault(filter);
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using var context = new LibraryContextFactory().CreateDbContext(null);
            return filter == null
                ? context.Set<T>().ToList()
                : context.Set<T>().Where(filter).ToList();
        }
    }
}
