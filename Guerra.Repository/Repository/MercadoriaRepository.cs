using Guerra.Domain.Cadastro;
using Guerra.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guerra.Repository.Repository
{
    public class MercadoriaRepository : Repository<Mercadoria>, IMercadoriaRepository
    {
        public MercadoriaRepository(IConfiguration config) : base(config)
        {

        }

    }
}
