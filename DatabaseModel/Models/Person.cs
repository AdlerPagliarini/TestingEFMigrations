using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseModel.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<PersonCarNN> PersonCarNN { get; set; }

        public Person()
        {
            Addresses = new Collection<Address>();
            PersonCarNN = new Collection<PersonCarNN>();
        }
    }
}
