using GenericStarWars.Models;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStarWars.Repository
{
    //Sets what we allow the repo to be (our constraints). Allows the IRepo to be type of IForceUser.
    public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T> where T : IForceUser
    {
    }
}
