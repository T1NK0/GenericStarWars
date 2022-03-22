using GenericStarWars.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStarWars.Repository
{
    public class Repo<T> : IRepo<T> where T : class, IForceUser
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public Repo(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public void Add(T item)
        {
            _dbSet.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return (T)_dbSet.Find(id);
        }

        public void Remove(T item)
        {_dbSet.Remove(item);
        }

        public void save(T item)
        {
            _dbContext.SaveChanges();
        }

        public void Update(T item)
        {
            _dbSet.Update(item);
        }
    }
}
