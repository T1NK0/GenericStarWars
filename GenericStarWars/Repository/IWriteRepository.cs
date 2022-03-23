namespace GenericStarWars.Repository
{
    /// <summary>
    /// Uses the in keyword, to make the parameter to a controvariant.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IWriteRepository<in T>
    {
        void Add(T item);
        void Remove(T item);
        void Update(T item);
        void save(T item);
    }
}
