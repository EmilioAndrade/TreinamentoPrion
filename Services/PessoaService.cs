using Backend.Entities;
using Backend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoPrion.Services
{
    public class PessoaService : GenericService<Pessoa>
    {
        public override List<Pessoa> GetAll()
        {
            List<Pessoa> listPessoa = new List<Pessoa>()
            {
                new Pessoa{PessoaId = 1, Nome = "Douglas", Email = "douglas@prion.com.br"},
                new Pessoa{PessoaId = 2, Nome = "Jefferson", Email = "jeff@prion.com.br"},
                new Pessoa{PessoaId = 3, Nome = "Cristiano", Email = "creis@prion.com.br"}
            };

            return listPessoa;
        }
    }
}
