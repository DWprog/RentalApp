using Microsoft.EntityFrameworkCore;
using RentalApp.Equipments;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RentalApp.Repositories
{
    public class SqlRepository<T> : IRepository<T>
        where T : class, IEquipment, new()
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public SqlRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
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
            return _dbSet.Find(id);
        }

        public void Remove(T item)
        {
            if (item != null)
            {
                _dbSet.Remove(item);
            }
            else
            {
                Console.WriteLine("Such an item does not exist");
            }
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
