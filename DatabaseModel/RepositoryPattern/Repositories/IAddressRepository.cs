using DatabaseModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseModel.RepositoryPattern.Repositories
{
    public interface IAddressRepository : IRepository<Address>
    {
        IEnumerable<Address> GetHighAddressNumber(int count);
        IEnumerable<Address> GetAddressWithPerson(int pageIndex, int pageSize);
    }
}
