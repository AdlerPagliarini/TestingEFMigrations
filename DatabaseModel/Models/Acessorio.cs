using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseModel.Models
{
    public class Acessorio
    {
        public int Id { get; set; }
        public string Tipo { get; set; }

        /*É possível mas não faz sentido para este contexto de leitura de dados
        public ICollection<CarroAcessorioNN> CarroAcessorioNN { get; set; }

        public Acessorio()
        {
            CarroAcessorioNN = new Collection<CarroAcessorioNN>();
        }
        */
    }
}
