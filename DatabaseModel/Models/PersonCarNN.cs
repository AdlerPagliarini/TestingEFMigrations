using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseModel.Models
{
    public class PersonCarNN
    {
        public int PersonId { get; set; }
        public int CarId { get; set; }

        public Person Person { get; set; }
        public Car Car { get; set; }


    }
}
