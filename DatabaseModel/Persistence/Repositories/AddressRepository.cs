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
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(DatabaseContext context) : base(context)
        {
        }

        public IEnumerable<Address> GetHighAddressNumber(int count)
        {
            return DatabaseContext.Address.OrderByDescending(e => e.Number).Take(count).ToList();
        }

        public IEnumerable<Address> GetAddressWithPerson(int pageIndex, int pageSize)
        {
            return DatabaseContext.Address
                .Include(c => c.Person)
                .OrderBy(c => c.Street)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public DatabaseContext DatabaseContext
        {
            get { return Context as DatabaseContext; }
        }
    }
}
