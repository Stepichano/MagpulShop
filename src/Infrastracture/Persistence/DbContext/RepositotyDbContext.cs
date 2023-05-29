using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagpulShop.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Magpul.Persistence._dbContext
{
    public class RepositoryDbContext<T> : DbContext, IRepositoryDbContext<T> where T : class, new()
    {
        private readonly DbSet<T> _dbSet;

        RepositoryDbContext()
        {
            _dbSet = this.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            // надо почитать 
            _dbSet.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
           T entity = _dbSet.Find(id);
            if (entity != null)
                _dbSet.Remove(entity);
        }

        public void SaveChanges()
        {
            this.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
