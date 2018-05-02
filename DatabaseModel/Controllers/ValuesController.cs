using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using DatabaseModel.DataContext;
using DatabaseModel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatabaseModel.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        public class RetornoVM
        {
            public IEnumerable<Pessoa> Pessoas { get; set; }
            public IEnumerable<Pessoa> PessoasIquery { get; set; }
            public IEnumerable<Pessoa> PessoasIqueryInclude { get; set; }
        }

        private readonly DataMyContext _context;
        private RetornoVM retornoVM;

        public ValuesController(DataMyContext context)
        {
            this._context = context;
            this.retornoVM = new RetornoVM();
        }
        // GET api/values
        [HttpGet]
        public async Task<RetornoVM> Get()
        {
            //Testando IQueryable
            var pessoaIQInclude = await (from p in _context.Pessoa
                                   join e in _context.Endereco
                                     on p.Id equals e.PessoaId
                                   select new Pessoa
                                   {
                                       Id = p.Id,
                                       Nome = p.Nome,
                                       Enderecos = new Collection<Endereco> { new Endereco { Id = e.Id, NomeRua = e.NomeRua } }
                                   }).ToListAsync();

            retornoVM.PessoasIqueryInclude = pessoaIQInclude;

            //Testando IQueryable com Include
            IQueryable<Pessoa> pessoaIQ = from p in _context.Pessoa
                                          .Include(p => p.Enderecos)
                                          .Include(p => p.PessoaCarroNN)
                                          .ThenInclude(p => p.Carro)
                                          select p;

            retornoVM.PessoasIquery = pessoaIQ;

            //Carregando todos os dados relacionados
            List<Pessoa> pessoas = await _context.Pessoa
                .Include(p => p.Enderecos)
                .Include(p => p.PessoaCarroNN)
                    .ThenInclude(p => p.Carro)
                        .ThenInclude(c => c.CarroAcessorioNN)
                            .ThenInclude(c => c.Acessorio)
                .OrderBy(p => p.Nome)
                .ToListAsync();

            retornoVM.Pessoas = pessoas;

            return retornoVM;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
