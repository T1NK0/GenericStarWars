using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStarWars.Models
{
    public class Jedi : IForceUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Title { get; set; }
        public int LivesSaved { get; set; }
        public override string ToString()
        {
            return $"Id:{Id}, Name: {Name}, Age: {Age}, Title: {Title}, Lives saved: {LivesSaved}";
        }
    }
}
