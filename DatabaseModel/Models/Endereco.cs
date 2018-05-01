using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseModel.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string NomeRua { get; set; }

        //Para facilitar navegação
        public Pessoa Pessoa { get; set; }
        public int PessoaId { get; set; }
    }
}
