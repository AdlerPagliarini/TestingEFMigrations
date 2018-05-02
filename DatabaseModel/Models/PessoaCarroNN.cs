using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseModel.Models
{
    public class PessoaCarroNN
    {
        public int PessoaId { get; set; }
        public int CarroId { get; set; }

        public Pessoa Pessoa { get; set; }
        public Carro Carro { get; set; }


    }
}
