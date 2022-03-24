namespace GenericStarWars.Models
{
    public class SithMaster : Sith
    {
        public override string ToString()
        {
            return $"Id:{Id}, Name: {Name}, Age: {Age}, Title: Master";
        }
    }
}
