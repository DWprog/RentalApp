using RentalApp.Equipments;
using System;
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
            item.Id = _items.Count == 0 ? 1 : _items.Max(item => item.Id) + 1;
            _items.Add(item);
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public T GetById(int id)
        {
            if (_items.Exists(x => x.Id == id))
            {
                return _items.Single(item => item.Id == id);
            }
            else
            {
                Console.WriteLine("The item does not exist");
                return null;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _items.ToList();
        }

        public void Save()
        {
            //save is not required with list
        }
    }
}
