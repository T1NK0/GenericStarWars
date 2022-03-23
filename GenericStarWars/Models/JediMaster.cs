using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStarWars.Models
{
    public class JediMaster : ForceUserBase
    {
        public override string ToString()
        {
            return $"Id:{Id}, Name: {Name}, Age: {Age}, Title: Jedi Master.";
        }
    }
}
