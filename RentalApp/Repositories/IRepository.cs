using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Repositories
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Save();
    }
}
