using DatabaseModel.RepositoryPattern.Repositories;
using System;

namespace DatabaseModel.RepositoryPattern
{
    public interface IUnitOfWork : IDisposable
    {
        IAddressRepository Address { get; }
        IPersonRepository Person   { get; }
        int Complete();
    }
}
