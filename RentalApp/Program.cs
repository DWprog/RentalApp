using RentalApp.Data;
using RentalApp.Equipments;
using RentalApp.Repositories;
using System;

namespace RentalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new RentalAppDbContext();
            var toolRepository = new SqlRepository<Tool>(dbContext);
            var devoiceRepository = new SqlRepository<Devoice>(dbContext);
            var toolAndDevoiceRepository = new SqlRepository<EquipmentBase>(dbContext);

            AddTools(toolRepository);
            WriteAllToConsole(toolRepository);

            AddPowerTools(toolRepository);
            WriteAllToConsole(toolRepository);

            AddDevoices(devoiceRepository);
            WriteAllToConsole(devoiceRepository);
        }

        static void AddTools(IWriteRepository<Tool> toolRepository)
        {
            toolRepository.Add(new Tool { Name = "Młotek" });
            toolRepository.Add(new Tool { Name = "Łopata" });
            toolRepository.Save();
        }
        static void AddPowerTools(IWriteRepository<Tool> toolRepository)
        {
            toolRepository.Add(new PowerTool { Name = "Wiertarka", Power = 700 });
            toolRepository.Add(new PowerTool { Name = "Szlifierka", Power = 500 });
            toolRepository.Save();
        }

        static void AddDevoices(IWriteRepository<Devoice> toolRepository)
        {
            toolRepository.Add(new Devoice { Name = "Kompresor", Weight = 150 });
            toolRepository.Add(new Devoice { Name = "Betoniarka", Weight = 250 });
            toolRepository.Save();
        }

        static void WriteAllToConsole(IReadRepository<IEquipment> repository)
        {
            var items = repository.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

    }
}
