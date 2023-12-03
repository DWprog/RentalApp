using RentalApp.Equipments;

namespace RentalApp.Repositories
{
    public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T>
        where T : class, IEquipment
    {
    }
}
