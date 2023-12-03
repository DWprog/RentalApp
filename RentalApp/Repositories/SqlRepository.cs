﻿using Microsoft.EntityFrameworkCore;
using RentalApp.Equipments;
using System.Collections.Generic;
using System.Linq;

namespace RentalApp.Repositories
{
    public class SqlRepository<T> : IRepository<T>
        where T : class, IEquipment
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
            _dbSet.Remove(item);
        }
    }
}
