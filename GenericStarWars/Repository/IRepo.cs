using GenericStarWars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStarWars.Repository
{
    //Sets what we allow the repo to be (our constraints). Allows the IRepo to be type of IForceUser.
    public interface IRepo<T> where T : IForceUser
    {
        IEnumerable<T> GetAll();
        T GetById(int id);

        void Add(T item);
        void Remove(T item);
        void Update(T item);
        void save(T item);
    }
}
