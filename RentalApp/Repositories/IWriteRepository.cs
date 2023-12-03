using RentalApp.Equipments;

namespace RentalApp.Repositories
{
    public interface IWriteRepository<in T>
        where T : class, IEquipment
    {
        void Add(T item);
        void Remove(T item);
        void Save();
    }
}
