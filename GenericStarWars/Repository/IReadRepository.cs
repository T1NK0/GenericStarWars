using System.Collections.Generic;

namespace GenericStarWars.Repository
{
    /// <summary>
    /// Uses the "out" keyword, to make the parameter to a covariant.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IReadRepository<out T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
