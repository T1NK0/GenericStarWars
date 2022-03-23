using GenericStarWars.Models;

namespace GenericStarWars
{
    public class JediKnight : JediMaster
    {
        public override string ToString()
        {
            return $"Id:{Id}, Name: {Name}, Age: {Age}, Title: Jedi Knight.";
        }
    }
}
