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
            var toolRepository = new SqlRepository<Tool>(new RentalAppDbContext());

            toolRepository.Add(new Tool { Name = "Młotek" });
            toolRepository.Add(new Tool { Name = "Łopata" });
            toolRepository.Add(new PowerTool { Name = "Wiertarka", Power = 700 });
            toolRepository.Save();
            WriteAllToolsToConsole(toolRepository);

            toolRepository.Add(new Tool { Name = "Przecinak" });
            toolRepository.Add(new Tool { Name = "Poziomica" });
            toolRepository.Save();
            WriteAllToolsToConsole(toolRepository);

            toolRepository.Add(new Tool { Name = "Kielnia" });
            toolRepository.Add(new Tool { Name = "Paca" });
            toolRepository.Save();
            WriteAllToolsToConsole(toolRepository);


            Console.WriteLine("Usuwam ID=5");
            toolRepository.Remove(toolRepository.GetById(5));
            toolRepository.Save();
            WriteAllToolsToConsole(toolRepository);

            Console.WriteLine("Usuwam ID=5");
            toolRepository.Remove(toolRepository.GetById(5));
            toolRepository.Save();
            WriteAllToolsToConsole(toolRepository);




            //toolRepository.Add(new Devoice { Name = "Kompresor", Weight = 250 });


            //var listRepository = new ListRepository<IEquipment>();

            //listRepository.Add(new Tool { Name = "Młotek"});
            //listRepository.Add(new Tool { Name = "Łopata"});
            //listRepository.Add(new PowerTool { Name = "Szlifierka kątowa", Power = 700 });
            //listRepository.Add(new Devoice { Name = "Agregat prądotwórczy", Weight = 250 });
            //WriteAllToConsole(listRepository);

            //listRepository.Remove(listRepository.GetById(3));
            //listRepository.Add(new Devoice { Name = "Betoniarka", Weight = 150 });
            //WriteAllToConsole(listRepository);



            //listRepository.Add(new PowerTool { Name = "Spawarka", Power = 1800 });
            //listRepository.Remove(listRepository.GetById(3));
            //listRepository.Add(new Devoice { Name = "Kompresor", Weight = 500 });
            //WriteAllToConsole(listRepository);

            //-----------------
            //listRepository.Add(new PowerTool { Name = "Spawarka", Price = 15, Power = 1800 });
            //try
            //{
            //    listRepository.Remove(listRepository.GetById(3));
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"{e.Message}");
            //}
            //listRepository.Add(new Devoice { Name = "Kompresor", Weight = 500 });
            //WriteAllToConsole(listRepository);
        }

        static void WriteAllToolsToConsole(SqlRepository<Tool> repository)
        {
            var items = repository.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void WriteAllToConsole(IRepository<IEquipment> repository)
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
