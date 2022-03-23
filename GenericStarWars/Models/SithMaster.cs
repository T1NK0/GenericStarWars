namespace GenericStarWars.Models
{
    public class SithMaster : ForceUserBase
    {
        public override string ToString()
        {
            return $"Id:{Id}, Name: {Name}, Age: {Age}, Title: Master";
        }
    }
}
