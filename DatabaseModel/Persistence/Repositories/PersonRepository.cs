using DatabaseModel.DataContext;
using DatabaseModel.Models;
using DatabaseModel.RepositoryPattern.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseModel.Persistence.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(DatabaseContext context) : base(context)
        {
        }

        public Person GetPersonWithAddress(int id)
        {
            return DatabaseContext.Person.Include(p => p.Addresses).SingleOrDefault(a => a.Id == id);
        }

        public Person GetLastPersonWithAddress()
        {
            return DatabaseContext.Person.OrderByDescending(p => p.Id).Include(p => p.Addresses).Take(1).SingleOrDefault();
        }

        public DatabaseContext DatabaseContext
        {
            get { return Context as DatabaseContext; }
        }
    }
}
