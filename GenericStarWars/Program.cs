using GenericStarWars.Models;
using System;
using System.Collections.Generic;

namespace GenericStarWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IForceUser> list = new List<IForceUser>();
            list.Add(new Sith { Id = 1, Name = "Maul", Age = 26, Title = "Darth", Killstreak = 428 });
            list.Add(new Jedi { Id = 1, Name = "Maul", Age = 26, Title = "Darth", LivesSaved = 22 });

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
