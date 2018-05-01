using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseModel.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Marca { get; set; }

        public ICollection<CarroAcessorioNN> CarroAcessorioNN { get; set; }

        public Carro()
        {
            CarroAcessorioNN = new Collection<CarroAcessorioNN>();
        }
    }
}
