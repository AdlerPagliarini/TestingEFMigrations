using DatabaseModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseModel.RepositoryPattern.Repositories
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person GetPersonWithAddress(int id);
        Person GetLastPersonWithAddress();
    }
}
