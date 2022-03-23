namespace GenericStarWars.Models
{
    public class JediPadawan : JediKnight
    {
        public override string ToString()
        {
            return $"Id:{Id}, Name: {Name}, Age: {Age}, Title: Jedi Padawan.";
        }
    }
}
