using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using DatabaseModel.DataContext;
using DatabaseModel.Models;
using DatabaseModel.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatabaseModel.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        public class ReturnM
        {
            public IEnumerable<Person> Person { get; set; }
            public IEnumerable<Person> PersonIquery { get; set; }
            public IEnumerable<Person> PersonIqueryInclude { get; set; }
        }

        private readonly DatabaseContext _context;
        private ReturnM retornoVM;

        public ValuesController(DatabaseContext context)
        {
            this._context = context;            
            this.retornoVM = new ReturnM();
        }
        // GET api/values
        [HttpGet]
        public async Task<ReturnM> Get()
        {
            //Testando IQueryable
            var personIQInclude = await (from p in _context.Person
                                   join e in _context.Address
                                     on p.Id equals e.PersonId
                                   select new Person
                                   {
                                       Id = p.Id,
                                       Name = p.Name,
                                       Addresses = new Collection<Address> { new Address { Id = e.Id, Street = e.Street } }
                                   }).ToListAsync();

            retornoVM.PersonIqueryInclude = personIQInclude;

            //Testando IQueryable com Include
            IQueryable<Person> personIQ = from p in _context.Person
                                          .Include(p => p.Addresses)
                                          .Include(p => p.PersonCarNN)
                                            .ThenInclude(p => p.Car)
                                          select p;

            retornoVM.PersonIquery = personIQ;

            //Carregando todos os dados relacionados
            List<Person> people = await _context.Person
                .Include(p => p.Addresses)
                .Include(p => p.PersonCarNN)
                    .ThenInclude(p => p.Car)
                        .ThenInclude(c => c.CarAccessoryNN)
                            .ThenInclude(c => c.Accessory)
                .OrderBy(p => p.Name)
                .ToListAsync();

            retornoVM.Person = people;

            //Testing UnitOfWork
            using (var unitOfWork = new UnitOfWork(_context))
            {
                // Example1
                var person = unitOfWork.Person.Get(1);

                // Example2
                var Address = unitOfWork.Address.GetAddressWithPerson(1, 4);

                // Example3
                var testing = unitOfWork.Person.GetPersonWithAddress(1);
                testing = unitOfWork.Person.GetLastPersonWithAddress();
                unitOfWork.Address.RemoveRange(testing.Addresses);
                unitOfWork.Person.Remove(testing);
                unitOfWork.Complete(); //database update

                var p = new Person { Name = testing.Name };
                foreach (var e in testing.Addresses)
                {
                    p.Addresses.Add(new Address { PersonId = testing.Id, Street = e.Street, Number = e.Number });
                }
                unitOfWork.Person.Add(p);
                unitOfWork.Address.AddRange(p.Addresses);
                unitOfWork.Complete(); //database update
            }

            return retornoVM;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
