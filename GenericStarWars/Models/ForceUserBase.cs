namespace GenericStarWars.Models
{
    /// <summary>
    /// We make the base abstract, so we can't make a template from the ForceUserBase, and therefor we need to use the jedis or sith templates.
    /// </summary>
    public abstract class ForceUserBase : IForceUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public abstract override string ToString();
    }
}
