namespace GenericStarWars.Models
{
    public class JediYoungling : JediPadawan
    {
        public override string ToString()
        {
            return $"Id:{Id}, Name: {Name}, Age: {Age}, Title: Jedi Youngling.";
        }
    }
}
