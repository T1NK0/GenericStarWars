using GenericStarWars.Models;
using System.Collections.Generic;
using System.Linq;

namespace GenericStarWars.Repository
{
    public class ListRepository<T> : IRepository<T> where T : class, IForceUser
    {
        private readonly List<T> _list;

        public ListRepository()
        {
            _list = new List<T>();
        }

        public void Add(T item)
        {
            _list.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            //Returns a copy of the list
            return _list.ToList();
        }

        public T GetById(int id)
        {
            return _list.Find(x => x.Id == id);
        }

        public void Remove(T item)
        {
            _list.Remove(item);
        }

        public void save(T item)
        {
            for (int i = 0; i < _list.Count; i++)
            {
                System.Console.WriteLine(item);
            }
        }

        public void Update(T item)
        {
            throw new System.NotImplementedException();
        }
    }
}
