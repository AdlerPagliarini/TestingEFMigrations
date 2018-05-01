using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseModel.Models
{
    public class CarroAcessorioNN
    {
        public int CarroId { get; set; }
        public Carro Carro { get; set; }

        public int AcessorioId { get; set; }
        public Acessorio Acessorio { get; set; }
    }
}
