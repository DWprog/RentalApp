using RentalApp.Equipments;
using RentalApp.Repositories;
using System;

namespace RentalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, Rental Company here!\n");


            var listRepository = new ListRepository<IEquipment>();

            listRepository.Add(new Tool { Name = "Młotek", Price = 2.50 });
            listRepository.Add(new Tool { Name = "Łopata", Price = 7 });
            listRepository.Add(new PowerTool { Name = "Szlifierka kątowa", Price = 11, Power = 700 });
            listRepository.Add(new Devoice { Name = "Agregat prądotwórczy", Weight = 250 });
            WriteAllToConsole(listRepository);

            listRepository.Remove(listRepository.GetById(2));
            listRepository.Add(new Devoice { Name = "Betoniarka", Weight = 150 });
            WriteAllToConsole(listRepository);

            listRepository.Add(new PowerTool { Name = "Spawarka", Price=15, Power = 1800 });
            listRepository.Remove(listRepository.GetById(3));
            listRepository.Add(new Devoice { Name = "Kompresor", Weight = 500 });
            WriteAllToConsole(listRepository);

            
        }

        static void WriteAllToConsole(IRepository<IEquipment> rpository)
        {
            var items = rpository.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

    }
}
