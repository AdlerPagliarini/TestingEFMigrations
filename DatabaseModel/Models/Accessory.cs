using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseModel.Models
{
    public class Accessory
    {
        public int Id { get; set; }
        public string Type { get; set; }

        /*É possível mas não faz sentido para este contexto de leitura de dados
        public ICollection<CarAccessoryNN> CarAccessoryNN { get; set; }

        public Accessory()
        {
            CarAccessoryNN = new Collection<CarAccessoryNN>();
        }
        */
    }
}
