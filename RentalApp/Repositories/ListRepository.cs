using RentalApp.Equipments;
using System.Collections.Generic;
using System.Linq;

namespace RentalApp.Repositories
{
    public class ListRepository<T> : IRepository<T>
        where T : class, IEquipment
    {
        private readonly List<T> _items = new();

        public void Add(T item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public T GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _items.ToList();
        }
    }
}
