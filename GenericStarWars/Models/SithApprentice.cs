namespace GenericStarWars.Models
{
    public class SithApprentice : SithMarauder
    {
        public override string ToString()
        {
            return $"Id:{Id}, Name: {Name}, Age: {Age}, Title: Apprentice";
        }
    }
}
