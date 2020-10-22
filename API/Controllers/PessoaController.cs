using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TreinamentoPrion.Services;

namespace API.Controllers
{
    public class PessoaController : GenericController<Pessoa>
    {
        public PessoaController()
        {
            this.service = new PessoaService();
        }
    }
}