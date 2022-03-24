using GenericStarWars.Data;
using GenericStarWars.Models;
using GenericStarWars.Repository;
using System;
using System.Collections.Generic;

namespace GenericStarWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericsOrdinaryList();

            GenericsDbContext();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        private static void GenericsDbContext()
        {
            var repo = new Repository<JediMaster>(new StarWarsDbContext());
            repo.Add(new JediMaster { Id = 1, Name = "Vader", Age = 23 });
        }

        private static void GenericsOrdinaryList()
        {
            //is not acceptable, because we can't put a JediMaster in a JediPadawan.
            //List<JediPadawan> jedi = new List<JediPadawan>();

            Console.WriteLine("_-`´-_ ORDINARY LIST _-`´-_");

            List<Jedi> jedi = new List<Jedi>();
            jedi.Add(new JediMaster { Name = "Obi-Wan Kenobi", Age = 40 });
            jedi.Add(new JediMaster { Name = "Yoda", Age = 800 });
            jedi.Add(new JediKnight { Name = "Anakin Skywalker", Age = 20 });
            jedi.Add(new JediPadawan { Name = "Ashoka Tano", Age = 40 });
            jedi.Add(new JediYoungling { Name = "Lars", Age = 6 });

            List<Sith> sith = new List<Sith>();
            sith.Add(new SithMaster { Name = "Vader", Age = 54 });
            sith.Add(new SithMarauder { Name = "Malgus", Age = 23 });
            sith.Add(new SithApprentice { Name = "Maul", Age = 17 });

            foreach (var item in jedi)
            {
                Console.WriteLine(item);
            }

            foreach (var item in sith)
            {
                Console.WriteLine(item);
            }

        }
    }
}
