using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseModel.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Endereco> Enderecos { get; set; }
        public virtual ICollection<PessoaCarroNN> PessoaCarroNN { get; set; }

        public Pessoa()
        {
            Enderecos = new Collection<Endereco>();
            PessoaCarroNN = new Collection<PessoaCarroNN>();
        }
    }
}
