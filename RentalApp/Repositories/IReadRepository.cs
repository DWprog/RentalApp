using RentalApp.Equipments;
using System.Collections.Generic;

namespace RentalApp.Repositories
{
    public interface IReadRepository<out T>
        where T : class, IEquipment
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
