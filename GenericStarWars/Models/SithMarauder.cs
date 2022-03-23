namespace GenericStarWars.Models
{
    public class SithMarauder : SithMaster
    {
        public override string ToString()
        {
            return $"Id:{Id}, Name: {Name}, Age: {Age}, Title: Marauder";
        }
    }
}
