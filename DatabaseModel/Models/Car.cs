using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseModel.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }

        public virtual ICollection<CarAccessoryNN> CarAccessoryNN { get; set; }
        public virtual ICollection<PersonCarNN> PersonCarNN { get; set; }

        public Car()
        {
            CarAccessoryNN = new Collection<CarAccessoryNN>();
            PersonCarNN = new Collection<PersonCarNN>();
        }
    }
}
