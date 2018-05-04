using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseModel.Models
{
    public class CarAccessoryNN
    {
        public int CarId { get; set; }
        public Car Car { get; set; }

        public int AccessoryId { get; set; }
        public Accessory Accessory { get; set; }
    }
}
