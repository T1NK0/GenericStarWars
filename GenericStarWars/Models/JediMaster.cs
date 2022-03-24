namespace GenericStarWars.Models
{
    public class JediMaster : Jedi
    {
        public override string ToString()
        {
            return $"Id:{Id}, Name: {Name}, Age: {Age}, Title: Jedi Master.";
        }
    }
}
