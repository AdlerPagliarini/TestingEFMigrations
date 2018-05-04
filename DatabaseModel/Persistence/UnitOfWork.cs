using DatabaseModel.DataContext;
using DatabaseModel.Persistence.Repositories;
using DatabaseModel.RepositoryPattern;
using DatabaseModel.RepositoryPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseModel.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
            Person = new PersonRepository(_context);
            Address = new AddressRepository(_context);
        }

        public IPersonRepository Person { get; private set; }
        public IAddressRepository Address { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
