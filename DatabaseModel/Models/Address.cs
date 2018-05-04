using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseModel.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }

        //Para facilitar navegação
        public virtual Person Person { get; set; }
        public int PersonId { get; set; }
    }
}
